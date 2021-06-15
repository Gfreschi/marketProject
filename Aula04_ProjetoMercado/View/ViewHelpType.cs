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
    public partial class ViewHelpType : Form
    {
        public ViewHelpType()
        {
            InitializeComponent();
        }

        private void SoftwareDoubt_Click(object sender, EventArgs e)
        {
            HelpController.helpManual();
        }

        private void HelpNotWorking_Click(object sender, EventArgs e)
        {
            HelpController.helpEmail();
        }
    }
}
