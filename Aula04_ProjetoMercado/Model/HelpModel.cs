using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using marketProject.Model.Interface;
namespace marketProject.Model
{
    class HelpModel
    {
        IHelp Help;

        public void setHelp(IHelp newHelp)
        {
            Help = newHelp;
        }

        public void initHelp()
        {
            Help.helpType();
        }

    }
}
