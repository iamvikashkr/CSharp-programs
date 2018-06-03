using System;
using System.Reflection;
using Experimental.System.Messaging;
using System.Collections.Generic;
using System.Linq;
//using System.Messaging;
using System.Windows;
using System.Text;
using System.Threading.Tasks;


namespace Basic_Tech_Stack
{
    internal class LateBindingMSMQ
    {
        /// <summary>
        ///     Method to perform Late Binding using Reflection, Binding the customer class at the runtime.
        /// </summary>
        public static void LateBinding()
        {
            try
            {
                // Load the current executing assembly as the Customer class is present in it.
                Assembly executingAssembly = Assembly.GetExecutingAssembly();

                // Load the Customer class for which we want to create an instance dynamically
                Type T = typeof(customer);

                Type customerType = executingAssembly.GetType("Basic_Tech_Stack.customer");

                // Create the instance of the customer type using Activator class 
                object customerInstance = Activator.CreateInstance(customerType);

                // Get the method information using the customerType and GetMethod()
                MethodInfo getFullName = customerType.GetMethod(name: "GetFullName");

                // Create the parameter array and populate first and last names
                string[] methodParameters = new string[2];
                methodParameters[0] = "Bridge";   //FirstName
                methodParameters[1] = "Labz";     //LastName

                // Invoke the method passing in customerInstance and parameters array
                string fullName = (string)getFullName.Invoke(customerInstance, methodParameters);


                Console.WriteLine("Full Name = {0}", fullName);



                Console.WriteLine(customerType);
                Console.WriteLine(T);

                Console.ReadKey();
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message + " ");
            }
        }
       

        /// <summary>
        /// To create a queue and send a message to it, you can use the following code snippet.
        /// </summary>
        public static void SendingMessage()
        {
            Console.WriteLine("Enter the message to be sent");
            string MessageToBeSend = Console.ReadLine();// Read the message to be sent from console

            MessageQueue myQueue; // Queue name
            try
            {
                //If the Queue already exists then no need to create new Queue else create a new Queue.
                if (MessageQueue.Exists(@".\Private$\myQueue"))
                {
                    myQueue = new MessageQueue(@".\Private$\myQueue");
                }
                else
                {
                    myQueue = MessageQueue.Create(@".\Private$\myQueue");
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message + " Error");
                return;
            }
            // Create a object for Message where message is going to be Stored
            Message myMessage = new System.Messaging.Message();
            //Set Formatter for Message 
            myMessage.Formatter = new BinaryMessageFormatter();
            myMessage.Body = MessageToBeSend;
            myMessage.Label = "Application Send";



            myQueue.Send(myMessage);

            Console.WriteLine("Thanks for Sending Message");
            Console.ReadLine();


        }


        /// <summary>
        /// To retrieve the Messages stored in message Queue, below is the code snippet.
        /// </summary>
        public static void receiveMessage()
        {
            Console.WriteLine("Latest Message is...");
            // Get the reference of the Queue
            MessageQueue myQueue;
            try
            {
                myQueue = new MessageQueue(@".\Private$\myQueue");

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message + " Error");
                return;
            }
            Message myMessage = myQueue.Receive();
            //Set Formatter for Message 

            myMessage.Formatter = new BinaryMessageFormatter();

            //Displaying the Message
            Console.WriteLine(myMessage.Body.ToString());
            Console.ReadKey();

        }

        /// <summary>
        /// 
        /// Start of the Application
        /// </summary>
        public LateBindingMSMQ()
        {
            try
            {
                string strMyChoice = "y";

                while (strMyChoice == "y" || strMyChoice == "Y" || strMyChoice == "yes" || strMyChoice == "YES" || strMyChoice == "Yes")
                {
                    Console.WriteLine("-------------");
                    Console.WriteLine(value: "1. Late Binding");
                    Console.WriteLine(value: "2. MSMQ");

                    Console.WriteLine("----------------------");




                    Console.WriteLine("Enter your choice");
                    int intChoice = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("----------------------");

                    switch (intChoice)
                    {
                        case 1:
                            Console.WriteLine("Late Binding using Reflection");
                            LateBinding();
                            break;

                        case 2:
                            Console.WriteLine("MSMQ");
                            SendingMessage();  //Method to Send a Message
                          receiveMessage();  // Method to Receive a Message
                            break;




                        default:
                            Console.WriteLine("Invalid Choice!!! Enter correct choice");
                            break;

                    }
                    Console.WriteLine("Do you want to continue in Current Session (y/n)");
                    strMyChoice = Console.ReadLine();



                }


            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message + " ");
            }
        }
    }
    /// <summary>
    /// Late binding is performed on this class
    /// </summary>
    public class customer
    {
        public string GetFullName(string first, string last)
        {
            return first + " " + last;
        }
    }


}