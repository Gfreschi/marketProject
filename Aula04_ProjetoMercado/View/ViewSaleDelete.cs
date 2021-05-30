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
    public partial class ViewSaleDelete : Form
    {
        public ViewSaleDelete()
        {
            InitializeComponent();
        }

        private void buttoncConfirm_Click(object sender, EventArgs e)
        {
            try
            {
                SaleController.remove(Convert.ToInt32(textBoxSaleCode.Text));

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
            SaleController.closeRemoval();
        }
    }
}
