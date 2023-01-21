namespace Hospital
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.таблицыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.пациентыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.доктораToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.приемыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.специальностиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.запросыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.квитанцииToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ведомостиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sqlCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlConnection1 = new System.Data.SqlClient.SqlConnection();
            this.sqlSelectCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlInsertCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlUpdateCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlDeleteCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlDataAdapter1 = new System.Data.SqlClient.SqlDataAdapter();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.таблицыToolStripMenuItem,
            this.запросыToolStripMenuItem,
            this.выходToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(358, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // таблицыToolStripMenuItem
            // 
            this.таблицыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.пациентыToolStripMenuItem,
            this.доктораToolStripMenuItem,
            this.приемыToolStripMenuItem,
            this.специальностиToolStripMenuItem});
            this.таблицыToolStripMenuItem.Name = "таблицыToolStripMenuItem";
            this.таблицыToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.таблицыToolStripMenuItem.Text = "Таблицы";
            // 
            // пациентыToolStripMenuItem
            // 
            this.пациентыToolStripMenuItem.Name = "пациентыToolStripMenuItem";
            this.пациентыToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.пациентыToolStripMenuItem.Text = "Пациенты";
            this.пациентыToolStripMenuItem.Click += new System.EventHandler(this.пациентыToolStripMenuItem_Click);
            // 
            // доктораToolStripMenuItem
            // 
            this.доктораToolStripMenuItem.Name = "доктораToolStripMenuItem";
            this.доктораToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.доктораToolStripMenuItem.Text = "Доктора";
            this.доктораToolStripMenuItem.Click += new System.EventHandler(this.доктораToolStripMenuItem_Click);
            // 
            // приемыToolStripMenuItem
            // 
            this.приемыToolStripMenuItem.Name = "приемыToolStripMenuItem";
            this.приемыToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.приемыToolStripMenuItem.Text = "Приемы";
            this.приемыToolStripMenuItem.Click += new System.EventHandler(this.приемыToolStripMenuItem_Click);
            // 
            // специальностиToolStripMenuItem
            // 
            this.специальностиToolStripMenuItem.Name = "специальностиToolStripMenuItem";
            this.специальностиToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.специальностиToolStripMenuItem.Text = "Специальности";
            this.специальностиToolStripMenuItem.Click += new System.EventHandler(this.специальностиToolStripMenuItem_Click);
            // 
            // запросыToolStripMenuItem
            // 
            this.запросыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.квитанцииToolStripMenuItem,
            this.ведомостиToolStripMenuItem});
            this.запросыToolStripMenuItem.Name = "запросыToolStripMenuItem";
            this.запросыToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.запросыToolStripMenuItem.Text = "Запросы";
            // 
            // квитанцииToolStripMenuItem
            // 
            this.квитанцииToolStripMenuItem.Name = "квитанцииToolStripMenuItem";
            this.квитанцииToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.квитанцииToolStripMenuItem.Text = "Квитанции";
            this.квитанцииToolStripMenuItem.Click += new System.EventHandler(this.квитанцииToolStripMenuItem_Click);
            // 
            // ведомостиToolStripMenuItem
            // 
            this.ведомостиToolStripMenuItem.Name = "ведомостиToolStripMenuItem";
            this.ведомостиToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ведомостиToolStripMenuItem.Text = "Ведомости";
            this.ведомостиToolStripMenuItem.Click += new System.EventHandler(this.ведомостиToolStripMenuItem_Click);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.BackColor = System.Drawing.Color.IndianRed;
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // sqlConnection1
            // 
            this.sqlConnection1.ConnectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Hospital;Integrated Security=T" +
    "rue";
            this.sqlConnection1.FireInfoMessageEventOnUserErrors = false;
            // 
            // sqlSelectCommand1
            // 
            this.sqlSelectCommand1.CommandText = "dbo.selectPatient";
            this.sqlSelectCommand1.CommandType = System.Data.CommandType.StoredProcedure;
            this.sqlSelectCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@RETURN_VALUE", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.ReturnValue, false, ((byte)(0)), ((byte)(0)), "", System.Data.DataRowVersion.Current, null)});
            // 
            // sqlInsertCommand1
            // 
            this.sqlInsertCommand1.CommandText = "dbo.insertPatient";
            this.sqlInsertCommand1.CommandType = System.Data.CommandType.StoredProcedure;
            this.sqlInsertCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@RETURN_VALUE", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.ReturnValue, false, ((byte)(0)), ((byte)(0)), "", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@fullname", System.Data.SqlDbType.VarChar, 255, "fullname"),
            new System.Data.SqlClient.SqlParameter("@birth", System.Data.SqlDbType.VarChar, 255, "birth"),
            new System.Data.SqlClient.SqlParameter("@address", System.Data.SqlDbType.VarChar, 255)});
            // 
            // sqlUpdateCommand1
            // 
            this.sqlUpdateCommand1.CommandText = "dbo.updatePatient";
            this.sqlUpdateCommand1.CommandType = System.Data.CommandType.StoredProcedure;
            this.sqlUpdateCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@RETURN_VALUE", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.ReturnValue, false, ((byte)(0)), ((byte)(0)), "", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@idPatient", System.Data.SqlDbType.Int, 4, "idPatient"),
            new System.Data.SqlClient.SqlParameter("@fullname", System.Data.SqlDbType.VarChar, 255, "fullname"),
            new System.Data.SqlClient.SqlParameter("@birth", System.Data.SqlDbType.VarChar, 255, "birth"),
            new System.Data.SqlClient.SqlParameter("@address", System.Data.SqlDbType.VarChar, 255)});
            // 
            // sqlDeleteCommand1
            // 
            this.sqlDeleteCommand1.CommandText = "dbo.deletePatient";
            this.sqlDeleteCommand1.CommandType = System.Data.CommandType.StoredProcedure;
            this.sqlDeleteCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@RETURN_VALUE", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.ReturnValue, false, ((byte)(0)), ((byte)(0)), "", System.Data.DataRowVersion.Current, null),
            new System.Data.SqlClient.SqlParameter("@idPatient", System.Data.SqlDbType.Int, 4, "idPatient")});
            // 
            // sqlDataAdapter1
            // 
            this.sqlDataAdapter1.DeleteCommand = this.sqlDeleteCommand1;
            this.sqlDataAdapter1.InsertCommand = this.sqlInsertCommand1;
            this.sqlDataAdapter1.SelectCommand = this.sqlSelectCommand1;
            this.sqlDataAdapter1.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "selectPatient", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("idPatient", "idPatient"),
                        new System.Data.Common.DataColumnMapping("fullname", "fullname"),
                        new System.Data.Common.DataColumnMapping("birth", "birth"),
                        new System.Data.Common.DataColumnMapping("addresss", "addresss")})});
            this.sqlDataAdapter1.UpdateCommand = this.sqlUpdateCommand1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Главное меню";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem таблицыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem пациентыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem доктораToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem приемыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem специальностиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem запросыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem квитанцииToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ведомостиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Data.SqlClient.SqlCommand sqlCommand1;
        private System.Data.SqlClient.SqlConnection sqlConnection1;
        private System.Data.SqlClient.SqlCommand sqlSelectCommand1;
        private System.Data.SqlClient.SqlCommand sqlInsertCommand1;
        private System.Data.SqlClient.SqlCommand sqlUpdateCommand1;
        private System.Data.SqlClient.SqlCommand sqlDeleteCommand1;
        private System.Data.SqlClient.SqlDataAdapter sqlDataAdapter1;
    }
}

