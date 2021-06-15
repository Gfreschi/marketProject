using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using marketProject.View;
using marketProject.Model.Interface;
using marketProject.Model;

namespace marketProject.Controller
{
    class HelpController
    {       
        public static void startHelp()
        {
            ViewHelpType viewHelpType = new ViewHelpType();
            viewHelpType.ShowDialog();

        }

        public static void helpEmail()
        {
            HelpModel newHelp = new HelpModel();
            newHelp.setHelp(new HelpEmail());
            newHelp.initHelp();
        }

        public static void helpManual()
        {
            HelpModel newHelp = new HelpModel();
            newHelp.setHelp(new HelpManual());
            newHelp.initHelp();
        }
    }
}
