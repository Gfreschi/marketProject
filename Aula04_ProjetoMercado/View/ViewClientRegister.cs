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


namespace Aula04_ProjetoMercado.View
{
    public partial class ViewClientRegister : Form
    {
        public ViewClientRegister()
        {
            InitializeComponent();
        }

        
        private void buttonConfirm_Click(object sender, EventArgs e)
        {
            ClientController.register
                (
                textBoxName.Text,
                textBoxAddress.Text,
                textBoxDistrict.Text,
                textBoxCity.Text,
                textBoxState.Text,
                maskedTextBoxZipCode.Text,
                maskedTextBoxPhone.Text,
                maskedTextBoxCPF.Text,
                textBoxRG.Text
                );
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            ClientController.closeRegister();

        }
    }
}
