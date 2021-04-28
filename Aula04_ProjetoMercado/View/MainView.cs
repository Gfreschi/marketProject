using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Aula04_ProjetoMercado.Controller;

namespace Aula04_ProjetoMercado
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void registerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClientController.startRegister();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ClientController.list(dataGridView1);
        }
    }
}
