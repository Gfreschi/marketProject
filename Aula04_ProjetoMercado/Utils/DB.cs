using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MySql.Data.MySqlClient;
using System.Data;

namespace marketProject.Utils
{
    class DB
    {
        private string host = "localhost";
        private string username = "root";
        private string password = "";
        private string database = "market";
        private MySqlConnection connection;

        //constructor
        public DB()
        {
            string connectionCall = "SERVER=" + host + ";" +
                                    "DATABASE=" + database + ";" +
                                    "UID=" + username + ";" +
                                    "PASSWORD=" + password + ";";

            connection = new MySqlConnection(connectionCall);
        }

        //Opening and Closing connections w/ DB
        private bool openConnection()
        {
            try
            {
                connection.Open();
                return true;
            }
            catch (Exception ex)
            {
                //Error 
                System.Windows.Forms.MessageBox.Show("ERROR when opening connection: " + ex.Message + "Error.");
                return false;
            }

        }
        private bool closeConnection()
        {
            try
            {
                connection.Close();
                return true;
            }
            catch (Exception ex)
            {
                //Error 
                System.Windows.Forms.MessageBox.Show("ERROR when opening connection: " + ex.Message + "Error.");
                return false;
            }
        }
        // TESTE UNITÁRIO
        // true = insert("INSERT INTO cliente VALUES (1, 'Tiago')");
        // Verificação do teste ASSERT(true, insert);

        // false = insert("INSERT INTO cliente VALUES (1, 'Tiago')");
        // Verificação do teste ASSERT(false, insert);

        //Handling w/ DB
        public int insert_return_id(string query, List<MySqlParameter> parameters)
        {
            //Insert INTO client (code, value) VALUES (__, __)
            try
            {
                if (openConnection()) //Connection true
                {
                    MySqlCommand cmd = new MySqlCommand(query, connection);

                    if (parameters != null)
                        for (int i = 0; i < parameters.Count; i++)
                            cmd.Parameters.Add(parameters[i]);

                    int response = cmd.ExecuteNonQuery();

                    int last_id = (int)cmd.LastInsertedId;

                    Console.WriteLine("Insert response: " + response);

                    closeConnection();

                    if (response != 0) // Não teve erros...
                        return last_id;
                    return -1;
                }

                return -1;
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Error on MySQL: " + ex.Message, "Error");
                return -1;
            }
        }

        public bool insert(string query, List<MySqlParameter> parameters)
        {
            //Insert INTO client (code, value) VALUES (__, __)
            try
            {
                if (openConnection()) //Connection true
                {
                    MySqlCommand cmd = new MySqlCommand(query, connection);

                    if (parameters != null)
                        for (int i = 0; i < parameters.Count; i++)
                            cmd.Parameters.Add(parameters[i]);

                    int response = cmd.ExecuteNonQuery();

                    // cmd.LastInsertedId

                    Console.WriteLine("Insert response: " + response);

                    closeConnection();

                    if (response != 0)
                        return true;
                    return false;

                }

                return false;

            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Error on MySQL: " + ex.Message, "Error");
                return false;
            }


        }

        public bool update(string query, List<MySqlParameter> parameters)
        {
            return insert(query, parameters);
        }

        public bool delete(string query, List<MySqlParameter> parameters)
        {
            return insert(query, parameters);
        }

        public DataTable search(string query, List<MySqlParameter> parameters)
        {
            try
            {
                if (openConnection())
                {
                    DataTable responseTable = null;

                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    if (parameters != null)
                        for (int i = 0; i < parameters.Count; i++)
                            cmd.Parameters.Add(parameters[i]);

                    //Select Query
                    MySqlDataReader data = cmd.ExecuteReader();
                    List<string> register = new List<string>();

                    //Converting a Data Reader(SQL) into a DataTable (C#)
                    DataTable dataBaseSchema = data.GetSchemaTable();
                    responseTable = new DataTable();

                    if (data != null && dataBaseSchema != null) //There is informations to be presented
                    {
                        //Converting and creating C# columns
                        foreach (DataRow line in dataBaseSchema.Rows)
                        {
                            if (!responseTable.Columns.Contains(line["ColumnName"].ToString()))
                            {
                                DataColumn col = new DataColumn()
                                {
                                    ColumnName = line["ColumnName"].ToString(),
                                    Unique = Convert.ToBoolean(line["IsUnique"]),
                                    AllowDBNull = Convert.ToBoolean(line["AllowDBNull"]),
                                    ReadOnly = Convert.ToBoolean(line["IsReadOnly"])
                                };
                                responseTable.Columns.Add(col);
                            }
                        }

                        //Adding table registers
                        while (data.Read())
                        {
                            DataRow newRegister = responseTable.NewRow();

                            for (int i = 0; i < responseTable.Columns.Count; i++)
                                newRegister[i] = data.GetValue(i);
                            responseTable.Rows.Add(newRegister);
                        }

                        data.Close();
                    }

                    return responseTable;
                }
                else
                    return null;
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("ERROR MySQL: " + ex.Message, "Error");
                return null;
            }
        }


    }
}
