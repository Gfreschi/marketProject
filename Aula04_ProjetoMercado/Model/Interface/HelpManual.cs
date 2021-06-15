using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace marketProject.Model.Interface
{
    class HelpManual :IHelp
    {
        public void helpType()
        {
            System.Windows.Forms.MessageBox.Show(
                    "Please check software Manual at github.com/Gfreschi",
                    "Attention");
        }
    }
}
