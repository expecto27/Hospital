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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Hospital
{
    public partial class Patient : Form
    {
        public Patient()
        {
            InitializeComponent();
        }

        private void sqlDataAdapter1_RowUpdated(object sender, System.Data.SqlClient.SqlRowUpdatedEventArgs e)
        {

        }

        private void Patient_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "hospitalDataSet2.selectPatient". При необходимости она может быть перемещена или удалена.
            this.selectPatientTableAdapter.Fill(this.hospitalDataSet2.selectPatient);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            sqlConnection2.Open();
            try
            { 
                sqlInsertCommand1.Parameters["@fullname"].Value = textBox1.Text;
                sqlInsertCommand1.Parameters["@birth"].Value = textBox2.Text;
                sqlInsertCommand1.Parameters["@address"].Value = textBox3.Text;
                sqlInsertCommand1.ExecuteNonQuery();
            }

            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (FormatException)
            {
                MessageBox.Show("Данные введены некорректно", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            this.selectPatientTableAdapter.Fill(this.hospitalDataSet2.selectPatient);
            sqlConnection2.Close();

        }
        public DataRow GetCurrentRow(DataGridView dg)
        {
            CurrencyManager cm = (CurrencyManager)dg.BindingContext[dg.DataSource, dg.DataMember];
            if (cm.Count == 0) { return null; }
            DataRowView drv = (DataRowView)cm.Current;
            return drv.Row;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            DataRow row = GetCurrentRow(dataGridView1);
            int CurrentTourId = (int)row["idPatient"];
            sqlConnection2.Open();
            sqlUpdateCommand1.Parameters["@idPatient"].Value = CurrentTourId;
            sqlUpdateCommand1.Parameters["@fullname"].Value = textBox1.Text;
            sqlUpdateCommand1.Parameters["@birth"].Value = textBox2.Text;
            sqlUpdateCommand1.Parameters["@address"].Value = textBox3.Text;
            sqlUpdateCommand1.ExecuteNonQuery();
            this.selectPatientTableAdapter.Fill(this.hospitalDataSet2.selectPatient);
            sqlConnection2.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DataRow row = GetCurrentRow(dataGridView1);
            int CurrentId = (int)row["idPatient"];
            sqlConnection2.Open();
            try
            {
                sqlDeleteCommand1.Parameters["@idPatient"].Value = CurrentId;
                sqlDeleteCommand1.ExecuteNonQuery();
                sqlConnection2.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                sqlConnection2.Close();
            }
            this.selectPatientTableAdapter.Fill(this.hospitalDataSet2.selectPatient);

        }
    }
}
