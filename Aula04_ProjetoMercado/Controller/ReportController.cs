using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using marketProject.View;

namespace marketProject.Controller
{
    class ReportController
    {
        private static ReportView reportview;

       public static void startReport()
        {
            reportview = new ReportView();
            reportview.ShowDialog();
        }

        public static void downloadReport()
        {
            //need implementation
        }
    }
}
