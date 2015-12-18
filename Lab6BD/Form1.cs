using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab6BD
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                // FILL DATASET
                adapterCategorii.Fill(dataSet, "categorii");
                adapterPreparate.Fill(dataSet, "preparate");
                adapterIngrediente.Fill(dataSet, "ingrediente");
                adapterRetete.Fill(dataSet, "retete");

                listCategorii.Items.Clear();
                for (int i = 0; i < dataSet.Tables["categorii"].Rows.Count; i++)
                {
                    listCategorii.Items.Add(dataSet.Tables["categorii"].Rows[i]["codc"] + "." + dataSet.Tables["categorii"].Rows[i]["numec"]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void refresh_preparate()
        {
            try
            {
                // CHECK IF SELECTED ITEM
                if (listCategorii.SelectedItem == null)
                {
                    MessageBox.Show("Nu ati selectat nicio categorie!");
                    return;
                }

                listPreparate.Items.Clear();
                string codc = listCategorii.Items[listCategorii.SelectedIndex].ToString().Split('.')[0];
                for (int i = 0; i < dataSet.Tables["preparate"].Rows.Count; i++)
                {
                    if (codc == dataSet.Tables["preparate"].Rows[i]["codc"].ToString())
                    {
                        listPreparate.Items.Add(dataSet.Tables["preparate"].Rows[i]["numep"].ToString());
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void listCategorii_SelectedIndexChanged(object sender, EventArgs e)
        {
            refresh_preparate();
        }

        private void listPreparate_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                // CHECK IF SELECTED ITEM
                if (listPreparate.SelectedItem == null)
                {
                    MessageBox.Show("Nu ati selectat niciun preparat!");
                    return;
                }

                connection.Open();
                string numep = listPreparate.Items[listPreparate.SelectedIndex].ToString();
                command = new SqlCommand("select p.pret, p.timp_preparare, p.codp, p.codc from preparate as p where p.numep='"+numep+"'", connection);
                SqlDataReader reader = command.ExecuteReader();
                
                if (reader.Read())
                {
                    textPret.Text = reader[0].ToString();
                    textTimpPrep.Text = reader[1].ToString();
                    textBoxCodC.Text = reader[3].ToString();
                    textBoxNumePrep.Text = numep;
                }

                int codp = (Int32)reader[2];
                listBoxIngrediente.Items.Clear();

                sqlConnection1.Open();
                SqlCommand mycommand = new SqlCommand("select r.cantitate, r.codi from retete as r where r.codp='"+codp+ "'", sqlConnection1);
                SqlDataReader myR = mycommand.ExecuteReader();
                while (myR.Read())
                {
                    int codi = (Int32)myR[1];
                    for (int i = 0; i < dataSet.Tables["ingrediente"].Rows.Count; i++)
                    {
                        if (codi == (Int32)dataSet.Tables["ingrediente"].Rows[i]["codi"])
                        {
                            listBoxIngrediente.Items.Add(myR[0].ToString() + " " + dataSet.Tables["ingrediente"].Rows[i]["unitate_masura"] + " " + dataSet.Tables["ingrediente"].Rows[i]["numei"]);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
                sqlConnection1.Close();
            }
        }

        private void buttDelPreparat_Click(object sender, EventArgs e)
        {
            try
            {
                // CHECK IF SELECTED ITEM
                if (listPreparate.SelectedItem == null)
                {
                    MessageBox.Show("Nu ati selectat niciun preparat!");
                    return;
                }

                connection.Open();
                string numep = listPreparate.Items[listPreparate.SelectedIndex].ToString();
                SqlCommand com = new SqlCommand("select preparate.codp from preparate where preparate.numep='"+numep+"'", connection);
                SqlDataReader reader = com.ExecuteReader();
                reader.Read();
                
                string codp = reader[0].ToString();

                for (int i = 0; i < dataSet.Tables["retete"].Rows.Count; i++)
                {
                    if (dataSet.Tables["retete"].Rows[i]["codp"].ToString() == codp)
                    {
                        dataSet.Tables["retete"].AcceptChanges();
                        dataSet.Tables["retete"].Rows[i].Delete();
                    }
                }

                adapterRetete.DeleteCommand = new SqlCommand("DELETE FROM retete WHERE codp='"+codp+"'", connection);
                adapterRetete.Update(dataSet, "retete");
                
                for (int i = 0; i < dataSet.Tables["preparate"].Rows.Count; i++)
                {
                    if (dataSet.Tables["preparate"].Rows[i]["codp"].ToString() == codp)
                    {
                        dataSet.Tables["preparate"].AcceptChanges();
                        dataSet.Tables["preparate"].Rows[i].Delete();
                        break;
                    }
                }

                adapterPreparate.DeleteCommand = new SqlCommand("DELETE FROM preparate WHERE codp='" + codp + "'", connection);
                adapterPreparate.Update(dataSet, "preparate");
                
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                refresh_preparate();
                listBoxIngrediente.Items.Clear();
                textPret.Clear();
                textTimpPrep.Clear();
                textBoxCodC.Clear();
                textBoxNumePrep.Clear();
                connection.Close();
            }
        }

        private void buttEditPrep_Click(object sender, EventArgs e)
        {
            try
            {
                if (listPreparate.SelectedItem == null)
                {
                    MessageBox.Show("Nu ati selectat niciun preparat!");
                    return;
                }
                connection.Open();
                string numep = listPreparate.Items[listPreparate.SelectedIndex].ToString();
                SqlCommand com = new SqlCommand("select preparate.codp from preparate where preparate.numep='" + numep + "'", connection);
                SqlDataReader reader = com.ExecuteReader();
                reader.Read();
                string codp = reader[0].ToString();

                for (int i = 1; i < dataSet.Tables["preparate"].Rows.Count; i++)
                {
                    if (dataSet.Tables["preparate"].Rows[i]["codp"].ToString() == codp)
                    {
                        adapterPreparate.UpdateCommand = new SqlCommand("update preparate set codc='" + Convert.ToInt32(textBoxCodC.Text) + "', numep='" + textBoxNumePrep.Text + "', pret='" + Convert.ToInt32(textPret.Text) + "', timp_preparare='" + Convert.ToInt32(textTimpPrep.Text) + "' where codp='" + codp + "'", connection);
                        
                        dataSet.Tables["preparate"].AcceptChanges();
                        dataSet.Tables["preparate"].Rows[i]["codc"] = Convert.ToInt32(textBoxCodC.Text);
                        dataSet.Tables["preparate"].Rows[i]["pret"] = Convert.ToInt32(textPret.Text);
                        dataSet.Tables["preparate"].Rows[i]["timp_preparare"] = Convert.ToInt32(textTimpPrep.Text);
                        dataSet.Tables["preparate"].Rows[i]["numep"] = textBoxNumePrep.Text;

                        adapterPreparate.Update(dataSet, "preparate");
                        break;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
                refresh_preparate();
                textBoxCodC.Clear();
                textBoxNumePrep.Clear();
                textPret.Clear();
                textTimpPrep.Clear();
            }
        }

        private void buttAddPrep_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();

                for (int i = 0; i < dataSet.Tables["preparate"].Rows.Count; i++)
                {
                    if (dataSet.Tables["preparate"].Rows[i]["numep"].ToString() == textBoxNumePrep.Text)
                    {
                        MessageBox.Show("Exista deja un preparat cu acest nume!");
                        return;
                    }
                }

                command = new SqlCommand("select max(preparate.codp) from preparate", connection);
                SqlDataReader reader = command.ExecuteReader();
                reader.Read();
                int codp = Convert.ToInt32(reader.GetValue(0)) + 1;
                
                DataRow newRow = dataSet.Tables["preparate"].NewRow();
                dataSet.Tables["preparate"].AcceptChanges();
                newRow["codc"] = textBoxCodC.Text;
                newRow["codp"] = codp;
                newRow["numep"] = textBoxNumePrep.Text;
                newRow["pret"] = textPret.Text;
                newRow["timp_preparare"] = textTimpPrep.Text;
                dataSet.Tables["preparate"].Rows.Add(newRow);

                adapterPreparate.InsertCommand = new SqlCommand("insert into preparate (codp, codc, numep, pret, timp_preparare) values ("+codp.ToString()+", "+textBoxCodC.Text+", '"+textBoxNumePrep.Text+"', "+textPret.Text+", "+textTimpPrep.Text+")", connection);
                adapterPreparate.Update(dataSet, "preparate");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                refresh_preparate();
                connection.Close();
            }
        }

        void refresh_ingrediente()
        {
            try
            {
                listFullIngrediente.Items.Clear();
                for (int i = 0; i < dataSet.Tables["ingrediente"].Rows.Count; i++)
                {
                    listFullIngrediente.Items.Add(dataSet.Tables["ingrediente"].Rows[i]["codi"].ToString() + "." + dataSet.Tables["ingrediente"].Rows[i]["numei"].ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            refresh_ingrediente();
        }

        private void listFullIngrediente_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                listBoxPrep2.Items.Clear();
                connection.Open();
                string codi = listFullIngrediente.Items[listFullIngrediente.SelectedIndex].ToString().Split('.')[0];
                for (int i = 0; i < dataSet.Tables["ingrediente"].Rows.Count; i++)
                {
                    if (dataSet.Tables["ingrediente"].Rows[i]["codi"].ToString() == codi)
                    {
                        textBoxCodIng.Text = codi;
                        textBoxNumeIng.Text = dataSet.Tables["ingrediente"].Rows[i]["numei"].ToString();
                        textBoxUnitMasura.Text = dataSet.Tables["ingrediente"].Rows[i]["unitate_masura"].ToString();
                        break;
                    }
                }

                command = new SqlCommand("select retete.codp from retete where retete.codi='"+codi+"'", connection);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    string codp = reader.GetValue(0).ToString();
                    for (int i = 0; i < dataSet.Tables["preparate"].Rows.Count; i++)
                    {
                        if (dataSet.Tables["preparate"].Rows[i]["codp"].ToString() == codp)
                        {
                            listBoxPrep2.Items.Add(dataSet.Tables["preparate"].Rows[i]["numep"].ToString());
                            break;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        private void buttonAddIngredient_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBoxCodIng.Text == "") { return; }
                for (int i = 0; i < dataSet.Tables["ingrediente"].Rows.Count; i++)
                {
                    if (dataSet.Tables["ingrediente"].Rows[i]["codi"].ToString() == textBoxCodIng.Text)
                    {
                        MessageBox.Show("Exista deja un ingredient cu acest cod!");
                        return;
                    }
                }
                command = new SqlCommand("insert into ingrediente (codi, numei, unitate_masura) values ("+textBoxCodIng.Text+", '"+textBoxNumeIng.Text+"', '"+textBoxUnitMasura.Text+"')", connection);
                adapterIngrediente.InsertCommand = command;

                dataSet.Tables["ingrediente"].AcceptChanges();
                DataRow row = dataSet.Tables["ingrediente"].NewRow();
                row["codi"] = textBoxCodIng.Text;
                row["numei"] = textBoxNumeIng.Text;
                row["unitate_masura"] = textBoxUnitMasura.Text;
                dataSet.Tables["ingrediente"].Rows.Add(row);

                adapterIngrediente.Update(dataSet, "ingrediente");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                textBoxNumeIng.Clear();
                textBoxCodIng.Clear();
                textBoxUnitMasura.Clear();
                refresh_ingrediente();
            }
        }

        private void buttonModifIngredient_Click(object sender, EventArgs e)
        {
            try
            {
                command = new SqlCommand("UPDATE ingrediente SET unitate_masura='" + textBoxUnitMasura.Text + "', numei='" + textBoxNumeIng.Text + "' WHERE codi='" + textBoxCodIng.Text + "'", connection);
                adapterIngrediente.UpdateCommand = command;

                for (int i = 0; i < dataSet.Tables["ingrediente"].Rows.Count; i++)
                {
                    if (dataSet.Tables["ingrediente"].Rows[i]["codi"].ToString() == textBoxCodIng.Text)
                    {
                        dataSet.Tables["ingrediente"].AcceptChanges();
                        dataSet.Tables["ingrediente"].Rows[i]["numei"] = textBoxNumeIng.Text;
                        dataSet.Tables["ingrediente"].Rows[i]["unitate_masura"] = textBoxUnitMasura.Text;
                        adapterIngrediente.Update(dataSet, "ingrediente");
                        return;
                    }
                }
                MessageBox.Show("Ingredient selectat gresit!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                refresh_ingrediente();
            }
        }

        private void buttonDelIngredient_Click(object sender, EventArgs e)
        {
            try
            {
                command = new SqlCommand("DELETE FROM ingrediente WHERE codi='"+textBoxCodIng.Text+"'", connection);
                adapterIngrediente.DeleteCommand = command;

                string codi = listFullIngrediente.Items[listFullIngrediente.SelectedIndex].ToString().Split('.')[0];
                for (int i = 0; i < dataSet.Tables["retete"].Rows.Count; i++)
                {
                    if (dataSet.Tables["retete"].Rows[i]["codi"].ToString() == codi)
                    {
                        MessageBox.Show("Nu se permite stergerea! Exista reteta care contine acest ingredient!");
                        return;
                    }
                }

                for (int i = 0; i < dataSet.Tables["ingrediente"].Rows.Count; i++)
                {
                    if (dataSet.Tables["ingrediente"].Rows[i]["codi"].ToString() == codi)
                    {
                        dataSet.Tables["ingrediente"].AcceptChanges();
                        dataSet.Tables["ingrediente"].Rows[i].Delete();
                        adapterIngrediente.Update(dataSet, "ingrediente");
                        break;
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                textBoxCodIng.Clear();
                textBoxNumeIng.Clear();
                textBoxUnitMasura.Clear();
                refresh_ingrediente();
            }
        }

        private void buttonAdaugaIngInPrep_Click(object sender, EventArgs e)
        {
            try
            {
                if (listFullIngrediente.SelectedItem == null)
                {
                    MessageBox.Show("Nu ati selectat niciun ingredient!");
                    return;
                }
                else if (listPreparate.SelectedItem == null)
                {
                    MessageBox.Show("Nu ati selectat niciun preparat!");
                    return;
                }
                else
                {
                    int codp =0;
                    connection.Open();
                    string codi = listFullIngrediente.Items[listFullIngrediente.SelectedIndex].ToString().Split('.')[0];
                    string numep = listPreparate.Items[listPreparate.SelectedIndex].ToString();
                    command = new SqlCommand("select p.codp from preparate as p where p.numep='" + numep + "'", connection);
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        codp = Convert.ToInt32(reader.GetValue(0));
                    }

                    for (int i = 0; i < dataSet.Tables["retete"].Rows.Count; i++)
                    {
                        if (dataSet.Tables["retete"].Rows[i]["codp"].ToString() == codp.ToString() && dataSet.Tables["retete"].Rows[i]["codi"].ToString() == codi)
                        {
                            MessageBox.Show("Ingredientul se afla deja in componenta preparatului!");
                            return;
                        }
                    }

                    adapterRetete.InsertCommand = new SqlCommand("insert into retete (codp, codi, cantitate) values ("+codp.ToString()+", "+codi+", '"+textBoxCantitate.Text+"')", connection);
                    dataSet.Tables["retete"].AcceptChanges();
                    DataRow row = dataSet.Tables["retete"].NewRow();
                    row["codp"] = codp;
                    row["codi"] = Convert.ToInt32(codi);
                    row["cantitate"] = textBoxCantitate.Text;
                    dataSet.Tables["retete"].Rows.Add(row);

                    adapterRetete.Update(dataSet, "retete");

                    refresh_ingrediente();
                    refresh_preparate();
                    listBoxIngrediente.Items.Clear();
                    listBoxPrep2.Items.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        private void buttonStergeIngDinPrep_Click(object sender, EventArgs e)
        {
            try
            {
                if (listFullIngrediente.SelectedItem == null)
                {
                    MessageBox.Show("Nu ati selectat niciun ingredient!");
                    return;
                }
                else if (listPreparate.SelectedItem == null)
                {
                    MessageBox.Show("Nu ati selectat niciun preparat!");
                    return;
                }
                else
                {
                    connection.Open();
                    string codi = listFullIngrediente.Items[listFullIngrediente.SelectedIndex].ToString().Split('.')[0];
                    string numep = listPreparate.Items[listPreparate.SelectedIndex].ToString();
                    command = new SqlCommand("select p.codp from preparate as p where p.numep='" + numep + "'", connection);
                    SqlDataReader reader = command.ExecuteReader();

                    int codp=0;
                    if (reader.Read())
                    {
                        codp = Convert.ToInt32(reader.GetValue(0));
                    }
                    int pi = 0;
                    for (int i = 0; i < dataSet.Tables["retete"].Rows.Count; i++)
                    {
                        if (dataSet.Tables["retete"].Rows[i]["codp"].ToString() == codp.ToString() && dataSet.Tables["retete"].Rows[i]["codi"].ToString() == codi)
                        {
                            adapterRetete.DeleteCommand = new SqlCommand("DELETE FROM retete WHERE codi='"+codi+"' and codp='"+codp.ToString()+"'", connection);
                            dataSet.Tables["retete"].AcceptChanges();
                            dataSet.Tables["retete"].Rows[i].Delete();
                            adapterRetete.Update(dataSet, "retete");
                            pi = 1;
                        }
                    }
                    if (pi == 0)
                    {
                        MessageBox.Show("Ingredientul nu se afla deja in componenta preparatului!");
                        return;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                refresh_ingrediente();
                refresh_preparate();
                listBoxPrep2.Items.Clear();
                listBoxIngrediente.Items.Clear();
                connection.Close();
            }
        }
    }
}
