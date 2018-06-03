using Newtonsoft.Json;
using System;
using System.IO;
using System.Text;

namespace Basic_Tech_Stack
{
    internal class BinaryJsonFile
    {
        // Create the new, empty data file.
        static String strFilename = "Binfile.data";
        static BinaryWriter writer; //The BinaryWriter class is used to write binary data to a stream.
        static BinaryReader reader; // BinaryReader class is used for reading binary data from a file.

        /// <summary>
        /// Function to read values from a binary file and dispaly it to console.
        /// </summary>
        public void ReadValues()
        {

            try
            {
                // BinaryReader class is used for reading binary data from a file.
                // A BinaryReader object is created by passing a FileStream object to its constructor.
                reader = new BinaryReader(File.Open(strFilename, FileMode.Open));

            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message + " cannot read  file");
                return;

            }
            try
            {

                //Reading data from a file.

                /*float floatValue= reader.ReadSingle();
                double douValue = reader.ReadDouble();
                int intValue = reader.ReadInt32();
                Boolean booValue = reader.ReadBoolean();*/

                String strValue1 = reader.ReadString();
                String strValue2 = reader.ReadString();
                String strValue3 = reader.ReadString();



                //Printing all the fetched data to console

                /* Console.WriteLine("Floayt value: " +floatValue);
                Console.WriteLine("Double Value: " +douValue);
                Console.WriteLine("Integer value: " + intValue);
                Console.WriteLine("Boolean Value: "+booValue);*/

                Console.WriteLine();

                Console.WriteLine("VAlues are:");
                Console.WriteLine("  " + strValue1);
                Console.WriteLine("  " + strValue2);
                Console.WriteLine("  " + strValue3);


            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message + " cannot read from file");
                return;
            }
            //Closes the current reader and the underlying stream.
            reader.Close();



        }

        /// <summary>
        /// Function to write the values given by the user to a bianry file.
        /// </summary>
        public void WriteValues()
        {
            try
            {
                // Create the writer for data.
                // BinaryWriter class is used for writing binary data to a file.
                writer = new BinaryWriter(File.Open(strFilename, FileMode.Create));

            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message + "Cannot create a file");
                return;
            }
            try
            {
                //  Write data to the current stream and advances the stream position .

                /* writer.Write(3.14227F);
                 writer.Write(62355556.0);
                 writer.Write(10);
                 writer.Write(true);
                 writer.Write("Vikash kumar");*/

                Console.WriteLine("Enter data");
                writer.Write(Console.ReadLine());
                writer.Write(Console.ReadLine());
                writer.Write(Console.ReadLine());

            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message + "Cannot write to file");
                return;
            }

            //Closes the current reader and the underlying stream.
            writer.Close();

        }

        /// <summary>
        /// This is the function to write the data to a jason file.
        /// 
        /// </summary>
        public void writeJson()
        {
            try
            {

                var sb1 = new StringBuilder();
                using (var sw1 = new StringWriter(sb1))
                using (var writer = new JsonTextWriter(sw1))
                {
                    writer.Formatting = Formatting.Indented;
                    writer.WritePropertyName("Student");
                    writer.WriteStartArray();

                    writer.WriteStartObject();
                    writer.WritePropertyName("ID");
                    writer.WriteValue("101");
                    writer.WritePropertyName("NAME");
                    writer.WriteValue("Vikash");
                    writer.WriteEndObject();

                    writer.WriteStartObject();
                    writer.WritePropertyName("ID");
                    writer.WriteValue("102");
                    writer.WritePropertyName("NAME");
                    writer.WriteValue("Nitesh");
                    writer.WriteEndObject();
                    //  writer.WriteValue("Europe");
                    /* writer.WriteString("Asia");
                     writer.WriteString("Australia");
                     writer.WriteString("Antarctica");
                     writer.WriteString("North America");
                     writer.WriteString("South America");
                     writer.WriteString("Africa");*/

                    for (int i = 0; i < 3; i++)
                    {
                        writer.WriteStartObject();
                        Console.WriteLine("Enter id Number");
                        writer.WritePropertyName("ID");
                        writer.WriteValue(Console.ReadLine());
                        Console.WriteLine("Enter Name");
                        writer.WritePropertyName("NAME");
                        writer.WriteValue(Console.ReadLine());
                        writer.WriteEndObject();
                    }
                    writer.WriteEndArray();

                    Console.WriteLine("Writing the File");
                    Console.WriteLine(sb1);

                    File.WriteAllText(@"C:\Users\Admin\Desktop\vik.json", sb1.ToString());
                    // Console.ReadKey();
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message + " ");
            }
        }

        /// <summary>
        /// This is a function to read the data from a jason file.
        /// </summary>
        public void readJson()
        {
            try
            {

                var sr1 = new StringReader(@"C:\Users\Admin\Desktop\vik.json");
                var reader = new JsonTextReader(sr1);



                Console.WriteLine("Reading the file");

                String js = File.ReadAllText(@"C:\Users\Admin\Desktop\vik.json");
                Console.WriteLine(File.ReadAllText(@"C:\Users\Admin\Desktop\vik.json"));


                //  File.WriteAllText(@"C:\Users\Admin\Desktop\kum.json", File.ReadAllText(@"C:\Users\Admin\Desktop\vik.json"));
                File.WriteAllText(@"C:\Users\Admin\Desktop\sam.json", js);

                Console.ReadKey();
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message + " ");
            }
        }

        /// <summary>
        /// Starting point.
        /// </summary>
        public BinaryJsonFile()
        {
            try
            {
                string strMyChoice = "y";

                while (strMyChoice == "y" || strMyChoice == "Y" || strMyChoice == "yes" || strMyChoice == "YES" || strMyChoice == "Yes")
                {
                    Console.WriteLine("-------------");
                    Console.WriteLine(value: "1. Binary data file Handling");
                    Console.WriteLine(value: "2. Json file");

                    Console.WriteLine("----------------------");




                    Console.WriteLine("Enter your choice");
                    int intChoice = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("----------------------");

                    switch (intChoice)
                    {
                        case 1:
                            Console.WriteLine("Binary data file handling");
                            WriteValues(); //Method to write Binary data to a  file
                            ReadValues();
                            break;

                        case 2:
                            Console.WriteLine("Json read write append");
                            writeJson();
                            readJson();
                            break;




                        default:
                            Console.WriteLine("Invalid Choice!!! Enter correct choice");
                            break;

                    }
                    Console.WriteLine("Do you want to continue in File handling and json (y/n)");
                    strMyChoice = Console.ReadLine();



                }


            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message + " ");
            }
        }
    }
}
