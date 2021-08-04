
namespace BrowserLibrary
{
    public class Address
    {
        /// <summary>
        /// Id, Name and Url properties form the structure of an address object that is used as the data type
        /// for history, favourites and home page. The Id is internally set and each address object 
        /// created and added to a file is assigned an Id which icnrements by 1 for each new object.
        /// </summary>
        public int Id { get; internal set; }
        public string Name { get; set; }
        public string Url { get; set; }

    
        /// <summary>
        /// Empty constructor for insantiating the Address class for accessing it's properties. 
        /// </summary>
        public Address()
        {

        }

        /// <summary>
        /// A constructor that 
        /// </summary>
        /// <param name="name"></param>
        /// <param name="url"></param>
        public Address(string name, string url)
        {
            this.Name = name;
            this.Url = url;
        }

        /// <summary>
        /// DisplayAddress provides a method for displaying the Url.
        /// Used in the history form for displaying urls in list boxes.
        /// </summary>
        public string DisplayAddress
        {
            get
            {
                return $"{Url}";
            }
        }

        /// <summary>
        /// DisplayAddress provides a method for displaying the Name and Url.
        /// Used in the favourites form for displaying favourites in the list box.
        /// </summary>
        public string DisplayAddressExt
        {
            get
            {
                return $"{Name} {Url}";
            }
        }
    }
}
