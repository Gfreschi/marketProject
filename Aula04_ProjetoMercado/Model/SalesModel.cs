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
        protected int code;

        protected int clientCode;

        protected double pricePaid;

        protected DateTime date;

        public int Code { get => code; set => code = value; }

        public int ClientCode { get => clientCode; set => clientCode = value; }

        public double PricePaid { get => pricePaid; set => pricePaid = value; }

        public SalesModel()
        {
            date = DateTime.Now;
            code++;
        }
        public static bool save(SalesModel newSale)
        {
            marketProject.Utils.DB database = new marketProject.Utils.DB();

            string query = "INSERT INTO sale (code, date, client_code, price_paid) " +
                            "VALUES (@code, @date, @client_code, @price_paid)";

            //Formating DateTime for Mysql format
            string formatForMySql = newSale.date.ToString("yyyy-MM-dd HH:mm:ss");

            //Building Query preventing SQL Injection
            List<MySqlParameter> content = new List<MySqlParameter>();

            content.Add(new MySqlParameter("@code", MySqlDbType.String));
            content.Add(new MySqlParameter("@date", MySqlDbType.String));
            content.Add(new MySqlParameter("@client_code", MySqlDbType.String));
            content.Add(new MySqlParameter("@price_paid", MySqlDbType.String));

            content[0].Value = newSale.code;
            content[1].Value = newSale.date;
            content[2].Value = newSale.clientCode;
            content[3].Value = newSale.pricePaid;

            return database.insert(query, content);

        }

        public static bool edit(SalesModel updatedSale)
        {
            marketProject.Utils.DB database = new marketProject.Utils.DB();

            string query = "UPDATE sale SET client_code=@Editclient_code, price_paid=@Editprice_paid WHERE code=@code";

            List<MySqlParameter> content = new List<MySqlParameter>();

            content.Add(new MySqlParameter("@Editclient_code", MySqlDbType.String));
            content.Add(new MySqlParameter("@Editprice_paid", MySqlDbType.String));
            content.Add(new MySqlParameter("@code", MySqlDbType.String));


            content[0].Value = updatedSale.clientCode;
            content[1].Value = updatedSale.pricePaid;
            content[3].Value = updatedSale.code;

            return database.insert(query, content);
        }

        public static bool delete(SalesModel deletedSale)
        {
            marketProject.Utils.DB database = new marketProject.Utils.DB();

            string query = "DELETE FROM sale WHERE code=@code";

            List<MySqlParameter> content = new List<MySqlParameter>();

            content.Add(new MySqlParameter("@code", MySqlDbType.String));

            content[0].Value = deletedSale.code;

            return database.insert(query, content);
        }

        public static System.Data.DataTable search()
        {
            marketProject.Utils.DB database = new marketProject.Utils.DB();
            string query = "SELECT * FROM sales;";
            return database.search(query, null);
        }
    }
}
