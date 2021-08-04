
using System.Collections.Generic;
using System.Linq;

namespace BrowserLibrary
{
    /// <summary>
    /// The FileUtility class has several methods that make use of C# extension methods defined
    /// in the TextFileTool class. These include functionality for deleting, creating and getting addresses from files. 
    /// The IFileConnection interface is used and defines the 
    /// </summary>
    public class FileUtility : IFileConnection
    {
        /// <summary>
        /// GetAllAddresses makes use of extension methods to get all the address objects 
        /// from a specified file and return them. The specificed file is appended 
        /// to the FilePath() then
        /// FilePath() takes in file name which returns appended file path.
        /// LoadFile() then takes in that appended filepath and returns a string list.
        /// ChangeToAddress() then takes that string list in and changes all lines of 
        /// strings to an Address object and returns a list of type Address. 
        /// A list in one of the forms can then be populated using this returned list
        /// then the information can be rendered to the GUI.
        /// </summary>
        /// <param name="FileName"></param>
        /// <returns></returns>
        public List<Address> GetAllAddresses(string FileName)
        {
            return FileName.FilePath().LoadFile().ChangeToAddress();
        }

        /// <summary>
        /// DeleteAddresses also makes use of extension methods defined in the TextFileTool class.
        /// The same construct of extension methods as GetAllAddresses is used but in this case
        /// the objects are added to a list inside this method. The id of the 
        /// address to be deleted is passed in along with the file where the object exists.
        /// The list is iterated through and where the passed in Id matches with an objects Id in the 
        /// list it is removed.The contents of the list are then saved back to the file. 
        /// </summary>
        /// <param name="entry"></param>
        /// <param name="FileName"></param>
        /// <returns></returns>
        public Address DeleteAddress(Address entry, string FileName)
        {
            List<Address> addresses =
            FileName.FilePath().LoadFile().ChangeToAddress();

            int id = entry.Id;

            for (int i = 0; i < addresses.Count; i++)
            {
                if (addresses[i].Id == id)
                {
                    addresses.RemoveAt(i);
                }
            }
            addresses.SaveToFile(FileName);
            return entry;
        }


        /// <summary>
        /// CreateAddress once again follows the same construct of extension methods to get a specified 
        /// files contents into a list in the form of Address objects. 
        /// </summary>
        /// <param name="entry"></param>
        /// <param name="FileName"></param>
        /// <returns></returns>
        public Address CreateAddress(Address entry, string FileName)
        {
            //Load Text File
            //Convert to List<Url>
            List<Address> addresses =
            FileName.FilePath().LoadFile().ChangeToAddress();

            //Find Max ID
            //Ensures that the first time a favourites file is created, the first entry is assigned an ID of 1. 
            int currID = 1;

            if (addresses.Count > 0)
            {
                //Favourites list ordered in descending order by ID. Take first elements 
                //ID and add 1. This is now value of current ID. 
                currID = addresses.OrderByDescending(i => i.Id).First().Id + 1;
            }
            //Model passed in now assigned to current ID. 
            entry.Id = currID;
            //Add new record with new ID
            addresses.Add(entry);
            //Convert Url to List<string>
            //Save the List<string> to text file
            addresses.SaveToFile(FileName);

            return entry;
        }
    }
}
