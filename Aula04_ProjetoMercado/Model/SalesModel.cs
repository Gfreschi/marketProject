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

        protected DateTime date = DateTime.Now;

        public int Code { get => code; set => code = value; }

        public int ClientCode { get => clientCode; set => clientCode = value; }

        public double PricePaid { get => pricePaid; set => pricePaid = value; }

        //Fazer construtor...
        //Chamar save do sales model no controller, assim como o product sales model.
        public static bool save(ProductSaleModel newSale)
        {
            marketProject.Utils.DB database = new marketProject.Utils.DB();

            //Formating DateTime for Mysql format
            string formatForMySql = newSale.date.ToString("yyyy-MM-dd HH:mm:ss");

            string query = "INSERT INTO sale (date, client_code, price_paid) " +
                            "VALUES (@date, @client_code, @price_paid)";

            //Building Query preventing SQL Injection
            List<MySqlParameter> content = new List<MySqlParameter>();

            content.Add(new MySqlParameter("@date", MySqlDbType.String));
            content.Add(new MySqlParameter("@client_code", MySqlDbType.String));
            content.Add(new MySqlParameter("@price_paid", MySqlDbType.String));

            content[0].Value = newSale.SaleCode;
            content[1].Value = newSale.ProductCode;
            content[2].Value = newSale.Amount;

            return database.insert(query, content);
        }
    }
}
