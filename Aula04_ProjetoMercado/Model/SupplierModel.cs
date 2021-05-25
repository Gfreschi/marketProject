using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MySql.Data.MySqlClient;

namespace marketProject.Model
{
    class SupplierModel
    {
        private int code;

        private string name;

        private string address;

        private string district;

        private string city;

        private string state;

        private string zip;

        private string phone;

        public int Code { get => code; set => code = value; }
        public string Name { get => name; set => name = value; }
        public string Address { get => address; set => address = value; }
        public string District { get => district; set => district = value; }
        public string City { get => city; set => city = value; }
        public string State { get => state; set => state = value; }
        public string Zip { get => zip; set => zip = value; }
        public string Phone { get => phone; set => phone = value; }


        public static bool save(SupplierModel newSupplier)
        {
            marketProject.Utils.DB database = new marketProject.Utils.DB();

            string query = "INSERT INTO provider (name, address, district, city, state, zip, " +
                            "phone) VALUES (@name, @address, @district, @city, " +
                            "@state, @zip, @phone);";

            //Building Query preventing SQL Injection
            List<MySqlParameter> content = new List<MySqlParameter>();

            content.Add(new MySqlParameter("@name", MySqlDbType.String));
            content.Add(new MySqlParameter("@address", MySqlDbType.String));
            content.Add(new MySqlParameter("@district", MySqlDbType.String));
            content.Add(new MySqlParameter("@city", MySqlDbType.String));
            content.Add(new MySqlParameter("@state", MySqlDbType.String));
            content.Add(new MySqlParameter("@zip", MySqlDbType.String));
            content.Add(new MySqlParameter("@phone", MySqlDbType.String));

            content[0].Value = newSupplier.name;
            content[1].Value = newSupplier.address;
            content[2].Value = newSupplier.district;
            content[3].Value = newSupplier.city;
            content[4].Value = newSupplier.state;
            content[5].Value = newSupplier.zip;
            content[6].Value = newSupplier.phone;

            return database.insert(query, content);
        }

        public static bool edit(SupplierModel whichSupplier)
        {
            return true;
        }

        public static bool remove(SupplierModel whichSupplier)
        {
            return true;
        }

        public static System.Data.DataTable search()
        {
            //In database I am using diferent name for supplier, (provider).
            marketProject.Utils.DB database = new marketProject.Utils.DB();
            string query = "SELECT * FROM provider;";
            return database.search(query, null);
        }
    }
}
