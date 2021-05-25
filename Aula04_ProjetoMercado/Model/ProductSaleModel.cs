using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MySql.Data.MySqlClient;

namespace marketProject.Model
{
    class ProductSaleModel : SalesModel
    {
        protected int saleCode;

        protected int productCode;

        protected int amount;

        public int SaleCode { get => saleCode; set => saleCode = value; }

        public int ProductCode { get => productCode; set => productCode = value; }

        public int Amount { get => amount; set => amount = value; }


        public static bool save(ProductSaleModel newSale)
        {
            marketProject.Utils.DB database = new marketProject.Utils.DB();

            string query = "INSERT INTO product_sale (sale_code, product_code, amount) " +
                            "VALUES (@sale_code, @product_code, @amount";

            //Building Query preventing SQL Injection
            List<MySqlParameter> content = new List<MySqlParameter>();

            content.Add(new MySqlParameter("@sale_code", MySqlDbType.String));
            content.Add(new MySqlParameter("@product_code", MySqlDbType.String));
            content.Add(new MySqlParameter("@amount", MySqlDbType.String));

            content[0].Value = newSale.SaleCode;
            content[1].Value = newSale.ProductCode;
            content[2].Value = newSale.Amount;


            return database.insert(query, content);
        }

    }
}
