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

            //Unit Test
            /*try
            {
                ClientController.register("Gabriel", "Rua 7", "Santana", "RC", "SP", "13504000", "19999999", "1", "123456789");
                ClientController.register("Gabriel", "Rua 7", "Santana", "RC", "SP", "13504000", "19999999", "2", "123456789");
                ClientController.register("Gabriel", "Rua 7", "Santana", "RC", "SP", "13504000", "19999999", "3", "123456789");
                ClientController.register("Gabriel", "Rua 7", "Santana", "RC", "SP", "13504000", "19999999", "4", "123456789");
                ClientController.register("Gabriel", "Rua 7", "Santana", "RC", "SP", "13504000", "19999999", "5", "123456789");
                ClientController.register("Gabriel", "Rua 7", "Santana", "RC", "SP", "13504000", "19999999", "6", "123456789");
                ClientController.register("Gabriel", "Rua 7", "Santana", "RC", "SP", "13504000", "19999999", "7", "123456789");
                ClientController.register("Gabriel", "Rua 7", "Santana", "RC", "SP", "13504000", "19999999", "8", "123456789");

            } catch (Exception error)
            {
                System.Windows.Forms.MessageBox.Show(
                    "Data Error: " + error.Message,
                    "Error");
            }
            */
            
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            ClientController.closeRegister();

        }
    }
}
