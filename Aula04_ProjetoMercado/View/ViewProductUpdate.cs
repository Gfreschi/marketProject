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
    public partial class ViewProductUpdate : Form
    {
        public ViewProductUpdate()
        {
            InitializeComponent();
        }

        private void buttonConfirm_Click(object sender, EventArgs e)
        {
            try
            {
                ProductController.update(
                Convert.ToInt32(textBoxCode.Text),
                textBoxName.Text,
                Convert.ToDouble(textBoxPrice.Text),
                Convert.ToInt32(textBoxStorage.Text),
                Convert.ToInt32(textBoxSupplierCode.Text)
                );
            }catch (Exception error)
            {
                System.Windows.Forms.MessageBox.Show(
                    "Data Error: " + error.Message,
                    "Error");
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            ProductController.closeUpdate();
        }
    }
}
