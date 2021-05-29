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

namespace marketProject.View
{
    public partial class ViewSupplierUpdate : Form
    {
        public ViewSupplierUpdate()
        {
            InitializeComponent();
        }

        private void buttonConfirm_Click(object sender, EventArgs e)
        {
            try
            {
                SupplierController.update
                 (
                 Convert.ToInt32(textBoxCode.Text),
                 textBoxName.Text,
                 textBoxAddress.Text,
                 textBoxDistrict.Text,
                 textBoxCity.Text,
                 textBoxState.Text,
                 maskedTextBoxZIPCode.Text,
                 maskedTextBoxPhone.Text
                 );
            }
            catch (Exception error)
            {
                System.Windows.Forms.MessageBox.Show(
                    "Data Error: " + error.Message,
                    "Error");
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            SupplierController.closeUpdate();
        }
    }
}
