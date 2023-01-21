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
    public partial class Speciality : Form
    {
        public Speciality()
        {
            InitializeComponent();
        }

        private void Speciality_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "hospitalDataSet1.selectSpeciality". При необходимости она может быть перемещена или удалена.
            this.selectSpecialityTableAdapter.Fill(this.hospitalDataSet1.selectSpeciality);

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
                sqlInsertCommand1.Parameters["@title"].Value = textBox1.Text;
                sqlInsertCommand1.ExecuteNonQuery();
            }

            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (FormatException)
            {
                MessageBox.Show("Данные введены некоректно", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            this.selectSpecialityTableAdapter.Fill(this.hospitalDataSet1.selectSpeciality);
            sqlConnection2.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataRow row = GetCurrentRow(dataGridView1);
            int CurrentTourId = (int)row["idSpeciality"];
            sqlConnection2.Open();
            sqlUpdateCommand1.Parameters["@id"].Value = CurrentTourId;
            sqlUpdateCommand1.Parameters["@title"].Value = textBox1.Text;
            sqlUpdateCommand1.ExecuteNonQuery();
            this.selectSpecialityTableAdapter.Fill(this.hospitalDataSet1.selectSpeciality);
            sqlConnection2.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DataRow row = GetCurrentRow(dataGridView1);
            int CurrentId = (int)row["idSpeciality"];
            sqlConnection2.Open();
            try
            {
                sqlDeleteCommand1.Parameters["@id"].Value = CurrentId;
                sqlDeleteCommand1.ExecuteNonQuery();
                sqlConnection2.Close();
                this.selectSpecialityTableAdapter.Fill(this.hospitalDataSet1.selectSpeciality);
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                sqlConnection2.Close();
            }

        }
    }
}
