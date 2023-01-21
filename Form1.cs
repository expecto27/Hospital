using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospital
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void пациентыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Patient Pat = new Patient();
            Pat.ShowDialog();
        }

        private void доктораToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Doctor Doc = new Doctor();
            Doc.ShowDialog();
        }

        private void приемыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            doctorHasPatient dhp = new doctorHasPatient();
            dhp.ShowDialog();
        }

        private void специальностиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Speciality Spec = new Speciality();
            Spec.ShowDialog();
        }

        private void квитанцииToolStripMenuItem_Click(object sender, EventArgs e)
        {
            kvit K = new kvit();
            K.ShowDialog();
        }

        private void ведомостиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ved V = new ved();
            V.ShowDialog();
        }
    }
}
