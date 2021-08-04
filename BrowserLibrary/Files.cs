
namespace BrowserLibrary
{
    /// <summary>
    /// Files class provides a class for a GUI class to access a filename for data persistence.
    /// </summary>
    public class Files
    {
        /// <summary>
        /// Favourite,History and Home page files provide data persistence in CSV file format. 
        /// SessionHistoryFile provides a data store for the current session. It is wiped clean
        /// after every session when the browser is closed. 
        /// </summary>
        public string FavouriteFile { get; } = "Favourites.csv";
        public string HistoryFile { get; } = "History.csv";
        public string HomePageFile { get; } = "Home.csv";
        public string SessionHistoryFile { get; } = "SessionHistory.csv";

        /// <summary>
        /// Empty constructor for instantiating the class and accessing its properties in the GUI. 
        /// </summary>
        public Files()
        {

        }
    }
}
