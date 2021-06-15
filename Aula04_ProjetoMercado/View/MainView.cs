using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using marketProject.Controller;

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

        private void registerToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            SupplierController.startRegister();
        }

        private void registerToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ProductController.startRegister();
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClientController.startUpdate();
        }

        private void removeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClientController.startDelete();
        }

        private void registerToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            SaleController.startRegister();
        }

        private void updateToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ProductController.startUpdate();
        }

        private void removeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ProductController.startRemoval();
        }

        private void updateToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            SupplierController.startUpdate();
        }

        private void removeToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            SupplierController.startRemoval();
        }

        private void buttonListProducts_Click(object sender, EventArgs e)
        {
            ProductController.list(dataGridView1);
        }

        private void buttonListSuppliers_Click(object sender, EventArgs e)
        {
            SupplierController.list(dataGridView1);
        }

        private void buttonListSales_Click(object sender, EventArgs e)
        {
            SaleController.list(dataGridView1);
        }

        private void updateToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            SaleController.startUpdate();
        }

        private void removeToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            SaleController.startRemoval();
        }

        private void transactionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReportController.startReport();
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HelpController.startHelp();
        }
    }
}
