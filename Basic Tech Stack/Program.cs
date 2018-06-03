using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Tech_Stack
{
    class Program
    {
        /// <summary>
        /// Starting point of application.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {

            try
            {
                string strMyChoice = "y";

                while (strMyChoice == "y" || strMyChoice == "Y" || strMyChoice=="yes" || strMyChoice=="YES" || strMyChoice=="Yes")
                {
                    Console.WriteLine("WORK ITEMS ARE:");
                    Console.WriteLine("----------------------");

                    Console.WriteLine("1. SORTING METHODS");
                    Console.WriteLine("2. MATRIX MANIPULATION");
                    Console.WriteLine("3. DATE TIME OVERLAPPED TASKS");
                    Console.WriteLine("4. BINARY DATA FILE HANDLING and  JSON READ WRITE APPEND");
                    Console.WriteLine("5. LATE BINDING USING REFLECTION AND MSMQ");
                    Console.WriteLine("6. CONNECTION POOLING");
                    Console.WriteLine("7. IN-MEMORY DATABASE");
                    Console.WriteLine("8. FILE WATCHER");
                   
                    Console.WriteLine("----------------------");

                    Console.WriteLine();


                    Console.WriteLine("Enter your choice");
                    int intChoice = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("----------------------");

                    switch (intChoice)
                    {
                        case 1:
                            Console.WriteLine("Different Sorting method");
                            SortingTechnique sort=new SortingTechnique();
                            break;

                        case 2:
                            Console.WriteLine("Matrix Manipulation");
                            MatrixManipulation matrix = new MatrixManipulation();

                            break;
                        case 3:
                            Console.WriteLine("Date time overllaped task:");
                            DatetimeOverlap overlap = new DatetimeOverlap();
                           
                            break;

                        case 4:
                            Console.WriteLine("Binary file Handling and json read write append");
                            BinaryJsonFile binaryJson = new BinaryJsonFile();
                            break;

                        case 5:
                            Console.WriteLine("Late Binding using Reflection and MSMQ");
                            LateBindingMSMQ lateBindingMSMQ = new LateBindingMSMQ();
                            break;
                        case 6:
                            Console.WriteLine("Connection pooling");
                            connectionPool connection = new connectionPool();

                            // Connection pooling allows you to reuse connections
                            // rather than create a new one every time the ADO.NET data provider needs to establish a connection to the
                            // underlying database.
                            connection.dataReader();

                            //It is entirely disconnected in nature, and is database independent.
                            connection.dataSet();
                            break;
                        case 7:
                            Console.WriteLine("In-memory Database");
                            InMemory inm = new InMemory();
                            inm.InmemoryData();
                            
                            break;

                        case 8:
                            Console.WriteLine("File Watcher");
                            FileWatcher fileWatcher = new FileWatcher();
                            break;  
                            
                         default:
                            Console.WriteLine("Invalid Choice!!! Enter correct choice");
                            break;

                    }
                    Console.WriteLine("Do you want to continue Basic tech Programs  (y/n)");
                    strMyChoice = Console.ReadLine();



                }
                Console.WriteLine("**********THE END*************");

            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message + "");
            }
           

            Console.ReadKey();
        }
    }
}
