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

namespace Hospital
{
    public partial class doctorHasPatient : Form
    {
        public doctorHasPatient()
        {
            InitializeComponent();
        }

        private void doctorHasPatient_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "hospitalDataSet3.selectDoctor_has_Patient". При необходимости она может быть перемещена или удалена.
            this.selectDoctor_has_PatientTableAdapter.Fill(this.hospitalDataSet3.selectDoctor_has_Patient);

        }
        public DataRow GetCurrentRow(DataGridView dg)
        {
            CurrencyManager cm = (CurrencyManager)dg.BindingContext[dg.DataSource, dg.DataMember];
            if (cm.Count == 0) { return null; }
            DataRowView drv = (DataRowView)cm.Current;
            return drv.Row;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sqlConnection1.Open();
            try
            {
                sqlInsertCommand1.Parameters["@idD"].Value = Convert.ToInt32(textBox1.Text);
                sqlInsertCommand1.Parameters["@idP"].Value = Convert.ToInt32(textBox2.Text);
                sqlInsertCommand1.Parameters["@date"].Value = textBox3.Text;
                sqlInsertCommand1.Parameters["@price"].Value = Convert.ToInt32(textBox4.Text);
                sqlInsertCommand1.ExecuteNonQuery();
            }

            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (FormatException)
            {
                MessageBox.Show("ID должен быть целым числом", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            this.selectDoctor_has_PatientTableAdapter.Fill(this.hospitalDataSet3.selectDoctor_has_Patient);
            sqlConnection1.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataRow row = GetCurrentRow(dataGridView1);
            int CurrentTourId = (int)row["Patient_idPatient"];
            sqlConnection1.Open();
            sqlUpdateCommand1.Parameters["@idD"].Value = Convert.ToInt32(textBox1.Text);
            sqlUpdateCommand1.Parameters["@idP"].Value = Convert.ToInt32(textBox2.Text);
            sqlUpdateCommand1.Parameters["@date"].Value = textBox3.Text;
            sqlUpdateCommand1.Parameters["@price"].Value = Convert.ToInt32(textBox4.Text);
            sqlUpdateCommand1.ExecuteNonQuery();
            this.selectDoctor_has_PatientTableAdapter.Fill(this.hospitalDataSet3.selectDoctor_has_Patient);
            sqlConnection1.Close();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            DataRow row = GetCurrentRow(dataGridView1);
            int CurrentId = (int)row["Patient_idPatient"];
            sqlConnection1.Open();
            try
            {
                sqlDeleteCommand1.Parameters["@idP"].Value = CurrentId;
                sqlDeleteCommand1.ExecuteNonQuery();
                sqlConnection1.Close();
                
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                sqlConnection1.Close();
            }
            this.selectDoctor_has_PatientTableAdapter.Fill(this.hospitalDataSet3.selectDoctor_has_Patient);
        }
    }
}
