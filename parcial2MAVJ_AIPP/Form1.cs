using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace parcial2MAVJ_AIPP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void formularioDeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void formularioClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.FormClosed += new FormClosedEventHandler(cerrarform);
        }

        private void cerrarform(object sender, EventArgs e)
        {
            Form1 frmpreincipal = new Form1();
            this.Hide();
            frmpreincipal.Show();
        }
    }
}
