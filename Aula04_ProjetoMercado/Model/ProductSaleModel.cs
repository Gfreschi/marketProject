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
        protected int productSaleCode;

        protected int saleCode;

        protected int productCode;

        protected int amount;

        public int ProductSaleCode { get => productSaleCode; set => productSaleCode = value; }

        public int SaleCode { get => saleCode; set => saleCode = value; }

        public int ProductCode { get => productCode; set => productCode = value; }

        public int Amount { get => amount; set => amount = value; }

        public ProductSaleModel()
        {
        }

        public static bool saveProductSale(ProductSaleModel newSale)
        {
            marketProject.Utils.DB database = new marketProject.Utils.DB();

            string query = "INSERT INTO product_sale (sale_code, product_code, amount) " +
                            "VALUES (@sale_code, @product_code, @amount);";

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

        public static bool editProductSale(ProductSaleModel updatedSale)
        {
            marketProject.Utils.DB database = new marketProject.Utils.DB();

            string query = "UPDATE product_sale SET amount=@Editamout, product_code=@Editproduct_code WHERE code=@code";

            List<MySqlParameter> content = new List<MySqlParameter>();

            content.Add(new MySqlParameter("@Editamout", MySqlDbType.String));
            content.Add(new MySqlParameter("@Editproduct_code", MySqlDbType.String));
            content.Add(new MySqlParameter("@code", MySqlDbType.String));


            content[0].Value = updatedSale.amount;
            content[1].Value = updatedSale.productCode;
            content[2].Value = updatedSale.code;

            return database.insert(query, content);
        }

        public static bool deleteProductSale(ProductSaleModel deletedSale)
        {
            marketProject.Utils.DB database = new marketProject.Utils.DB();

            string query = "DELETE FROM product_sale WHERE code=@code";

            List<MySqlParameter> content = new List<MySqlParameter>();

            content.Add(new MySqlParameter("@code", MySqlDbType.String));

            content[0].Value = deletedSale.code;

            return database.insert(query, content);
        }

        public static System.Data.DataTable searchProductSale()
        {
            marketProject.Utils.DB database = new marketProject.Utils.DB();
            string query = "SELECT * FROM product_sale;";
            return database.search(query, null);
        }

        public static System.Data.DataTable searchAll()
        {
            marketProject.Utils.DB database = new marketProject.Utils.DB();
            string query = "SELECT sale_code, product_code, amount, price_paid, client_code FROM sale, product_sale;";
            return database.search(query, null);
        }
    }
}

