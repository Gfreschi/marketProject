using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Aula04_ProjetoMercado.Model;
using Aula04_ProjetoMercado.View;
using marketProject.View;

namespace Aula04_ProjetoMercado.Controller
{
    class ClientController
    {


        private static ViewClientRegister windowRegisterClient;
        private static ViewClientUpdate windowUpdateClient;

        //Register
        public static void startRegister()
        {
            windowRegisterClient = new ViewClientRegister();
            windowRegisterClient.ShowDialog();
        }

        public static void closeRegister()
        {
            windowRegisterClient.Close();
        }

        public static void register(string name, string address, string district,
                                    string city, string state, string zip,
                                    string phone, string cpf, string rg)
        {
            //Struct the information received on a Client Model;

            ClientModel newClient = new ClientModel();
            newClient.Name = name;
            newClient.Address = address;
            newClient.District = district;
            newClient.City = city;
            newClient.State = state;
            newClient.Zip = zip;
            newClient.Phone = phone;
            newClient.Cpf = cpf;
            newClient.Rg = rg;

            //Save the new client
            bool success = ClientModel.save(newClient);

            if(success)
            {
                closeRegister();
                System.Windows.Forms.MessageBox.Show(
                    "Client Successfully Registered",
                    "Success");
            } 
            else
            {
                System.Windows.Forms.MessageBox.Show(
                    "Error registering client",
                    "Error");

            }

        }
        //Update
        public static void startUpdate () 
        {
            windowUpdateClient = new ViewClientUpdate();
            windowUpdateClient.ShowDialog();

        }
        public static void closeUpdate()
        {
            windowUpdateClient.Close();
        }
        public static void update(int code, string name, string address, string district,
                                    string city, string state, string zip, string phone)
        {
            ClientModel updatedClient = new ClientModel();

            updatedClient.Code = code;
            updatedClient.Name = name;
            updatedClient.Address = address;
            updatedClient.District = district;
            updatedClient.City = city;
            updatedClient.State = state;
            updatedClient.Zip = zip;
            updatedClient.Phone = phone;
            

            bool success = ClientModel.edit(updatedClient);

            if (success)
            {
                closeRegister();
                System.Windows.Forms.MessageBox.Show(
                    "Client Successfully Updated",
                    "Success");
            }
            else
            {
                System.Windows.Forms.MessageBox.Show(
                    "Error updating client",
                    "Error");

            }

        }

        //Removal
        public static void startRemoval () { }
        public static void closeRemoval () { }
        public static void remove () { }

        //List
        public static void list(System.Windows.Forms.DataGridView visualElement)
        {
            //Searching on model the informations registered on DB and returning a visual element response
            visualElement.DataSource = ClientModel.search();
        }
    }
}
