using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace marketProject.Model.Interface
{
    class HelpEmail : IHelp
    {
        public void helpType()
        {
            System.Windows.Forms.MessageBox.Show(
                    "Please contact me at 'gabrielfreschi@outlook.com'",
                    "Warning");
        }
    }
}
