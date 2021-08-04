using System;
using System.Configuration;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace BrowserLibrary
{
    /// <summary>
    /// The TextFileTool class is static as it provides several extension methods for use by
    /// other classes, in particular the FileUtility class,
    /// but no instantiation of this class is necessary. 
    /// It provides methods for:
    /// Appending filenames to file path.
    /// Loading text files.
    /// Converting a <string> list into Address list after file loaded.
    /// Converting an <Address> list into string list for writing to file. 
    /// </summary>
    public static class TextFileTool
    {
        public static string FilePath(this string FileName)// A csv file
        {
            //Takes the csv file in and appends it to the end of the file path. 
            //Returns this newly appended file.
            return $"{ConfigurationManager.AppSettings["FilePath"]}\\{FileName}";
        }

        /// <summary>
        ///  Takes the fully formed filepath in which was returned from FilePath(), 
        ///  reads all lines in file and adds them to a list.
        /// </summary>
        public static List<string> LoadFile(this string file)
        {
            //checks to see if the file specified exists. If not, emtpty string list returned
            if (!File.Exists(file))
            {
                return new List<string>();
            }
            //adding each line as a string to an array and then converting to a list. 
            return File.ReadAllLines(file).ToList();
        }


        /// <summary>
        /// Takes the string list in, iterates through each line and delimits
        /// on the comma and adding each element of the line to a string array.
        /// string array then copied to result list of type Address and returned. 
        /// </summary>
        /// <param name="lines"></param>
        /// <returns></returns>
        public static List<Address> ChangeToAddress(this List<string> lines)
        {
            List<Address> result = new List<Address>();

            //iterates through the lines list
            foreach (string l in lines)
            {
                //checks the line is not empty
                if (l != "")
                {
                    //comma delimiting the line
                    string[] array = l.Split(',');
                    //creating an address object from the comma delimited string
                    Address browser = new Address();
                    browser.Id = int.Parse(array[0]);
                    browser.Name = array[1];
                    browser.Url = array[2];
                    //adds the created object to the list of type Address
                    result.Add(browser);
                }
            }
            //returns the list of type address 
            return result;
        }

        /// <summary>
        /// Takes the Address list and file name in.
        /// Iterates through list adding each value(Id,Name,Url) in a 
        /// comma delimited format to a lines list of type string. Finally, writes all lines 
        /// in lines list to the specified file. Provides options depending 
        /// </summary>
        /// <param name="entries"></param>
        /// <param name="FileName"></param>
        public static void SaveToFile(this List<Address> entries, string FileName)
        {
            List<string> lines = new List<string>();

            try
            {
                foreach (Address b in entries)
                {
                    //executes if there isn't a name provided for the address object.
                    //used for adding a favourite from the main browser using the star button.
                    if (b.Name == null)
                    {
                        if (!b.Url.Contains("www"))
                        {
                            //if url doesnt contain www then undefined is added 
                            //instead of a name. This can then be updated by the user
                            //in the favourites manager. 
                            //e.g. 1,Undefined,https://google.com
                            lines.Add($"{b.Id},{b.Name = "Undefined"},{b.Url}");
                        }
                        else
                        {
                            //if it does contain www then the name can be derived from
                            //splitting the url on the dots then putting the first
                            //character to uppercase.
                            //e.g. 1,Google,https://www.google.com
                            var a = b.Url.Split('.')[1];
                            var c = char.ToUpper(a[0]) + a.Substring(1) + " ";
                            lines.Add($"{b.Id},{b.Name = c},{b.Url}");
                        }
                    }
                    else
                    {
                        //adds an entry to the file in a Id,Name,Url format
                        //e.g. 1,Google,https://www.google.com
                        lines.Add($"{b.Id},{b.Name},{b.Url}");
                    }
                }
                //write all lines to the specificed file.
                File.WriteAllLines(FileName.FilePath(), lines);
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine(e);
            }
            catch (NullReferenceException ex)
            {
                Console.WriteLine(ex);
            }
        }
    }
}
