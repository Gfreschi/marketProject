using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using marketProject.View;
using marketProject.Model;

namespace marketProject.Controller
{
    class SaleController
    {
        public static ViewSaleRegister windowRegisterSale;
        public static ViewSaleUpdate windowUpdateSale;
        public static ViewSaleDelete windowDeleteSale;

        //Register
        public static void startRegister()
        {
            windowRegisterSale = new ViewSaleRegister();
            windowRegisterSale.ShowDialog();
        }

        public static void closeRegister()
        {
            windowRegisterSale.Close();
        }

        public static void register(int productCode, int clientCode, int amount, double pricePaid)
        {
            SalesModel newSale = new SalesModel();
            newSale.ClientCode = clientCode;
            newSale.PricePaid = pricePaid;
            int success_insert_id = SalesModel.save(newSale); // return the id of the last saved sale

            ProductSaleModel newProductSale = new ProductSaleModel();
            // Antes de atribuir, verificar se não é -1
            newProductSale.SaleCode = success_insert_id;

            newProductSale.ProductCode = productCode;
            newProductSale.Amount = amount;

            bool success = ProductSaleModel.saveProductSale(newProductSale);

            if (success)
            {
                closeRegister();
                System.Windows.Forms.MessageBox.Show(
                    "Sale Successfully Registered",
                    "Success");
            }
            else
            {
                System.Windows.Forms.MessageBox.Show(
                    "Error registering sale",
                    "Error");

            }
        }

        //Update
        public static void startUpdate()
        {
            windowUpdateSale = new ViewSaleUpdate();
            windowUpdateSale.ShowDialog();
        }

        public static void closeUpdate()
        {
            windowUpdateSale.Close();
        }

        public static void update(int saleCode, int productCode, int clientCode, int amount, double pricePaid)
        {
            SalesModel updatedSale = new SalesModel();
            updatedSale.Code = saleCode;
            updatedSale.PricePaid = pricePaid;
            updatedSale.ClientCode = clientCode;

            bool success = SalesModel.edit(updatedSale);


            /*ProductSaleModel updatedSale = new ProductSaleModel();

            updatedSale.SaleCode = saleCode;
            updatedSale.ProductSaleCode = saleCode;
            updatedSale.ProductCode = productCode;
            updatedSale.ClientCode = clientCode;
            updatedSale.Amount = amount;
            updatedSale.PricePaid = pricePaid;

            bool success = SalesModel.edit(updatedSale);
            bool success1 = ProductSaleModel.editProductSale(updatedSale);*/

            if (success) // && success1)
            {
                closeUpdate();
                System.Windows.Forms.MessageBox.Show(
                    "Sale Successfully Updated",
                    "Success");
            }
            else
            {
                System.Windows.Forms.MessageBox.Show(
                    "Error updating sale",
                    "Error");

            }

        }

        public static void startRemoval()
        {
            windowDeleteSale = new ViewSaleDelete();
            windowDeleteSale.ShowDialog();
        }

        public static void closeRemoval()
        {
            windowDeleteSale.Close();
        }

        public static void remove(int saleCode)
        {
            ProductSaleModel deletedSale = new ProductSaleModel();

            deletedSale.Code = saleCode;

            bool success = SalesModel.delete(deletedSale);
            bool sucess1 = ProductSaleModel.deleteProductSale(deletedSale);

            if (success && sucess1)
            {
                closeRegister();
                System.Windows.Forms.MessageBox.Show(
                    "Sale Successfully Deleted",
                    "Success");
            }
            else
            {
                System.Windows.Forms.MessageBox.Show(
                    "Error deleting sale",
                    "Error");

            }
        }

        public static void list(System.Windows.Forms.DataGridView visualElement)
        {
            visualElement.DataSource = ProductSaleModel.searchAll();
        }
    }
}
