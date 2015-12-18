namespace Lab6BD
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.listCategorii = new System.Windows.Forms.ListBox();
            this.listPreparate = new System.Windows.Forms.ListBox();
            this.command = new System.Data.SqlClient.SqlCommand();
            this.connection = new System.Data.SqlClient.SqlConnection();
            this.sqlSelectCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlInsertCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlUpdateCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlDeleteCommand1 = new System.Data.SqlClient.SqlCommand();
            this.adapterCategorii = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlSelectCommand2 = new System.Data.SqlClient.SqlCommand();
            this.sqlInsertCommand2 = new System.Data.SqlClient.SqlCommand();
            this.sqlUpdateCommand2 = new System.Data.SqlClient.SqlCommand();
            this.sqlDeleteCommand2 = new System.Data.SqlClient.SqlCommand();
            this.adapterIngrediente = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlSelectCommand3 = new System.Data.SqlClient.SqlCommand();
            this.sqlInsertCommand3 = new System.Data.SqlClient.SqlCommand();
            this.sqlUpdateCommand3 = new System.Data.SqlClient.SqlCommand();
            this.sqlDeleteCommand3 = new System.Data.SqlClient.SqlCommand();
            this.adapterPreparate = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlSelectCommand4 = new System.Data.SqlClient.SqlCommand();
            this.sqlInsertCommand4 = new System.Data.SqlClient.SqlCommand();
            this.sqlUpdateCommand4 = new System.Data.SqlClient.SqlCommand();
            this.sqlDeleteCommand4 = new System.Data.SqlClient.SqlCommand();
            this.adapterRetete = new System.Data.SqlClient.SqlDataAdapter();
            this.dataSet = new System.Data.DataSet();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textPret = new System.Windows.Forms.TextBox();
            this.textTimpPrep = new System.Windows.Forms.TextBox();
            this.listBoxIngrediente = new System.Windows.Forms.ListBox();
            this.sqlConnection1 = new System.Data.SqlClient.SqlConnection();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.buttAddPrep = new System.Windows.Forms.Button();
            this.buttEditPrep = new System.Windows.Forms.Button();
            this.buttDelPreparat = new System.Windows.Forms.Button();
            this.textBoxNumePrep = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxCodC = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.listFullIngrediente = new System.Windows.Forms.ListBox();
            this.label14 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.textBoxUnitMasura = new System.Windows.Forms.TextBox();
            this.listBoxPrep2 = new System.Windows.Forms.ListBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.textBoxCodIng = new System.Windows.Forms.TextBox();
            this.textBoxNumeIng = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.buttonAddIngredient = new System.Windows.Forms.Button();
            this.buttonModifIngredient = new System.Windows.Forms.Button();
            this.buttonDelIngredient = new System.Windows.Forms.Button();
            this.buttonAdaugaIngInPrep = new System.Windows.Forms.Button();
            this.buttonStergeIngDinPrep = new System.Windows.Forms.Button();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.textBoxCantitate = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // listCategorii
            // 
            this.listCategorii.FormattingEnabled = true;
            this.listCategorii.Location = new System.Drawing.Point(12, 25);
            this.listCategorii.Name = "listCategorii";
            this.listCategorii.Size = new System.Drawing.Size(124, 199);
            this.listCategorii.TabIndex = 0;
            this.listCategorii.SelectedIndexChanged += new System.EventHandler(this.listCategorii_SelectedIndexChanged);
            // 
            // listPreparate
            // 
            this.listPreparate.FormattingEnabled = true;
            this.listPreparate.Location = new System.Drawing.Point(142, 25);
            this.listPreparate.Name = "listPreparate";
            this.listPreparate.Size = new System.Drawing.Size(129, 82);
            this.listPreparate.TabIndex = 1;
            this.listPreparate.SelectedIndexChanged += new System.EventHandler(this.listPreparate_SelectedIndexChanged);
            // 
            // command
            // 
            this.command.Connection = this.connection;
            // 
            // connection
            // 
            this.connection.ConnectionString = "Data Source=(localdb)\\v11.0;Initial Catalog=Retete;MultipleActiveResultSets=True;" +
    "Integrated Security=True";
            this.connection.FireInfoMessageEventOnUserErrors = false;
            // 
            // sqlSelectCommand1
            // 
            this.sqlSelectCommand1.CommandText = "SELECT        categorii.*, codc AS Expr1, numec AS Expr2\r\nFROM            categor" +
    "ii";
            this.sqlSelectCommand1.Connection = this.connection;
            // 
            // sqlInsertCommand1
            // 
            this.sqlInsertCommand1.CommandText = resources.GetString("sqlInsertCommand1.CommandText");
            this.sqlInsertCommand1.Connection = this.connection;
            this.sqlInsertCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@codc", System.Data.SqlDbType.Int, 0, "codc"),
            new System.Data.SqlClient.SqlParameter("@numec", System.Data.SqlDbType.VarChar, 0, "numec"),
            new System.Data.SqlClient.SqlParameter("@Expr1", System.Data.SqlDbType.Int, 0, "Expr1"),
            new System.Data.SqlClient.SqlParameter("@Expr2", System.Data.SqlDbType.VarChar, 0, "Expr2")});
            // 
            // sqlUpdateCommand1
            // 
            this.sqlUpdateCommand1.CommandText = resources.GetString("sqlUpdateCommand1.CommandText");
            this.sqlUpdateCommand1.Connection = this.connection;
            this.sqlUpdateCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@codc", System.Data.SqlDbType.Int, 0, "codc"),
            new System.Data.SqlClient.SqlParameter("@numec", System.Data.SqlDbType.VarChar, 0, "numec"),
            new System.Data.SqlClient.SqlParameter("@Expr1", System.Data.SqlDbType.Int, 0, "Expr1"),
            new System.Data.SqlClient.SqlParameter("@Expr2", System.Data.SqlDbType.VarChar, 0, "Expr2"),
            new System.Data.SqlClient.SqlParameter("@Original_codc", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "codc", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_numec", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "numec", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_numec", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "numec", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Expr1", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Expr1", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Expr2", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Expr2", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Expr2", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Expr2", System.Data.DataRowVersion.Original, null)});
            // 
            // sqlDeleteCommand1
            // 
            this.sqlDeleteCommand1.CommandText = resources.GetString("sqlDeleteCommand1.CommandText");
            this.sqlDeleteCommand1.Connection = this.connection;
            this.sqlDeleteCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@Original_codc", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "codc", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_numec", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "numec", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_numec", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "numec", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Expr1", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Expr1", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Expr2", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Expr2", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Expr2", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Expr2", System.Data.DataRowVersion.Original, null)});
            // 
            // adapterCategorii
            // 
            this.adapterCategorii.DeleteCommand = this.sqlDeleteCommand1;
            this.adapterCategorii.InsertCommand = this.sqlInsertCommand1;
            this.adapterCategorii.SelectCommand = this.sqlSelectCommand1;
            this.adapterCategorii.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "categorii", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("codc", "codc"),
                        new System.Data.Common.DataColumnMapping("numec", "numec"),
                        new System.Data.Common.DataColumnMapping("Expr1", "Expr1"),
                        new System.Data.Common.DataColumnMapping("Expr2", "Expr2")})});
            this.adapterCategorii.UpdateCommand = this.sqlUpdateCommand1;
            // 
            // sqlSelectCommand2
            // 
            this.sqlSelectCommand2.CommandText = "SELECT        codi AS Expr1, ingrediente.*, numei AS Expr2, unitate_masura AS Exp" +
    "r3\r\nFROM            ingrediente";
            this.sqlSelectCommand2.Connection = this.connection;
            // 
            // sqlInsertCommand2
            // 
            this.sqlInsertCommand2.CommandText = resources.GetString("sqlInsertCommand2.CommandText");
            this.sqlInsertCommand2.Connection = this.connection;
            this.sqlInsertCommand2.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@Expr1", System.Data.SqlDbType.Int, 0, "Expr1"),
            new System.Data.SqlClient.SqlParameter("@codi", System.Data.SqlDbType.Int, 0, "codi"),
            new System.Data.SqlClient.SqlParameter("@numei", System.Data.SqlDbType.VarChar, 0, "numei"),
            new System.Data.SqlClient.SqlParameter("@unitate_masura", System.Data.SqlDbType.VarChar, 0, "unitate_masura"),
            new System.Data.SqlClient.SqlParameter("@Expr2", System.Data.SqlDbType.VarChar, 0, "Expr2"),
            new System.Data.SqlClient.SqlParameter("@Expr3", System.Data.SqlDbType.VarChar, 0, "Expr3")});
            // 
            // sqlUpdateCommand2
            // 
            this.sqlUpdateCommand2.CommandText = resources.GetString("sqlUpdateCommand2.CommandText");
            this.sqlUpdateCommand2.Connection = this.connection;
            this.sqlUpdateCommand2.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@Expr1", System.Data.SqlDbType.Int, 0, "Expr1"),
            new System.Data.SqlClient.SqlParameter("@codi", System.Data.SqlDbType.Int, 0, "codi"),
            new System.Data.SqlClient.SqlParameter("@numei", System.Data.SqlDbType.VarChar, 0, "numei"),
            new System.Data.SqlClient.SqlParameter("@unitate_masura", System.Data.SqlDbType.VarChar, 0, "unitate_masura"),
            new System.Data.SqlClient.SqlParameter("@Expr2", System.Data.SqlDbType.VarChar, 0, "Expr2"),
            new System.Data.SqlClient.SqlParameter("@Expr3", System.Data.SqlDbType.VarChar, 0, "Expr3"),
            new System.Data.SqlClient.SqlParameter("@Original_Expr1", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Expr1", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_codi", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "codi", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_numei", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "numei", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_numei", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "numei", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_unitate_masura", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "unitate_masura", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_unitate_masura", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "unitate_masura", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Expr2", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Expr2", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Expr2", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Expr2", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Expr3", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Expr3", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Expr3", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Expr3", System.Data.DataRowVersion.Original, null)});
            // 
            // sqlDeleteCommand2
            // 
            this.sqlDeleteCommand2.CommandText = resources.GetString("sqlDeleteCommand2.CommandText");
            this.sqlDeleteCommand2.Connection = this.connection;
            this.sqlDeleteCommand2.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@Original_Expr1", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Expr1", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_codi", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "codi", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_numei", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "numei", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_numei", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "numei", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_unitate_masura", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "unitate_masura", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_unitate_masura", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "unitate_masura", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Expr2", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Expr2", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Expr2", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Expr2", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Expr3", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Expr3", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Expr3", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Expr3", System.Data.DataRowVersion.Original, null)});
            // 
            // adapterIngrediente
            // 
            this.adapterIngrediente.DeleteCommand = this.sqlDeleteCommand2;
            this.adapterIngrediente.InsertCommand = this.sqlInsertCommand2;
            this.adapterIngrediente.SelectCommand = this.sqlSelectCommand2;
            this.adapterIngrediente.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "ingrediente", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("Expr1", "Expr1"),
                        new System.Data.Common.DataColumnMapping("codi", "codi"),
                        new System.Data.Common.DataColumnMapping("numei", "numei"),
                        new System.Data.Common.DataColumnMapping("unitate_masura", "unitate_masura"),
                        new System.Data.Common.DataColumnMapping("Expr2", "Expr2"),
                        new System.Data.Common.DataColumnMapping("Expr3", "Expr3")})});
            this.adapterIngrediente.UpdateCommand = this.sqlUpdateCommand2;
            // 
            // sqlSelectCommand3
            // 
            this.sqlSelectCommand3.CommandText = "SELECT        preparate.*, codp AS Expr1, codc AS Expr2, numep AS Expr3, pret AS " +
    "Expr4, timp_preparare AS Expr5\r\nFROM            preparate";
            this.sqlSelectCommand3.Connection = this.connection;
            // 
            // sqlInsertCommand3
            // 
            this.sqlInsertCommand3.CommandText = resources.GetString("sqlInsertCommand3.CommandText");
            this.sqlInsertCommand3.Connection = this.connection;
            this.sqlInsertCommand3.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@codp", System.Data.SqlDbType.Int, 0, "codp"),
            new System.Data.SqlClient.SqlParameter("@codc", System.Data.SqlDbType.Int, 0, "codc"),
            new System.Data.SqlClient.SqlParameter("@numep", System.Data.SqlDbType.VarChar, 0, "numep"),
            new System.Data.SqlClient.SqlParameter("@pret", System.Data.SqlDbType.Int, 0, "pret"),
            new System.Data.SqlClient.SqlParameter("@timp_preparare", System.Data.SqlDbType.Int, 0, "timp_preparare"),
            new System.Data.SqlClient.SqlParameter("@Expr1", System.Data.SqlDbType.Int, 0, "Expr1"),
            new System.Data.SqlClient.SqlParameter("@Expr2", System.Data.SqlDbType.Int, 0, "Expr2"),
            new System.Data.SqlClient.SqlParameter("@Expr3", System.Data.SqlDbType.VarChar, 0, "Expr3"),
            new System.Data.SqlClient.SqlParameter("@Expr4", System.Data.SqlDbType.Int, 0, "Expr4"),
            new System.Data.SqlClient.SqlParameter("@Expr5", System.Data.SqlDbType.Int, 0, "Expr5")});
            // 
            // sqlUpdateCommand3
            // 
            this.sqlUpdateCommand3.CommandText = resources.GetString("sqlUpdateCommand3.CommandText");
            this.sqlUpdateCommand3.Connection = this.connection;
            this.sqlUpdateCommand3.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@codp", System.Data.SqlDbType.Int, 0, "codp"),
            new System.Data.SqlClient.SqlParameter("@codc", System.Data.SqlDbType.Int, 0, "codc"),
            new System.Data.SqlClient.SqlParameter("@numep", System.Data.SqlDbType.VarChar, 0, "numep"),
            new System.Data.SqlClient.SqlParameter("@pret", System.Data.SqlDbType.Int, 0, "pret"),
            new System.Data.SqlClient.SqlParameter("@timp_preparare", System.Data.SqlDbType.Int, 0, "timp_preparare"),
            new System.Data.SqlClient.SqlParameter("@Expr1", System.Data.SqlDbType.Int, 0, "Expr1"),
            new System.Data.SqlClient.SqlParameter("@Expr2", System.Data.SqlDbType.Int, 0, "Expr2"),
            new System.Data.SqlClient.SqlParameter("@Expr3", System.Data.SqlDbType.VarChar, 0, "Expr3"),
            new System.Data.SqlClient.SqlParameter("@Expr4", System.Data.SqlDbType.Int, 0, "Expr4"),
            new System.Data.SqlClient.SqlParameter("@Expr5", System.Data.SqlDbType.Int, 0, "Expr5"),
            new System.Data.SqlClient.SqlParameter("@Original_codp", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "codp", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_codc", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "codc", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_codc", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "codc", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_numep", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "numep", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_numep", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "numep", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_pret", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "pret", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_pret", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "pret", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_timp_preparare", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "timp_preparare", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_timp_preparare", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "timp_preparare", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Expr1", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Expr1", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Expr2", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Expr2", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Expr2", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Expr2", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Expr3", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Expr3", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Expr3", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Expr3", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Expr4", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Expr4", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Expr4", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Expr4", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Expr5", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Expr5", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Expr5", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Expr5", System.Data.DataRowVersion.Original, null)});
            // 
            // sqlDeleteCommand3
            // 
            this.sqlDeleteCommand3.CommandText = resources.GetString("sqlDeleteCommand3.CommandText");
            this.sqlDeleteCommand3.Connection = this.connection;
            this.sqlDeleteCommand3.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@Original_codp", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "codp", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_codc", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "codc", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_codc", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "codc", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_numep", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "numep", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_numep", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "numep", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_pret", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "pret", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_pret", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "pret", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_timp_preparare", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "timp_preparare", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_timp_preparare", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "timp_preparare", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Expr1", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Expr1", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Expr2", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Expr2", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Expr2", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Expr2", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Expr3", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Expr3", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Expr3", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Expr3", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Expr4", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Expr4", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Expr4", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Expr4", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Expr5", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Expr5", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Expr5", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Expr5", System.Data.DataRowVersion.Original, null)});
            // 
            // adapterPreparate
            // 
            this.adapterPreparate.DeleteCommand = this.sqlDeleteCommand3;
            this.adapterPreparate.InsertCommand = this.sqlInsertCommand3;
            this.adapterPreparate.SelectCommand = this.sqlSelectCommand3;
            this.adapterPreparate.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "preparate", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("codp", "codp"),
                        new System.Data.Common.DataColumnMapping("codc", "codc"),
                        new System.Data.Common.DataColumnMapping("numep", "numep"),
                        new System.Data.Common.DataColumnMapping("pret", "pret"),
                        new System.Data.Common.DataColumnMapping("timp_preparare", "timp_preparare"),
                        new System.Data.Common.DataColumnMapping("Expr1", "Expr1"),
                        new System.Data.Common.DataColumnMapping("Expr2", "Expr2"),
                        new System.Data.Common.DataColumnMapping("Expr3", "Expr3"),
                        new System.Data.Common.DataColumnMapping("Expr4", "Expr4"),
                        new System.Data.Common.DataColumnMapping("Expr5", "Expr5")})});
            this.adapterPreparate.UpdateCommand = this.sqlUpdateCommand3;
            // 
            // sqlSelectCommand4
            // 
            this.sqlSelectCommand4.CommandText = "SELECT        retete.*, codp AS Expr1, codi AS Expr2, cantitate AS Expr3\r\nFROM   " +
    "         retete";
            this.sqlSelectCommand4.Connection = this.connection;
            // 
            // sqlInsertCommand4
            // 
            this.sqlInsertCommand4.CommandText = resources.GetString("sqlInsertCommand4.CommandText");
            this.sqlInsertCommand4.Connection = this.connection;
            this.sqlInsertCommand4.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@codp", System.Data.SqlDbType.Int, 0, "codp"),
            new System.Data.SqlClient.SqlParameter("@codi", System.Data.SqlDbType.Int, 0, "codi"),
            new System.Data.SqlClient.SqlParameter("@cantitate", System.Data.SqlDbType.VarChar, 0, "cantitate"),
            new System.Data.SqlClient.SqlParameter("@Expr1", System.Data.SqlDbType.Int, 0, "Expr1"),
            new System.Data.SqlClient.SqlParameter("@Expr2", System.Data.SqlDbType.Int, 0, "Expr2"),
            new System.Data.SqlClient.SqlParameter("@Expr3", System.Data.SqlDbType.VarChar, 0, "Expr3")});
            // 
            // sqlUpdateCommand4
            // 
            this.sqlUpdateCommand4.CommandText = resources.GetString("sqlUpdateCommand4.CommandText");
            this.sqlUpdateCommand4.Connection = this.connection;
            this.sqlUpdateCommand4.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@codp", System.Data.SqlDbType.Int, 0, "codp"),
            new System.Data.SqlClient.SqlParameter("@codi", System.Data.SqlDbType.Int, 0, "codi"),
            new System.Data.SqlClient.SqlParameter("@cantitate", System.Data.SqlDbType.VarChar, 0, "cantitate"),
            new System.Data.SqlClient.SqlParameter("@Expr1", System.Data.SqlDbType.Int, 0, "Expr1"),
            new System.Data.SqlClient.SqlParameter("@Expr2", System.Data.SqlDbType.Int, 0, "Expr2"),
            new System.Data.SqlClient.SqlParameter("@Expr3", System.Data.SqlDbType.VarChar, 0, "Expr3"),
            new System.Data.SqlClient.SqlParameter("@Original_codp", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "codp", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_codi", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "codi", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_cantitate", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "cantitate", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_cantitate", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "cantitate", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Expr1", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Expr1", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Expr2", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Expr2", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Expr3", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Expr3", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Expr3", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Expr3", System.Data.DataRowVersion.Original, null)});
            // 
            // sqlDeleteCommand4
            // 
            this.sqlDeleteCommand4.CommandText = resources.GetString("sqlDeleteCommand4.CommandText");
            this.sqlDeleteCommand4.Connection = this.connection;
            this.sqlDeleteCommand4.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@Original_codp", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "codp", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_codi", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "codi", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_cantitate", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "cantitate", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_cantitate", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "cantitate", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Expr1", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Expr1", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Expr2", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Expr2", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_Expr3", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Expr3", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_Expr3", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Expr3", System.Data.DataRowVersion.Original, null)});
            // 
            // adapterRetete
            // 
            this.adapterRetete.DeleteCommand = this.sqlDeleteCommand4;
            this.adapterRetete.InsertCommand = this.sqlInsertCommand4;
            this.adapterRetete.SelectCommand = this.sqlSelectCommand4;
            this.adapterRetete.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "retete", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("codp", "codp"),
                        new System.Data.Common.DataColumnMapping("codi", "codi"),
                        new System.Data.Common.DataColumnMapping("cantitate", "cantitate"),
                        new System.Data.Common.DataColumnMapping("Expr1", "Expr1"),
                        new System.Data.Common.DataColumnMapping("Expr2", "Expr2"),
                        new System.Data.Common.DataColumnMapping("Expr3", "Expr3")})});
            this.adapterRetete.UpdateCommand = this.sqlUpdateCommand4;
            // 
            // dataSet
            // 
            this.dataSet.DataSetName = "dataSet";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(303, 169);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Pret";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(283, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Timp de";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(277, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "preparare";
            // 
            // textPret
            // 
            this.textPret.Location = new System.Drawing.Point(333, 166);
            this.textPret.Name = "textPret";
            this.textPret.Size = new System.Drawing.Size(47, 20);
            this.textPret.TabIndex = 5;
            // 
            // textTimpPrep
            // 
            this.textTimpPrep.Location = new System.Drawing.Point(333, 139);
            this.textTimpPrep.Name = "textTimpPrep";
            this.textTimpPrep.Size = new System.Drawing.Size(47, 20);
            this.textTimpPrep.TabIndex = 6;
            // 
            // listBoxIngrediente
            // 
            this.listBoxIngrediente.FormattingEnabled = true;
            this.listBoxIngrediente.Location = new System.Drawing.Point(142, 129);
            this.listBoxIngrediente.Name = "listBoxIngrediente";
            this.listBoxIngrediente.Size = new System.Drawing.Size(129, 95);
            this.listBoxIngrediente.TabIndex = 7;
            // 
            // sqlConnection1
            // 
            this.sqlConnection1.ConnectionString = "Data Source=(localdb)\\v11.0;Initial Catalog=Retete;Integrated Security=True";
            this.sqlConnection1.FireInfoMessageEventOnUserErrors = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "CATEGORII";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(139, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "PREPARATE";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(139, 115);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Ingrediente Necesare";
            // 
            // buttAddPrep
            // 
            this.buttAddPrep.Location = new System.Drawing.Point(277, 25);
            this.buttAddPrep.Name = "buttAddPrep";
            this.buttAddPrep.Size = new System.Drawing.Size(129, 23);
            this.buttAddPrep.TabIndex = 11;
            this.buttAddPrep.Text = "Adauga preparat";
            this.buttAddPrep.UseVisualStyleBackColor = true;
            this.buttAddPrep.Click += new System.EventHandler(this.buttAddPrep_Click);
            // 
            // buttEditPrep
            // 
            this.buttEditPrep.Location = new System.Drawing.Point(277, 54);
            this.buttEditPrep.Name = "buttEditPrep";
            this.buttEditPrep.Size = new System.Drawing.Size(129, 23);
            this.buttEditPrep.TabIndex = 12;
            this.buttEditPrep.Text = "Modifica preparat";
            this.buttEditPrep.UseVisualStyleBackColor = true;
            this.buttEditPrep.Click += new System.EventHandler(this.buttEditPrep_Click);
            // 
            // buttDelPreparat
            // 
            this.buttDelPreparat.Location = new System.Drawing.Point(277, 83);
            this.buttDelPreparat.Name = "buttDelPreparat";
            this.buttDelPreparat.Size = new System.Drawing.Size(129, 23);
            this.buttDelPreparat.TabIndex = 13;
            this.buttDelPreparat.Text = "Sterge preparat";
            this.buttDelPreparat.UseVisualStyleBackColor = true;
            this.buttDelPreparat.Click += new System.EventHandler(this.buttDelPreparat_Click);
            // 
            // textBoxNumePrep
            // 
            this.textBoxNumePrep.Location = new System.Drawing.Point(332, 112);
            this.textBoxNumePrep.Name = "textBoxNumePrep";
            this.textBoxNumePrep.Size = new System.Drawing.Size(74, 20);
            this.textBoxNumePrep.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(293, 115);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Nume";
            // 
            // textBoxCodC
            // 
            this.textBoxCodC.Location = new System.Drawing.Point(332, 198);
            this.textBoxCodC.Name = "textBoxCodC";
            this.textBoxCodC.Size = new System.Drawing.Size(74, 20);
            this.textBoxCodC.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(303, 192);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(26, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Cod";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(278, 205);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(51, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "categorie";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(385, 169);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(17, 13);
            this.label12.TabIndex = 22;
            this.label12.Text = "lei";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(385, 142);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(22, 13);
            this.label13.TabIndex = 23;
            this.label13.Text = "ore";
            // 
            // listFullIngrediente
            // 
            this.listFullIngrediente.FormattingEnabled = true;
            this.listFullIngrediente.Location = new System.Drawing.Point(12, 279);
            this.listFullIngrediente.Name = "listFullIngrediente";
            this.listFullIngrediente.Size = new System.Drawing.Size(124, 186);
            this.listFullIngrediente.TabIndex = 24;
            this.listFullIngrediente.SelectedIndexChanged += new System.EventHandler(this.listFullIngrediente_SelectedIndexChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(9, 260);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(95, 13);
            this.label14.TabIndex = 25;
            this.label14.Text = "Lista ingredientelor";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(101, 255);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(35, 23);
            this.button1.TabIndex = 26;
            this.button1.Text = "load";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(142, 341);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(93, 13);
            this.label15.TabIndex = 27;
            this.label15.Text = "Unitate de masura";
            // 
            // textBoxUnitMasura
            // 
            this.textBoxUnitMasura.Location = new System.Drawing.Point(142, 357);
            this.textBoxUnitMasura.Name = "textBoxUnitMasura";
            this.textBoxUnitMasura.Size = new System.Drawing.Size(129, 20);
            this.textBoxUnitMasura.TabIndex = 28;
            // 
            // listBoxPrep2
            // 
            this.listBoxPrep2.FormattingEnabled = true;
            this.listBoxPrep2.Location = new System.Drawing.Point(280, 279);
            this.listBoxPrep2.Name = "listBoxPrep2";
            this.listBoxPrep2.Size = new System.Drawing.Size(129, 108);
            this.listBoxPrep2.TabIndex = 29;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(277, 263);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(128, 13);
            this.label16.TabIndex = 30;
            this.label16.Text = "Face parte din preparatul:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(142, 263);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(75, 13);
            this.label17.TabIndex = 31;
            this.label17.Text = "Cod ingredient";
            // 
            // textBoxCodIng
            // 
            this.textBoxCodIng.Location = new System.Drawing.Point(142, 279);
            this.textBoxCodIng.Name = "textBoxCodIng";
            this.textBoxCodIng.Size = new System.Drawing.Size(129, 20);
            this.textBoxCodIng.TabIndex = 32;
            // 
            // textBoxNumeIng
            // 
            this.textBoxNumeIng.Location = new System.Drawing.Point(142, 318);
            this.textBoxNumeIng.Name = "textBoxNumeIng";
            this.textBoxNumeIng.Size = new System.Drawing.Size(129, 20);
            this.textBoxNumeIng.TabIndex = 33;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(142, 302);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(84, 13);
            this.label18.TabIndex = 34;
            this.label18.Text = "Nume ingredient";
            // 
            // buttonAddIngredient
            // 
            this.buttonAddIngredient.Location = new System.Drawing.Point(142, 383);
            this.buttonAddIngredient.Name = "buttonAddIngredient";
            this.buttonAddIngredient.Size = new System.Drawing.Size(129, 23);
            this.buttonAddIngredient.TabIndex = 35;
            this.buttonAddIngredient.Text = "Adauga ingredient";
            this.buttonAddIngredient.UseVisualStyleBackColor = true;
            this.buttonAddIngredient.Click += new System.EventHandler(this.buttonAddIngredient_Click);
            // 
            // buttonModifIngredient
            // 
            this.buttonModifIngredient.Location = new System.Drawing.Point(142, 412);
            this.buttonModifIngredient.Name = "buttonModifIngredient";
            this.buttonModifIngredient.Size = new System.Drawing.Size(129, 23);
            this.buttonModifIngredient.TabIndex = 36;
            this.buttonModifIngredient.Text = "Modifica ingredient";
            this.buttonModifIngredient.UseVisualStyleBackColor = true;
            this.buttonModifIngredient.Click += new System.EventHandler(this.buttonModifIngredient_Click);
            // 
            // buttonDelIngredient
            // 
            this.buttonDelIngredient.Location = new System.Drawing.Point(142, 441);
            this.buttonDelIngredient.Name = "buttonDelIngredient";
            this.buttonDelIngredient.Size = new System.Drawing.Size(129, 23);
            this.buttonDelIngredient.TabIndex = 37;
            this.buttonDelIngredient.Text = "Sterge ingredient";
            this.buttonDelIngredient.UseVisualStyleBackColor = true;
            this.buttonDelIngredient.Click += new System.EventHandler(this.buttonDelIngredient_Click);
            // 
            // buttonAdaugaIngInPrep
            // 
            this.buttonAdaugaIngInPrep.Location = new System.Drawing.Point(445, 25);
            this.buttonAdaugaIngInPrep.Name = "buttonAdaugaIngInPrep";
            this.buttonAdaugaIngInPrep.Size = new System.Drawing.Size(53, 23);
            this.buttonAdaugaIngInPrep.TabIndex = 38;
            this.buttonAdaugaIngInPrep.Text = "Adauga";
            this.buttonAdaugaIngInPrep.UseVisualStyleBackColor = true;
            this.buttonAdaugaIngInPrep.Click += new System.EventHandler(this.buttonAdaugaIngInPrep_Click);
            // 
            // buttonStergeIngDinPrep
            // 
            this.buttonStergeIngDinPrep.Location = new System.Drawing.Point(445, 54);
            this.buttonStergeIngDinPrep.Name = "buttonStergeIngDinPrep";
            this.buttonStergeIngDinPrep.Size = new System.Drawing.Size(53, 23);
            this.buttonStergeIngDinPrep.TabIndex = 39;
            this.buttonStergeIngDinPrep.Text = "Sterge";
            this.buttonStergeIngDinPrep.UseVisualStyleBackColor = true;
            this.buttonStergeIngDinPrep.Click += new System.EventHandler(this.buttonStergeIngDinPrep_Click);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(442, 9);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(77, 13);
            this.label19.TabIndex = 40;
            this.label19.Text = "Modifica reteta";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(498, 30);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(202, 13);
            this.label20.TabIndex = 41;
            this.label20.Text = "ingredientul selectat in preparatul selectat";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(498, 59);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(208, 13);
            this.label21.TabIndex = 42;
            this.label21.Text = "ingredientul selectat din preparatul selectat";
            // 
            // textBoxCantitate
            // 
            this.textBoxCantitate.Location = new System.Drawing.Point(501, 83);
            this.textBoxCantitate.Name = "textBoxCantitate";
            this.textBoxCantitate.Size = new System.Drawing.Size(100, 20);
            this.textBoxCantitate.TabIndex = 43;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(442, 86);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(58, 13);
            this.label22.TabIndex = 44;
            this.label22.Text = "Cantitatea:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(757, 483);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.textBoxCantitate);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.buttonStergeIngDinPrep);
            this.Controls.Add(this.buttonAdaugaIngInPrep);
            this.Controls.Add(this.buttonDelIngredient);
            this.Controls.Add(this.buttonModifIngredient);
            this.Controls.Add(this.buttonAddIngredient);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.textBoxNumeIng);
            this.Controls.Add(this.textBoxCodIng);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.listBoxPrep2);
            this.Controls.Add(this.textBoxUnitMasura);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.listFullIngrediente);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBoxCodC);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBoxNumePrep);
            this.Controls.Add(this.buttDelPreparat);
            this.Controls.Add(this.buttEditPrep);
            this.Controls.Add(this.buttAddPrep);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.listBoxIngrediente);
            this.Controls.Add(this.textTimpPrep);
            this.Controls.Add(this.textPret);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listPreparate);
            this.Controls.Add(this.listCategorii);
            this.Name = "Form1";
            this.Text = "RETETE";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listCategorii;
        private System.Windows.Forms.ListBox listPreparate;
        private System.Data.SqlClient.SqlCommand command;
        private System.Data.SqlClient.SqlConnection connection;
        private System.Data.SqlClient.SqlCommand sqlSelectCommand1;
        private System.Data.SqlClient.SqlCommand sqlInsertCommand1;
        private System.Data.SqlClient.SqlCommand sqlUpdateCommand1;
        private System.Data.SqlClient.SqlCommand sqlDeleteCommand1;
        private System.Data.SqlClient.SqlDataAdapter adapterCategorii;
        private System.Data.SqlClient.SqlCommand sqlSelectCommand2;
        private System.Data.SqlClient.SqlCommand sqlInsertCommand2;
        private System.Data.SqlClient.SqlCommand sqlUpdateCommand2;
        private System.Data.SqlClient.SqlCommand sqlDeleteCommand2;
        private System.Data.SqlClient.SqlDataAdapter adapterIngrediente;
        private System.Data.SqlClient.SqlCommand sqlSelectCommand3;
        private System.Data.SqlClient.SqlCommand sqlInsertCommand3;
        private System.Data.SqlClient.SqlCommand sqlUpdateCommand3;
        private System.Data.SqlClient.SqlCommand sqlDeleteCommand3;
        private System.Data.SqlClient.SqlDataAdapter adapterPreparate;
        private System.Data.SqlClient.SqlCommand sqlSelectCommand4;
        private System.Data.SqlClient.SqlCommand sqlInsertCommand4;
        private System.Data.SqlClient.SqlCommand sqlUpdateCommand4;
        private System.Data.SqlClient.SqlCommand sqlDeleteCommand4;
        private System.Data.SqlClient.SqlDataAdapter adapterRetete;
        private System.Data.DataSet dataSet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textPret;
        private System.Windows.Forms.TextBox textTimpPrep;
        private System.Windows.Forms.ListBox listBoxIngrediente;
        private System.Data.SqlClient.SqlConnection sqlConnection1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttAddPrep;
        private System.Windows.Forms.Button buttEditPrep;
        private System.Windows.Forms.Button buttDelPreparat;
        private System.Windows.Forms.TextBox textBoxNumePrep;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxCodC;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ListBox listFullIngrediente;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox textBoxUnitMasura;
        private System.Windows.Forms.ListBox listBoxPrep2;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox textBoxCodIng;
        private System.Windows.Forms.TextBox textBoxNumeIng;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Button buttonAddIngredient;
        private System.Windows.Forms.Button buttonModifIngredient;
        private System.Windows.Forms.Button buttonDelIngredient;
        private System.Windows.Forms.Button buttonAdaugaIngInPrep;
        private System.Windows.Forms.Button buttonStergeIngDinPrep;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox textBoxCantitate;
        private System.Windows.Forms.Label label22;
    }
}

