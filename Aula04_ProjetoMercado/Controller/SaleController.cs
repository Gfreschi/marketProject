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
            ProductSaleModel newProductSale = new ProductSaleModel();

            newProductSale.ProductCode = productCode;
            newProductSale.Amount = amount;

            //Class inheritance for SalesModel
            newProductSale.PricePaid = pricePaid;
            newProductSale.ClientCode = clientCode;

            bool success = SalesModel.save(newProductSale);
            bool success1 = ProductSaleModel.saveProductSale(newProductSale);

            if (success1 && success)
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
            ProductSaleModel updatedSale = new ProductSaleModel();

            updatedSale.SaleCode = saleCode;
            updatedSale.ProductSaleCode = saleCode;
            updatedSale.ProductCode = productCode;
            updatedSale.ClientCode = clientCode;
            updatedSale.Amount = amount;
            updatedSale.PricePaid = pricePaid;

            bool success = SalesModel.edit(updatedSale);
            bool success1 = ProductSaleModel.editProductSale(updatedSale);

            if (success && success1)
            {
                closeRegister();
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
