using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace marketProject.Model
{
    class SalesModel
    {
        private int code;

        private int clientCode;

        private DateTime date;

        public int Code { get => code; set => code = value; }

        public int ClientCode { get => clientCode; set => clientCode = value; }

        public DateTime Date { get => date; set => date = value; }


    }
}
