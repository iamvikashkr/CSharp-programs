using System;
using System.Data;
using System.Data.SqlClient;

namespace Basic_Tech_Stack
{
    internal class connectionPool
    {
        /// <summary>
        ///  DataReader has a connection oriented nature, whenever you want fetch the data from database that you must have a connection. 
        ///  It fetches one row at a time so very less network cost when compare to DataSet.
        /// </summary>
        public void dataReader()
        {
            try
            {
                
                Console.WriteLine("________CONNECTION POOLING WITH DATAREADER__________");

                //When a SqlConnection object is requested, it is obtained from the pool if a usable connection is available. 
                SqlConnection con = new SqlConnection(connectionString: @"Data Source=(localdb)\MSSQLLocalDB; Initial Catalog=Test; Integrated Security=SSPI");

                //Executing the sql Command
                SqlCommand cmd = new SqlCommand("Select * from Test1", con);

                // Connection Pool A will be created.
                con.Open();

                //// Create new SqlDataReader object and read data from the command.
                SqlDataReader reader = cmd.ExecuteReader();

                Console.WriteLine(value: "ID" + "   " + "NAME");
                Console.WriteLine("-----------");

                // while there is another record present
                while (reader.Read())
                {
                    string name = reader["Name"].ToString();
                    string Id = reader["Id"].ToString();
                    Console.Write(Id + "    ");
                    Console.Write(name + "  ");
                    Console.WriteLine();
                }
                // Always close the connection when you are finished using it so that the connection will be returned to the pool.
                con.Close();



                Console.WriteLine("=================");
                //  con = new SqlConnection(connectionString: @"Data Source=(localdb)\MSSQLLocalDB; Initial Catalog=Test; Integrated Security=SSPI");


                // Executing a Parameterize command
                SqlCommand ParmCmd = new SqlCommand("Select * from Test1 where Id= @0", con);
                con.Open();
                ParmCmd.Parameters.Add(new SqlParameter("0", 1));

                SqlDataReader reader1 = ParmCmd.ExecuteReader();
                while (reader1.Read())
                {
                    string name = reader1["Name"].ToString();
                    string Id = reader1["Id"].ToString();
                    Console.Write(Id + "    ");
                    Console.Write(name + "  ");
                    Console.WriteLine();
                }

                // Always close the connection when you are finished using it so that the connection will be returned to the pool.
                con.Close();
                Console.WriteLine("=================");
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();

            }
            catch (Exception ex)
            {
                //Handle the Exception
                ex.ToString();
            }
        }

        /// <summary>
        /// The DataSet class in ADO.Net operates in an entirely disconnected nature. Dataset is used to hold tables with data.
        /// </summary>
        public  void dataSet()
        {

            try
            {

                Console.WriteLine("________CONNECTION POOLING WITH DATASET__________");
                SqlConnection con = new SqlConnection(connectionString: @"Data Source=(localdb)\MSSQLLocalDB; Initial Catalog=Test; Integrated Security=SSPI");

                string queryString = "Select * from Test1";

                // Create an instance of SqlDataAdapter. Spcify the command and the connection
                SqlDataAdapter adapter = new SqlDataAdapter(queryString, con);

                // Create an instance of DataSet, which is an in-memory datastore for storing tables
                DataSet ds = new DataSet();

                // Call the Fill() methods, which automatically opens the connection, executes the command 
                // and fills the dataset with data, and finally closes the connection.
                adapter.Fill(ds, "Test1");
                Console.WriteLine(value: "ID" + "   " + "NAME");
                Console.WriteLine("------------");

                foreach (DataRow row in ds.Tables["Test1"].Rows)
                {

                    string Id = row["Id"].ToString();
                    string name = row["Name"].ToString();

                    //Console.Write(row["Id"]);
                    //Console.Write(row["Name"]);
                    Console.Write(Id + "    ");
                    Console.Write(name + "  ");
                    Console.WriteLine();
                }

                Console.ReadKey();

            }
            catch (Exception e)
            {
                //Handle the exception
                e.ToString();

            }


        }



    }
}