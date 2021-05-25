using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MySql.Data.MySqlClient;

namespace marketProject.Model
{
    class SalesModel
    {
        private int code;

        protected int clientCode;

        protected double pricePaid;

        protected DateTime date = DateTime.Now;

        public int Code { get => code; set => code = value; }

        public int ClientCode { get => clientCode; set => clientCode = value; }

        public double PricePaid { get => pricePaid; set => pricePaid = value; }

        //Fazer construtor...
        //Chamar save do sales model no controller, assim como o product sales model.
    }
}
