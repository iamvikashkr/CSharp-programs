using System;
using System.IO;

namespace Basic_Tech_Stack
{
    internal class FileWatcher
    {
        /// <summary>
        /// This method is a useful way  to monitor any changes in a file system. 
        /// </summary>
        public FileWatcher()
        {
            try
            {
                
                //The FileSystemWatcher object provided by.Net is a useful way to monitor a file system. 
                FileSystemWatcher watcher = new FileSystemWatcher();

                //Then we need to assign it a path and a filter to tell the object where to keep looking.
                watcher.Path = @"C:\Users\Admin\Downloads\Basic Demo Programs" + "\\";
                Console.WriteLine("Current Watching Directory-->\n"+watcher.Path);

                // Only watch text files.
                 // watcher.Filter = "*.txt";

                watcher.Filter = "*.*";

                /* Watch for changes in LastAccess and LastWrite times, and
               the renaming of files or directories. */
                watcher.NotifyFilter = NotifyFilters.LastAccess | NotifyFilters.LastWrite
              | NotifyFilters.FileName | NotifyFilters.DirectoryName;

                //Tell the watcher to watch for changes to the sub - folders of the directory
                watcher.IncludeSubdirectories = true;

                //Next we need to describe what needs to be done when one of these attributes gets altered.
                //Event handlers
                watcher.Changed += new FileSystemEventHandler(OnChanged);
                watcher.Created += new FileSystemEventHandler(OnChanged);
                watcher.Deleted += new FileSystemEventHandler(OnChanged);
                watcher.Renamed += new RenamedEventHandler(OnRenamed);

                // Begin watching.
                watcher.EnableRaisingEvents = true;

                Console.ReadKey();
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message + " ");
            }



        }


        // Define the event handlers.
        /// <summary>
        /// Specify what is done when a file is changed, created, or deleted.
        /// </summary>
        /// <param name="source"></param>
        /// <param name="e"></param>
        public static void OnChanged(object source, FileSystemEventArgs e)
        {
            try
            {
                string ext = Path.GetExtension(e.FullPath);
                string fullPath = e.FullPath;
                
                //Console.WriteLine(ext);
                if (ext ==".txt")
                {
                    Console.WriteLine("File: " + e.FullPath + " " + e.ChangeType + " " + DateTime.Now);
                    
                }
                else
                {
                    OnDeleted(fullPath);

                }
            }
            catch(Exception e1)
            {
                Console.WriteLine(e1.Message + " ");
            }
        }

        private static void OnDeleted(string fullPath)
        {
           
          // Console.WriteLine(" File Deleted");
            File.Delete(fullPath);
        }

        // Define the event handlers.
        /// <summary>
        ///  Specify what is done when a file is renamed.
        /// </summary>
        /// <param name="source"></param>
        /// <param name="e"></param>
        public static void OnRenamed(object source, RenamedEventArgs e)
        {
            try
            {
                Console.WriteLine("File: {0} renamed to {1} ", e.OldFullPath, e.FullPath, DateTime.Now);
            }
            catch(Exception e2)
            {
                Console.WriteLine(e2.Message + " ");
            }
           
        }

        


    }
}
