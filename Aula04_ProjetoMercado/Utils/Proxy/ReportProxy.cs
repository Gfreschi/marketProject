using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using marketProject.Model;

namespace marketProject.Utils.Proxy
{
    class ReportProxy : ReportObject
    {
        ReportModel obj;

        //Build the class
        public ReportProxy()
        {
            //Finding the intermediate object
            if (obj == null)
                obj = new ReportObject();
        }
        public override void report()
        {
            //Calling the ReportObject method
            obj.report();
        }
    }
}
