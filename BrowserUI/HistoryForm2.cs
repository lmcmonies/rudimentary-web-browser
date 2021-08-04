using BrowserLibrary;
using System.Windows.Forms;

namespace BrowserUI
{
    /// <summary>
    /// HistoryForm2 class takes GET request data from the HistoryForm class
    /// for the All Time History and displays it. 
    /// </summary>
    public partial class HistoryForm2 : Form
    {
        public HistoryForm2()
        {
            InitializeComponent();
        }
        /// <summary>
        /// The constructor takes in the response and url from the http request executed in the HistoryForm 
        /// and displays ensures the HistoryForm1 can displace the contents. 
        /// </summary>
        /// <param name="res"></param>
        /// <param name="url"></param>
        public HistoryForm2(string res, string url)
        {
            InitializeComponent();
            ResponseBox.Text = res;
            ResponseLabel.Text ="RESPONSE: " + HttpTool.StatusCode +  "      URL: " + url.ToUpper();
        }
    }
}
