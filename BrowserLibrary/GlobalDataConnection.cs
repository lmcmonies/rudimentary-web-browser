
using System.Collections.Generic;

namespace BrowserLibrary
{
    public static class GlobalDataConnection
    {
        /// <summary>
        /// This connection list holds all available connections. At present there is only the 
        /// ability to connnect to several text files but this functionality provides a 
        /// relatively easy way to add in the ability to connect to a database 
        /// and even update a database and text file at the same time. 
        /// </summary>
        public static List<IFileConnection> Connection { get; private set; } = new List<IFileConnection>();

        /// <summary>
        /// this method is invoked in the Program.cs class, the main entry point to the application
        /// It passes in the value true ensuring that a connection can be made. 
        /// </summary>
        /// <param name="textFiles"></param>
        public static void InitialiseConnection(bool textFiles)
        {
            if (textFiles)
            {
                //if true a FileUtility object is created and added to the Connection list so a connection 
                //to the text files is always available from the GUI.
                FileUtility textConnection = new FileUtility();
                Connection.Add(textConnection);
            }
        }
    }
}
