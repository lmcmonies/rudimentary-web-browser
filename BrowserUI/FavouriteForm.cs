using BrowserLibrary;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BrowserUI
{
    public partial class FavouriteForm : Form
    {
        /// <summary>
        /// File class instantiated for access to its properties. 
        /// </summary>
        Files file = new Files();

        /// <summary>
        /// favourites list for holding all favourites loaded from the favourites file. 
        /// </summary>
        private List<Address> favourites = new List<Address>();
       
        public FavouriteForm()
        {
            InitializeComponent();
            URLBox.Text = "https://";
            LoadData();
            DisplayFavourites();
        }

        /// <summary>
        /// Enables data to be loaded from the favourites file. 
        /// Saves the data to the favourites list. 
        /// </summary>
        private void LoadData()
        {
            foreach (IFileConnection txtConnection in GlobalDataConnection.Connection)
            {
                favourites = txtConnection.GetAllAddresses(file.FavouriteFile);
            }
        }

        /// <summary>
        /// Displays all favourites held in favourites in the favourites list box
        /// based on the DisplayAddressExt format defined in the Address class.
        /// </summary>
        public void DisplayFavourites()
        {
            if (favourites != null)
            {
                FavouriteBox.DataSource = favourites;
                FavouriteBox.DisplayMember = "DisplayAddressExt";
            }
        }

        /// <summary>
        /// Allows a user to add a favourite to the list of favourites. 
        /// Also provides functionality for the editing process. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddButton_Click(object sender, EventArgs e)
        {
            if (CheckForm())
            {
                Address model = new Address
                {
                    Name = NameBox.Text,
                    Url = URLBox.Text
                };
                LoadData();

                foreach(Address a in favourites)
                {
                    if (model.Url == a.Url)
                    {
                        foreach (IFileConnection txtConnection in GlobalDataConnection.Connection)
                        {
                        txtConnection.DeleteAddress(a, file.FavouriteFile);
                        }
                    }
                }
             
                foreach (IFileConnection txtConnection in GlobalDataConnection.Connection)
                {
                    txtConnection.CreateAddress(model,file.FavouriteFile);
                    favourites.Add(model);
                    LoadData();
                    DisplayFavourites();
                }
                NameBox.Text = "";
                URLBox.Text = "https://";
            }
            else
            {
                MessageBox.Show("Invalid Information Supplied");
            }
        }

        /// <summary>
        /// Provides checks for the favourites form
        /// </summary>
        /// <returns></returns>
        private bool CheckForm()
        {
            //Ensures user inputs a name
            bool result = true;
            if (NameBox.Text.Length == 0)
            {
                result = false;
            }

            //ensures user inputs a url and it includes https://
            if (URLBox.Text.Length == 0 || !URLBox.Text.Contains("https://"))
            {
                result = false;
            }
            return result;
        }

        /// <summary>
        /// Allows a user to delete a selected list box favourite. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DeleteButton_Click(object sender, EventArgs e)
        {
            Address favourite = (Address)FavouriteBox.SelectedItem;
            if (favourite != null)
            {
                foreach (IFileConnection txtConnection in GlobalDataConnection.Connection) 
                {
                    txtConnection.DeleteAddress(favourite,file.FavouriteFile);
                }
            }
            LoadData();
            DisplayFavourites();
        }

        /// <summary>
        /// Allows user to edit a selected list box item by passing the data
        /// to the form where it can be modified and saved to file. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EditButton_Click(object sender, EventArgs e)
        {
            if (FavouriteBox.SelectedIndex != -1)
            {
                Address favourite = (Address)FavouriteBox.SelectedItem;
                if (favourite != null)
                { 
                    NameBox.Text = favourite.Name;
                    URLBox.Text = favourite.Url;
                    LoadData();
                    DisplayFavourites();
                }
                else
                {
                    MessageBox.Show("You have not selected an item");
                }
            }
        }

        /// <summary>
        /// Allows the user to execute a http GET request on a selected favourites list box item
        /// Send the data via the constructor to FavouritesForm2 to be displayed. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void SearchButton_Click(object sender, EventArgs e)
        {
            if (FavouriteBox.Items.Count > 0)
            {
                Address model = (Address)FavouriteBox.SelectedItem;
                var url = model.Url;
                var res = await HttpTool.GetRequest(url);
                FavouriteForm2 favouriteForm2 = new FavouriteForm2(res, url);
                favouriteForm2.ShowDialog();
                foreach (IFileConnection txtConnection in GlobalDataConnection.Connection)
                {
                    txtConnection.CreateAddress(model, file.HistoryFile);
                }
                LoadData();
                DisplayFavourites();
            }
            else
            {
                MessageBox.Show("No Favourites Found");
            }
        }
    }
}
