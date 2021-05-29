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
        private static ViewProductUpdate windowUpdateProduct;
        private static ViewProductDelete windowDeleteProduct;

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
        public static void startUpdate()
        {
            windowUpdateProduct = new ViewProductUpdate();
            windowUpdateProduct.ShowDialog();
        }
        public static void closeUpdate()
        {
            windowUpdateProduct.Close();
        }
        public static void update(int code, string name, double price, int storage, int supplierCode)
        {
            ProductModel updatedProduct = new ProductModel();

            updatedProduct.Code = code;
            updatedProduct.Name = name;
            updatedProduct.Price = price;
            updatedProduct.Storage = storage;
            updatedProduct.SupplierCode = supplierCode;

            //Save the informations
            bool sucess = ProductModel.edit(updatedProduct);

            if (sucess)
            {
                closeRegister();
                System.Windows.Forms.MessageBox.Show(
                    "Product Successfully Updated",
                    "Success");
            }
            else
            {
                System.Windows.Forms.MessageBox.Show(
                    "Error updating product",
                    "Error");

            }
        }

        //Removal
        public static void startRemoval()
        {
            windowDeleteProduct = new ViewProductDelete();
            windowDeleteProduct.ShowDialog();
        }
        public static void closeRemoval()
        {
            windowDeleteProduct.Close();
        }
        public static void remove(int code)
        {
            ProductModel deletedProduct = new ProductModel();

            deletedProduct.Code = code;

            bool success = ProductModel.delete(deletedProduct);

            if (success)
            {
                closeRegister();
                System.Windows.Forms.MessageBox.Show(
                    "Product Successfully Deleted",
                    "Success");
            }
            else
            {
                System.Windows.Forms.MessageBox.Show(
                    "Error deleting product",
                    "Error");

            }
        }

        public static void list(System.Windows.Forms.DataGridView visualElement)
        {
            visualElement.DataSource = ProductModel.search();
        }

    }
}
