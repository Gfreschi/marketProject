using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using marketProject.Model;

namespace marketProject.Utils.Proxy
{
    class ReportObject : ReportModel
    {
        //Real class that is called by the proxy
        public override void report()
        {
            Console.WriteLine("Downloading a report...");

            System.Windows.Forms.MessageBox.Show(
                    "Download Started - Please Wait until finished",
                    "Success");

        }
        //Missing to implement all part of reports
    }
}
