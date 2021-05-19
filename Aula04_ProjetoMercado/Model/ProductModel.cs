using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MySql.Data.MySqlClient;


namespace marketProject.Model
{
    class ProductModel
    {
        private int code;

        //Reference of Supplier Code
        private int supplierCode;

        private double price;

        private string name;

        private int storage;

        public int Code { get => code; set => code = value; }

        public int SupplierCode { get => supplierCode; set => supplierCode = value; }

        public double Price { get => price; set => price = value; }

        public string Name { get => name; set => name = value; }

        public int Storage { get => storage; set => storage = value; }


        public static bool save(ProductModel newProduct)
        {
            //inserting to Db
            marketProject.Utils.DB database = new marketProject.Utils.DB();

            string query = "INSERT INTO product (code, name, price, storage, " +
                            "provider) VALUES (@code, @name, @price, @storage, " +
                            "@provider);";

            //Building Query preventing SQL Injection
            List<MySqlParameter> content = new List<MySqlParameter>();

            content.Add(new MySqlParameter("@code", MySqlDbType.String));
            content.Add(new MySqlParameter("@name", MySqlDbType.String));
            content.Add(new MySqlParameter("@price", MySqlDbType.String));
            content.Add(new MySqlParameter("@storage", MySqlDbType.String));
            content.Add(new MySqlParameter("@provider", MySqlDbType.String));

            content[0].Value = newProduct.code;
            content[1].Value = newProduct.name;
            content[2].Value = newProduct.price;
            content[3].Value = newProduct.storage;
            content[4].Value = newProduct.supplierCode;

            return database.insert(query, content);
        }

        public static bool edit(ProductModel whichProduct)
        {
            return true;

        }

        public static bool remove(ProductModel whichProduct)
        {
            return true;
        }

        public static System.Data.DataTable search()
        {
            marketProject.Utils.DB database = new marketProject.Utils.DB();
            string query = "SELECT * FROM product;";
            return database.search(query, null);
        }

    }
}
