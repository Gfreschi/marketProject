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
    public partial class ViewProductRegister : Form
    {
        public ViewProductRegister()
        {
            InitializeComponent();
        }

        private void buttonConfirm_Click(object sender, EventArgs e)
        {
            try
            {
                ProductController.register
                    (
                    System.Convert.ToInt32(textBoxCode.Text),
                    textBoxName.Text,
                    System.Convert.ToDouble(textBoxPrice.Text),
                    System.Convert.ToInt32(textBoxStorage.Text),
                    System.Convert.ToInt32(textBoxSupplierCode.Text)
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
            ProductController.closeRegister();
        }
    }
}
