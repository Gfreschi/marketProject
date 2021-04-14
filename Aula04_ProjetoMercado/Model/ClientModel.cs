using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula04_ProjetoMercado.Model
{
    class ClientModel
    {
        private int code;    

        private string name;

        private string address;

        private string district;

        private string city;

        private string state;

        private string zip;

        private string phone;

        private string cpf;

        private string rg;

        public int Code { get => code; set => code = value; }
        public string Name { get => name; set => name = value; }
        public string Address { get => address; set => address = value; }
        public string District { get => district; set => district = value; }
        public string City { get => city; set => city = value; }
        public string State { get => state; set => state = value; }
        public string Zip { get => zip; set => zip = value; }
        public string Phone { get => phone; set => phone = value; }
        public string Cpf { get => cpf; set => cpf = value; }
        public string Rg { get => rg; set => rg = value; }

        public static bool save(ClientModel newClient)
        {



            return false;
        }

        public static bool edit(ClientModel whichClient)
        {


            return false;
        }

        public static bool remove(ClientModel whichClient)
        {


            return false;
        }
    }
}
