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

        //Register'
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
    }
}
