using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using marketProject.View;
using marketProject.Model;

namespace marketProject.Controller
{
    class SupplierController
    {

        private static ViewSupplierRegister windowRegisterSupplier;

        //Register
        public static void startRegister()
        {
            windowRegisterSupplier = new ViewSupplierRegister();
            windowRegisterSupplier.ShowDialog();

        }

        public static void closeRegister()
        {
            windowRegisterSupplier.Close();
        }

        public static void register(string name, string address, string district,
                                    string city, string state, string zip,
                                    string phone)
        {
            //Struct the informations recived from the Supplier Model

            SupplierModel newSupplier = new SupplierModel();

            newSupplier.Name = name;
            newSupplier.Address = address;
            newSupplier.District = district;
            newSupplier.City = city;
            newSupplier.State = state;
            newSupplier.Zip = zip;
            newSupplier.Phone = phone;

            //Save the informations
            bool sucess = SupplierModel.save(newSupplier);

            if (sucess)
            {
                closeRegister();
                System.Windows.Forms.MessageBox.Show(
                    "Supplier Successfully Registered",
                    "Success");
            }
            else
            {
                System.Windows.Forms.MessageBox.Show(
                    "Error registering supplier",
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
            visualElement.DataSource = SupplierModel.search();
        }
    }
}
