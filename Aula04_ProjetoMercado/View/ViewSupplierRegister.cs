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
    public partial class ViewSupplierRegister : Form
    {
        public ViewSupplierRegister()
        {
            InitializeComponent();
        }

        private void buttonConfirm_Click(object sender, EventArgs e)
        {
            SupplierController.register
                (
                textBoxName.Text,
                textBoxAddress.Text,
                textBoxDistrict.Text,
                textBoxCity.Text,
                textBoxState.Text,
                maskedTextBoxZIPCode.Text,
                maskedTextBoxPhone.Text
                );

        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            SupplierController.closeRegister();
        }
    }
}
