
using BrowserLibrary;
using System.Windows.Forms;

namespace BrowserUI
{
    /// <summary>
    /// FavouriteForm2 class takes http request data passed through the constructor from the FavouriteForm class
    /// to be displayed in this form. 
    /// </summary>
    public partial class FavouriteForm2 : Form
    {
        /// <summary>
        /// The constructor takes in the response and url from the http request executed in the HistoryForm 
        /// and displays ensures the HistoryForm1 can displace the contents. 
        /// </summary>
        /// <param name="res"></param>
        /// <param name="url"></param>
        public FavouriteForm2(string res, string url)
        {
            InitializeComponent();
            ResponseBox.Text = res;
            ResponseLabel.Text = "RESPONSE: " + HttpTool.StatusCode + "      URL: " + url.ToUpper();
        }
    }
}
