﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace Hospital
{
    public partial class ved : Form
    {
        private Excel.Application excelapp;
        private Excel.Workbooks excelappworkbooks;
        private Excel.Workbook excelappworkbook;
        private Excel.Sheets excelsheets;
        private Excel.Worksheet excelworksheet;
        private Excel.Range excelcells;
        public ved()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Excel.Application excelapp = new Excel.Application();
            excelapp.Visible = true;
            excelapp.SheetsInNewWorkbook = 1;
            excelapp.Workbooks.Add(Type.Missing);
            excelapp.DisplayAlerts = true;

            sqlConnection1.Open();
            excelcells = excelapp.get_Range("A1", Type.Missing);
            excelcells.set_Value(Type.Missing, "ID Доктора");
            excelcells = excelapp.get_Range("B1", Type.Missing);
            excelcells.set_Value(Type.Missing, "ИМЯ");
            excelcells = excelapp.get_Range("C1", Type.Missing);
            excelcells.set_Value(Type.Missing, "ЗАРПЛАТА");
            excelcells = excelapp.get_Range("D1", Type.Missing);
            excelcells.set_Value(Type.Missing, "НАЛОГ");

            sqlSelectCommand1.Parameters["@firsDate"].Value = textBox1.Text;
            sqlSelectCommand1.Parameters["@lastDate"].Value = textBox2.Text;
            SqlDataReader reader = sqlSelectCommand1.ExecuteReader();

            int i = 2;

            while (reader.Read())
            {
                excelcells = excelapp.get_Range("A" + Convert.ToString(i), Type.Missing);
                excelcells.set_Value(Type.Missing, String.Format("{0}", reader[0]));
                excelcells = excelapp.get_Range("B" + Convert.ToString(i), Type.Missing);
                excelcells.set_Value(Type.Missing, String.Format("{0}", reader[1]));
                excelcells = excelapp.get_Range("C" + Convert.ToString(i), Type.Missing);
                excelcells.set_Value(Type.Missing, String.Format("{0}", reader[2]));
                excelcells = excelapp.get_Range("D" + Convert.ToString(i), Type.Missing);
                excelcells.set_Value(Type.Missing, String.Format("{0}", reader[3]));
                i++;
            }
            sqlConnection1.Close();

        }
    }
}
