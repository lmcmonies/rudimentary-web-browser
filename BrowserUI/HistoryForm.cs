using BrowserLibrary;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BrowserUI
{
    /// <summary>
    /// A delegate is declared with parameters for the information to be sent. 
    /// </summary>
    /// <param name="res"></param>
    /// <param name="url"></param>
    /// <param name="id"></param>
    public delegate void DataHandler(String res, String url, int id);
    public partial class HistoryForm : Form
    {
        Files file = new Files();
        private List<Address> history = new List<Address>();
        private List<Address> sessionHistory = new List<Address>();

        /// <summary>
        /// DataSent is an event based on the delegate that is executed when
        /// searching a session history. It's parameters are defined in the delegate.
        /// </summary>
        public event DataHandler DataSent;

        public HistoryForm()
        {
            InitializeComponent();
            LoadData();
            DisplayHistory();
            DisplaySessionHistory();
        }

        /// <summary>
        /// Loads data from files into the history and session history lists
        /// </summary>
        private void LoadData()
        {
            foreach (IFileConnection connection in GlobalDataConnection.Connection)
            {
                history = connection.GetAllAddresses(file.HistoryFile);
                sessionHistory = connection.GetAllAddresses(file.SessionHistoryFile);
            }
        }

        /// <summary>
        /// Displays the data held in history list in the history list box.
        /// </summary>
        public void DisplayHistory()
        {
            if (history != null)
            {
                HistoryBox.DataSource = history;
                HistoryBox.DisplayMember = "DisplayAddress";
            }
        }

        /// <summary>
        /// Displays the data held in session history list in the session history
        /// list box.
        /// </summary>
        public void DisplaySessionHistory()
        {
            if (history != null)
            {
                SessionHistoryBox.DataSource = sessionHistory;
                SessionHistoryBox.DisplayMember = "DisplayAddress";
            }
        }

        /// <summary>
        /// Executes a http GET request on the history list box item. 
        /// Opens the HistoryForm2 form and send the http response data 
        /// through the constructor to be displayed. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void HistorySearch_Click(object sender, EventArgs e)
        {
            if (HistoryBox.Items.Count > 0)
            {
                Address model = (Address)HistoryBox.SelectedItem;
                var url = model.Url;
                var res = await HttpTool.GetRequest(url);
                HistoryForm2 historyForm2 = new HistoryForm2(res,url);
                historyForm2.ShowDialog();
                CreateAddress(history, model, file.HistoryFile);
            }
            LoadData();
            DisplayHistory();
        }

        /// <summary>
        /// Creates a new address object in a specified file. 
        /// </summary>
        /// <param name="address"></param>
        /// <param name="model"></param>
        /// <param name="FileName"></param>
        public void CreateAddress(List<Address> address, Address model, string FileName)
        {
            foreach (IFileConnection txtConnection in GlobalDataConnection.Connection)
            {
                txtConnection.CreateAddress(model, FileName);
                address.Add(model);
            }
        }

        /// <summary>
        /// Creates an object and saves it to the favourites file based
        /// on the all time history list box item currently selected.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FavouriteButton_Click(object sender, EventArgs e)
        {
            Address model = (Address)HistoryBox.SelectedItem;
            foreach(IFileConnection txtConnection in GlobalDataConnection.Connection)
            {
                txtConnection.CreateAddress(model,file.FavouriteFile);
            }
        }

        /// <summary>
        /// Creates an object and saves it to the favourites file based 
        /// on the session history list box item currently selected. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SessionFavourite_Click(object sender, EventArgs e)
        {
            Address model = (Address)SessionHistoryBox.SelectedItem;
            foreach (IFileConnection txtConnection in GlobalDataConnection.Connection)
            {
                txtConnection.CreateAddress(model, file.FavouriteFile);
            }
        }

        /// <summary>
        /// Allows the user to execute a http GET request on the selected
        /// session history list box item. The DataSent event is fired 
        /// and the data is sent back to the BrowserForm where it can be displayed. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void SessionSearch_Click(object sender, EventArgs e)
        {
            if (SessionHistoryBox.Items.Count > 0)
            {
                Address model = (Address)SessionHistoryBox.SelectedItem;
                var url = model.Url;
                var id = model.Id;
                var res = await HttpTool.GetRequest(url);
                CreateAddress(history, model, file.HistoryFile);
                this.DataSent(res, url, id);
                this.Close();
            }
        }
    }
}
