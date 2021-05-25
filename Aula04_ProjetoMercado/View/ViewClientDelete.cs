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

namespace marketProject.View
{
    public partial class ViewClientDelete : Form
    {
        public ViewClientDelete()
        {
            InitializeComponent();
        }

        private void buttonConfirm_Click(object sender, EventArgs e)
        {
             try
             {
                 ClientController.delete(Convert.ToInt32(textBoxCode.Text));

             } catch (Exception error)
             {
                 System.Windows.Forms.MessageBox.Show(
                     "Data Error: " + error.Message,
                     "Error");
             }


        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            ClientController.closeDelete();
        }
    }
}
