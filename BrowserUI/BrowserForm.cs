using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Windows.Forms;
using BrowserLibrary;

namespace BrowserUI
{
    /// <summary>
    /// BrowserForm is the main form of the application. It provides the entry point for the GUI
    /// and allows other form to be loaded such as history manager, favourites manager and home page manager. 
    /// </summary>
    public partial class BrowserForm : Form 
    {
        /// <summary>
        /// DefaultHomePage provides a default home page url for the very first time 
        /// the browser is loaded and the user hasn't set their own.
        /// </summary>
        private string DefaultHomePage { get; } = "https://www.google.com";

        /// <summary>
        /// Insatiating Files and SessionHistory to access their properties. 
        /// </summary>
        SessionHistory session = new SessionHistory();
        Files file = new Files();

        /// <summary>
        /// homPage list holds the current set home page.
        /// sessionHistory holds all adresses searched during the current session.
        /// </summary>
        private List<Address> homePage = new List<Address>();
        private List<Address> sessionHistory = new List<Address>();
  
        public BrowserForm()
        {
            InitializeComponent();
            LoadHomePage();

            //calls the BrowserForm closing method which ensures Session History file 
            //is emptied before form is closed. 
            this.FormClosing += BrowserForm_FormClosing;
        }

        /// <summary>
        /// LoadHomePage method ensures that when the application is loaded,
        /// the latest home page url that has been saved is loaded and executed. 
        /// </summary>
        /// <param name="defaultHomePage"></param>
        public void LoadHomePage()
        {
            //object of defaullt home page created
            Address model = new Address();
            model.Url = DefaultHomePage;

            //url box filled with default home page
            URLBox.Text = DefaultHomePage;
            //CurrentSearch url and id set to default home page
            session.CurrentSearchUrl = DefaultHomePage;
            session.CurrentSearchId = model.Id;

            //homePage list populated from home page file.
            foreach (IFileConnection txtConnection in GlobalDataConnection.Connection)
            {
                homePage = txtConnection.GetAllAddresses(file.HomePageFile);
            }

            //if home page has at least one entry 
            if (homePage.Count > 0)
            {
                //populates url box with last item in file
                foreach (Address a in homePage)
                {
                     URLBox.Text = a.Url;
                     model.Url = URLBox.Text;
                }
            }
                session.CurrentSearchUrl = URLBox.Text;
                CreateAddress(model, file.HistoryFile);
                CreateAddress( model, file.SessionHistoryFile);
                sessionHistory.Add(model);
                HttpRequest(session.CurrentSearchUrl);
                //sets current search id to current home page object
                session.CurrentSearchId = model.Id;
                //sets the max id for session history to the curent home page objects Id
                session.MaxSessionHistory = model.Id;
        }

        /// <summary>
        /// When a URL is typed into the browser and the enter key is pressed,
        /// this method ensures that a HttpRequest is executed which renders the specified urls html
        /// and the adress is saved to the history file.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void URLBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return && !string.IsNullOrEmpty(URLBox.Text) && URLBox.Text.Contains("https://"))
            {
                session.CurrentSearchUrl = URLBox.Text;
                HttpRequest(session.CurrentSearchUrl);
                Address model = new Address();
                model.Url = URLBox.Text;
                string currSearch = URLBox.Text;
                CreateAddress(model, file.HistoryFile);
                CreateAddress(model, file.SessionHistoryFile);
                sessionHistory.Add(model);
                URLBox.Text = currSearch;
                //Current search Id  and max id updated to the address object just created
                session.CurrentSearchId = model.Id;
                session.MaxSessionHistory = model.Id;
            }
        }

      
        /// <summary>
        /// Provides a refresh functionality for urls. Also ensures if a user starts to delete some
        /// of the url from the text box or completely clears it and then hits refresh it will be 
        /// the last url searched which is held in the CurrentSearchUrl that will be executed with a http request.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RefreshButton_Click(object sender, EventArgs e)
        {
            //checks if whats in url box is same as current search url which is always tracked
                if (session.CurrentSearchUrl == URLBox.Text)
                {
                    HttpRequest(URLBox.Text);
                    Address model = new Address();
                    model.Url = URLBox.Text;
                    string currSearch = URLBox.Text;
                //a new address object is added to the history file as a http request was executed
                    CreateAddress(model, file.HistoryFile);
                    URLBox.Text = currSearch;
            }
                //if the current search url and text in the url box dont match
                if(session.CurrentSearchUrl != URLBox.Text)
                {
                    HttpRequest(session.CurrentSearchUrl);
                    Address model = new Address();
                //The current search url is used because that was the last http request to be made
                    model.Url = session.CurrentSearchUrl;
                    CreateAddress(model, file.HistoryFile);
                    URLBox.Text = session.CurrentSearchUrl;
            }
            }

