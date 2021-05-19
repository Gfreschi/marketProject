using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using marketProject.View;
using marketProject.Model;

namespace marketProject.Controller
{
    class ProductController
    {
        private static ViewProductRegister windowRegisterProduct;

        //Register
        public static void startRegister()
        {
            windowRegisterProduct = new ViewProductRegister();
            windowRegisterProduct.ShowDialog();
        }

        public static void closeRegister()
        {
            windowRegisterProduct.Close();
        }

        public static void register(int code, string name, double price,
                                    int storage, int supplierCode)
        {
            //Struct the informations recived from the Model

            ProductModel newProduct = new ProductModel();

            newProduct.Code = code;
            newProduct.Name = name;
            newProduct.Price = price;
            newProduct.Storage = storage;
            newProduct.SupplierCode = supplierCode;

            //Save the informations
            bool sucess = ProductModel.save(newProduct);

            if (sucess)
            {
                closeRegister();
                System.Windows.Forms.MessageBox.Show(
                    "Product Successfully Registered",
                    "Success");
            }
            else
            {
                System.Windows.Forms.MessageBox.Show(
                    "Error registering product",
                    "Error");

            }

        }

        //Update
        public static void startUpdate() { }
        public static void closeUpdate() { }
        public static void update() { }

        //Removal
        public static void startRemoval() { }
        public static void closeRemoval() { }
        public static void remove() { }

        public static void list(System.Windows.Forms.DataGridView visualElement)
        {
            visualElement.DataSource = ProductModel.search();
        }
    }
}
