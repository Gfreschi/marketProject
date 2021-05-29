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
        private static ViewSupplierUpdate windowUpdateSupplier;
        private static ViewSupplierDelete windowDeleteSupplier;

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
        public static void startUpdate()
        {
            windowUpdateSupplier = new ViewSupplierUpdate();
            windowUpdateSupplier.ShowDialog();
        }
        public static void closeUpdate()
        {
            windowUpdateSupplier.Close();
        }
        public static void update(int code, string name, string address, string district,
                                    string city, string state, string zip,
                                    string phone)
        {

            SupplierModel updatedSupplier = new SupplierModel();

            updatedSupplier.Code = code;
            updatedSupplier.Name = name;
            updatedSupplier.Address = address;
            updatedSupplier.District = district;
            updatedSupplier.City = city;
            updatedSupplier.State = state;
            updatedSupplier.Zip = zip;
            updatedSupplier.Phone = phone;

            //Save the informations
            bool sucess = SupplierModel.edit(updatedSupplier);

            if (sucess)
            {
                closeRegister();
                System.Windows.Forms.MessageBox.Show(
                    "Supplier Successfully Updated",
                    "Success");
            }
            else
            {
                System.Windows.Forms.MessageBox.Show(
                    "Error updating supplier",
                    "Error");

            }

        }

        //Removal
        public static void startRemoval()
        {
            windowDeleteSupplier = new ViewSupplierDelete();
            windowDeleteSupplier.ShowDialog();
        }
        public static void closeRemoval()
        {
            windowDeleteSupplier.Close();
        }
        public static void remove(int code)
        {
            SupplierModel deletedSupplier = new SupplierModel();

            deletedSupplier.Code = code;

            bool sucess = SupplierModel.delete(deletedSupplier);

            if (sucess)
            {
                closeRegister();
                System.Windows.Forms.MessageBox.Show(
                    "Supplier Successfully Deleted",
                    "Success");
            }
            else
            {
                System.Windows.Forms.MessageBox.Show(
                    "Error deleting supplier",
                    "Error");

            }

        }

        public static void list(System.Windows.Forms.DataGridView visualElement)
        {
            visualElement.DataSource = SupplierModel.search();
        }
    }
}
