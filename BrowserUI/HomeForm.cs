using BrowserLibrary;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BrowserUI
{
    /// <summary>
    /// HomeForm class allows users to manage their home page url for
    /// when the browser is loaded. 
    /// </summary>
    public partial class HomeForm : Form
    {
        /// <summary>
        /// Object of file class for accessing it's properties.
        /// </summary>
        Files file = new Files();

        /// <summary>
        /// The home list holds the objects loaded from the home page file. 
        /// </summary>
        private List<Address> home = new List<Address>();
        public HomeForm()
        {
            InitializeComponent();
            LoadData();
            HomeUrl.Text = "https://";
            DisplayInformation();
        }

        /// <summary>
        /// Loads all home page items from the home page file. 
        /// adds them to the home list. 
        /// </summary>
        private void LoadData()
        {
            foreach (IFileConnection connection in GlobalDataConnection.Connection)
            {
                home = connection.GetAllAddresses(file.HomePageFile);
            }
        }

        /// <summary>
        /// Displays the very last item saved to the home page file
        /// </summary>
        public void DisplayInformation()
        {
            foreach (Address u in home)
            {
                HomeName.Text = u.Name;
                HomeUrl.Text = u.Url;
            }
        }
     
        /// <summary>
        /// Enables the creation of a home page object taking the details
        /// provided by the user in the form and saving them to the file
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void HomeCreateButton_Click(object sender, EventArgs e)
        {
            if (CheckForm())
            {
                Address model = new Address
                {
                    Name = HomeName.Text,
                    Url = HomeUrl.Text
                };

                foreach (IFileConnection txt in GlobalDataConnection.Connection)
                {
                    txt.CreateAddress(model,file.HomePageFile);
                    home.Add(model);
                    MessageBox.Show("Home Page Url Saved.");
                    this.Close();
                }
                HomeName.Text = "";
                HomeUrl.Text = "https://";
            }
            else
            {
                MessageBox.Show("Invalid Information Supplied");
            }
        }

        /// <summary>
        /// Ensures the form has sufficient details for creating a home page entry. 
        /// </summary>
        /// <returns></returns>
        private bool CheckForm()
        {
            //Ensures name box has an entry
            bool result = true;
            if (HomeName.Text.Length == 0)
            {
                result = false;
            }

            //ensures url box has an entry and it contains https:// which is required by the 
            //HttpClient for GET requests. 
            if (HomeUrl.Text.Length == 0 || !HomeUrl.Text.Contains("https://"))
            {
                result = false;
            }
            return result;
        }
    }
}

