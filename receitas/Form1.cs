using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace receitas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

                }

        private void receitasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cadastro cad = new cadastro();
            cad.ShowDialog();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
