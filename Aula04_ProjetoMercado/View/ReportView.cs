using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using marketProject.Utils.Proxy;

namespace marketProject.View
{
    public partial class ReportView : Form
    {
        public ReportView()
        {
            InitializeComponent();
        }

        private void Download_Click(object sender, EventArgs e)
        {
            //Using proxy for further implementation
            ReportProxy proxy = new ReportProxy();
            proxy.report();
        }
    }
}