        /// <summary>
        /// Provides  backwards navigation functionality. The start and end of the list is tracked
        /// and the current position is always know to enable this to work. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BackButton_Click(object sender, EventArgs e)
        {
            Address model = new Address();
            //sessionHistory list is passed in to BackButton method
            session.BackButton(sessionHistory);
            //provides the url for the http request and object to be added to history file
            model.Url = session.TempUrl;
            //populates url box with current search url
            URLBox.Text = session.CurrentSearchUrl;
            //ensures url is not empty to stop app crashing. 
            if (model.Url != null)
            {
                CreateAddress(model, file.HistoryFile);
                HttpRequest(model.Url);
            }
        }

      
        /// <summary>
        /// Provides forwards navigation functionality. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ForwardButton_Click(object sender, EventArgs e)
        {
            Address model = new Address();
            //sessionHistory list is passed in to ForwardButton method
            session.ForwardButton(sessionHistory);
            model.Url = session.TempUrl;
            URLBox.Text = session.CurrentSearchUrl;
            //ensures url has data
            if (model.Url != null)
            {
                CreateAddress(model, file.HistoryFile);
                HttpRequest(model.Url);
            }
        }

        /// <summary>
        /// Ensures that an address is added to the favourites files. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FavouriteButton_Click(object sender, EventArgs e)
        {
            Address model = new Address
            {
                Url = URLBox.Text
            };
           
            foreach (IFileConnection txtConnection in GlobalDataConnection.Connection)
            {
                txtConnection.CreateAddress(model,file.FavouriteFile);
            }
        }

        /// <summary>
        /// Opens the history manager form. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void HistoryManager_Click(object sender, EventArgs e)
        {
            HistoryForm history = new HistoryForm();
            //when the DataSent public event is fired from the HistoryForm it 
            //invokes the HistoryManager_DataSent method. 
            history.DataSent += HistoryManager_DataSent;
            history.ShowDialog();
        }

        /// <summary>
        /// Data from the history manager via an event is passed into this method which can
        /// then be used in the current browser form. 
        /// </summary>
        /// <param name="res"></param>
        /// <param name="url"></param>
        /// <param name="id"></param>
        private void HistoryManager_DataSent(String res, String url, int id)
        {
            HTMLBox.Text = res;
            URLBox.Text = url;
            session.CurrentSearchUrl = url;
            session.CurrentSearchId = id;
            ErrorCodeLabel.Text = "RESPONSE: " + HttpTool.StatusCode.ToString() +
                "     URL: " + url + "      ID: " + session.CurrentSearchId;
        }

        /// <summary>
        /// Opens the favourites manager form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
            private void FavouritesManager_Click(object sender, EventArgs e)
        {
            FavouriteForm favourite = new FavouriteForm();
            favourite.ShowDialog();
        }

        /// <summary>
        /// Opens the home page manager form. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void HomePageManager_Click(object sender, EventArgs e)
        {
            HomeForm home = new HomeForm();
            home.ShowDialog();
        }

        /// <summary>
        /// When a text file and list needs to be updated, this method is called.
        ///It connects to the specified text file and adds an address to the file
        ///It also updates the list, adding an address. 
        /// </summary>
        /// <param name="address"></param>
        /// <param name="model"></param>
        /// <param name="FileName"></param>
        public void CreateAddress(Address model, string FileName)
        {
            foreach (IFileConnection txtConnection in GlobalDataConnection.Connection)
            {
                txtConnection.CreateAddress(model, FileName);
            }
        }

        /// <summary>
        /// Allows a Http connection to be made and a Get request to be executed.
        /// Returns HTML as a response to be rendered to the browser form. 
        /// </summary>
        private async void HttpRequest(string Url)
        {
                if (Url.Contains("https://"))
                {
                    var response = await HttpTool.GetRequest(Url);
                    HTMLBox.Text = response;
                    ErrorCodeLabel.Text = "RESPONSE: " + HttpTool.StatusCode.ToString() +
                    "     URL: " + Url + "      ID: " + session.CurrentSearchId;
                }
        }


        /// <summary>
        /// Form Closing is an event that ensures when the browser is closed
        /// the session hsitory file is completely wiped and empty for 
        /// the next time the browser is loaded.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BrowserForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            foreach (IFileConnection txtConnection in GlobalDataConnection.Connection)
            {
                foreach(Address a in sessionHistory)
                txtConnection.DeleteAddress(a, file.SessionHistoryFile);
            }
        }
    }
}

