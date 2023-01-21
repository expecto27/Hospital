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
    public partial class Doctor : Form
    {
        public Doctor()
        {
            InitializeComponent();
        }

        private void Doctor_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "hospitalDataSet.selectDoctor". При необходимости она может быть перемещена или удалена.
            this.selectDoctorTableAdapter.Fill(this.hospitalDataSet.selectDoctor);

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

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
            sqlConnection2.Open();
            try 
            {
                sqlInsertCommand1.Parameters["@idS"].Value = Convert.ToInt32(textBox1.Text);
                sqlInsertCommand1.Parameters["@fullname"].Value = textBox2.Text;
                sqlInsertCommand1.Parameters["@total"].Value = textBox3.Text;
                sqlInsertCommand1.Parameters["@p"].Value = Convert.ToInt32(textBox4.Text);
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
            this.selectDoctorTableAdapter.Fill(this.hospitalDataSet.selectDoctor);
            sqlConnection2.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataRow row = GetCurrentRow(dataGridView1);
            int CurrentTourId = (int)row["idDoctor"];
            sqlConnection2.Open();
            sqlUpdateCommand1.Parameters["@idDoctor"].Value = CurrentTourId;
            sqlUpdateCommand1.Parameters["@idS"].Value = Convert.ToInt32(textBox1.Text);
            sqlUpdateCommand1.Parameters["@fullname"].Value = textBox2.Text;
            sqlUpdateCommand1.Parameters["@total"].Value = textBox3.Text;
            sqlUpdateCommand1.Parameters["@p"].Value = Convert.ToInt32(textBox4.Text);
            sqlUpdateCommand1.ExecuteNonQuery();
            this.selectDoctorTableAdapter.Fill(this.hospitalDataSet.selectDoctor);
            sqlConnection2.Close();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            DataRow row = GetCurrentRow(dataGridView1);
            int CurrentId = (int)row["idDoctor"];
            sqlConnection2.Open();
            try
            {
                sqlDeleteCommand1.Parameters["@idDoctor"].Value = CurrentId;
                sqlDeleteCommand1.ExecuteNonQuery();
                sqlConnection2.Close();
                this.selectDoctorTableAdapter.Fill(this.hospitalDataSet.selectDoctor);
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                sqlConnection2.Close();
            }

        }
    }
}
