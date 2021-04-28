using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MySql.Data.MySqlClient;

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
           

            marketProject.Utils.DB database = new marketProject.Utils.DB();

            string query = "INSERT INTO client (name, address, district, city, state, zip, " +
                            "phone, cpf, rg) VALUES (@name, @address, @district, @city, " +
                            "@state, @zip, @phone, @cpf, @rg);";

            //Building Query preventing SQL Injection
            List<MySqlParameter> content = new List<MySqlParameter>();

            content.Add(new MySqlParameter("@name", MySqlDbType.String));
            content.Add(new MySqlParameter("@address", MySqlDbType.String));
            content.Add(new MySqlParameter("@district", MySqlDbType.String));
            content.Add(new MySqlParameter("@city", MySqlDbType.String));
            content.Add(new MySqlParameter("@state", MySqlDbType.String));
            content.Add(new MySqlParameter("@zip", MySqlDbType.String));
            content.Add(new MySqlParameter("@phone", MySqlDbType.String));
            content.Add(new MySqlParameter("@cpf", MySqlDbType.String));
            content.Add(new MySqlParameter("@rg", MySqlDbType.String));

            content[0].Value = newClient.name;
            content[1].Value = newClient.address;
            content[2].Value = newClient.district;
            content[3].Value = newClient.city;
            content[4].Value = newClient.state;
            content[5].Value = newClient.zip;
            content[6].Value = newClient.phone;
            content[7].Value = newClient.cpf;
            content[8].Value = newClient.rg;

            return database.insert(query, content);
        }

        public static bool edit(ClientModel whichClient)
        {


            return false;
        }

        public static bool remove(ClientModel whichClient)
        {


            return false;
        }

        public static System.Data.DataTable search()
        {
            marketProject.Utils.DB database = new marketProject.Utils.DB();
            string query = "SELECT * FROM client;";
            return database.search(query, null);
        }
    }
}
