using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DownloadManager
{
    public partial class Form1 : Form
    {
        private static Stopwatch watch = new Stopwatch();

        string URL1, URL2;


        /// <summary>
        /// This Function initializes all the components present in the Window Form.
        /// </summary>
        public Form1()
        {
            InitializeComponent();

            //Setting to visiblity to false for progressbar1 and progressbar2.
            progressBar1.Visible = false;
            progressBar2.Visible = false; ;
            label1.Visible = true;
            label2.Visible = true;

            // setting the visiblity of progressbar label to false.
            label3.Visible = false;
            label4.Visible = false;
            

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {


        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void progressBar2_Click(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// This method will be invoked when we press the Download button.
        /// Event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                string name1 = null;
                string name2 = null;
                URL1 = textBox1.Text;
                URL2 = textBox2.Text;

                if (URL1 != "")
                {
                    label3.Visible = true;
                    progressBar1.Visible = true;
                    if (URL1.Contains("youtube"))
                    {
                        string[] split = URL1.Split('%', '/');
                        int length = split.Length;

                        name1 = split[length - 1];

                        //create a instance of web client
                        WebClient client = new WebClient();

                        MessageBox.Show("File1 is video");

                        //Start the Download
                        client.DownloadFileAsync(new Uri(URL1), @"C: \Users\Public\mp$File.mp4");
                        //
                        client.DownloadFileCompleted += new AsyncCompletedEventHandler(DownloadFileCompleted1);
                        //To see the progress
                        client.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgressChanged1);

                    }
                    else if (URL1.Contains(".exe") || URL1.Contains(".Zip"))
                    {
                        // Create an instance of WebClient
                        String[] split = URL1.Split('%', '/');
                        int length1 = split.Length;
                        name1 = split[length1 - 1];
                        
                        WebClient client = new WebClient();

                        // All for URL1
                        MessageBox.Show("file1 is application");
                        // Hookup DownloadFileCompleted Event              
                        client.DownloadFileCompleted += new AsyncCompletedEventHandler(DownloadFileCompleted1);
                        //progress bar
                        client.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgressChanged1);
                        // Start the download 
                        client.DownloadFileAsync(new Uri(URL1), @"C:\Users\Public\File1");
                    }
                    else
                    {
                        // Create an instance of WebClient
                        String[] split = URL1.Split('%', '/');
                        int length1 = split.Length;
                        name1 = split[length1 - 1];
                        WebClient client = new WebClient();

                        // All for URL1
                        MessageBox.Show("file name 1 is \n" );
                        // Hookup DownloadFileCompleted Event              
                        client.DownloadFileCompleted += new AsyncCompletedEventHandler(DownloadFileCompleted1);
                        //progress bar
                        client.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgressChanged1);
                        // Start the download 
                        client.DownloadFileAsync(new Uri(URL1), @"C: \Users\Public\empty1" + " ");
                    }
                }

                if (URL2 != "")
                {
                    label4.Visible = true;
                    progressBar2.Visible = true;
                    if (URL2.Contains("youtube"))
                    {
                        string[] split = URL2.Split('%', '/');
                        int length = split.Length;

                        name2 = split[length - 1];

                        //create a instance of web client
                        WebClient client = new WebClient();

                        MessageBox.Show("File2 is video" );

                        //Start the Download
                        client.DownloadFileAsync(new Uri(URL2), @"C: \Users\Public\mp4File.mp4");
                        //
                        client.DownloadFileCompleted += new AsyncCompletedEventHandler(DownloadFileCompleted2);
                        //To see the progress
                        client.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgressChanged2);
                        
                    }
                    else if (URL2.Contains(".exe"))
                    {
                        // Create an instance of WebClient
                        String[] split = URL2.Split('%', '/');
                        int length1 = split.Length;
                        name2 = split[length1 - 1];
                        WebClient client = new WebClient();

                        // All for URL2
                        MessageBox.Show("file2 is application");
                        
                        // Hookup DownloadFileCompleted Event              
                        client.DownloadFileCompleted += new AsyncCompletedEventHandler(DownloadFileCompleted2);
                        //progress bar
                        client.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgressChanged2);
                        // Start the download 
                        client.DownloadFileAsync(new Uri(URL2), @"C:\Users\Public\exeFile2");
                    }
                    else
                    {
                        // Create an instance of WebClient
                        String[] split = URL2.Split('%', '/');
                        int length1 = split.Length;
                        name2 = split[length1 - 1];
                        WebClient client = new WebClient();

                        // All for URL2
                        MessageBox.Show("file2 is \n" );
                        // Delegate instantiation  
                        //Attach your event handler to event
                        client.DownloadFileCompleted += new   AsyncCompletedEventHandler(DownloadFileCompleted2);
                        //progress bar
                        client.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgressChanged2);
                        // Start the download 
                        client.DownloadFileAsync(new Uri(URL2), @"C: \Users\Public\empty2" + "");
                        
                    }
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message + " ");
            }






        }

        /// <summary>
        /// Event Handlers
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private  void DownloadProgressChanged2(object sender, DownloadProgressChangedEventArgs e)
        {
            // Update the progressbar percentage only when the value is not the same.
          
            // MessageBox.Show(Convert.ToString( e.ProgressPercentage));
            progressBar2.Value = e.ProgressPercentage;
            watch.Start();
            label7.Text = Convert.ToString(e.BytesReceived/1024 )+ "("+Convert.ToString( e.ProgressPercentage  )+ "% "+")";
            
        }

        private void DownloadFileCompleted2(object sender, AsyncCompletedEventArgs e)
        {
            MessageBox.Show("File 2 downloaded");
            watch.Stop();
            MessageBox.Show("time taken for File 2 to download " + watch.Elapsed);
          

        }

        private void DownloadProgressChanged1(object sender, DownloadProgressChangedEventArgs e)
        {
            // Update the progressbar percentage only when the value is not the same.
            
            Text = "Downloading " + Convert.ToString(e.ProgressPercentage) + "%";

            progressBar1.Value = e.ProgressPercentage;
            watch.Start();
            label6.Text = Convert.ToString(e.BytesReceived / 1024) + "(" + Convert.ToString(e.ProgressPercentage) + "% " + ")";
            

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void DownloadFileCompleted1(object sender, AsyncCompletedEventArgs e)
        {
            MessageBox.Show("File 1 downloaded");
            watch.Stop();
            MessageBox.Show("Time taken for File 1 to download " + watch.Elapsed);
          

        }


    }

    

   
}

