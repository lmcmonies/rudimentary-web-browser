
using System.Collections.Generic;

namespace BrowserLibrary
{
    /// <summary>
    /// IFileConnection interface provides a contract for any class that implements it. 
    /// The FileUtility class is an example. It ensures that the FileUtility class implements the
    /// methods defined here. 
    /// </summary>
    public interface IFileConnection
    {
        //Allows an address object to be created for a specified file. 
        Address CreateAddress(Address entry, string FileName);

        //Allows an address object to be deleted from a specified file.
        Address DeleteAddress(Address entry, string FileName);

        //Allows all addresses in a specified file to be retrieved. 
        List<Address> GetAllAddresses(string FileName);
    }
}
