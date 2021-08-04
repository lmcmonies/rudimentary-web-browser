
using System.Collections.Generic;

namespace BrowserLibrary
{
    /// <summary>
    /// SessionHistory provides several properties and methods that are used for managing the session history in the browser form
    /// and tracking key values.
    /// </summary>
    public class SessionHistory
    {
        /// <summary>
        /// MinSessionHistory stores the minimum Id for the session history.
        /// It is hard coded as 1 as every for every session, the session hsitory
        /// starts at 1 with the first item being the home page. It ensures that the start
        /// of the list is known and available. 
        /// </summary>
        public int MinSessionHistory { get; set; } = 1;

        /// <summary>
        /// The MaxSessionHistory stores the Id of the most recent item thats been stored in the 
        /// session history file and list. It is initalised to 0 but it increments by 1 each time 
        /// a new item is added to the session history, always ensuring the location of the
        /// end of the list is known and available.
        /// </summary>
        public int MaxSessionHistory { get; set; } = 0;

        /// <summary>
        /// CurrentSearchUrl stores the url of the most recent searched address object.
        /// It has several uses but a notable one is in the refresh method of the browser 
        /// form where it is used to compare the most recently searched Url with whats currently in 
        /// the URLTextBox. 
        /// </summary>
        public string CurrentSearchUrl { get; set; }

        /// <summary>
        /// CurrentSearchId stores the Id of the most recent searched address object.
        /// Used extensively in the navigational buttons in the browser form for 
        /// comparing Ids of saved address objects to the Id of the most recently 
        /// searched address object. 
        /// </summary>
        public int CurrentSearchId { get; set; }

        /// <summary>
        /// NextSearchId provides a  property for holding the Id number of the next target Id 
        /// for navigating forward. If the current Id is 5, then NextSearchId will be 6. 
        /// </summary>
        public int NextSearchId { get; set; }

        /// <summary>
        /// PreviousSearchId provides a property for holidng the Id number of the next trarget Id for
        /// navigating backwards. If we are currently at Id 5 then PreviousSearchId would be set at 4 
        /// which allows us to get back to 4. 
        /// </summary>
        public int PreviousSearchId { get; set; }

        /// <summary>
        /// A temp url used in the forward and back buttons. 
        /// </summary>
        public string TempUrl { get; set; }

        /// <summary>
        /// Empty constructor for instantiating the class in the GUI for accessing it's properties.
        /// </summary>
        public SessionHistory()
        {

        }
        
        /// <summary>
        /// The BackButton is used by the BackButton_Click method in the BrowserForm class.
        /// </summary>
        /// <param name="sessionHistory"></param>
        public void BackButton(List<Address> sessionHistory)
        {
            //loops through all addresses in session history list
            foreach (Address a in sessionHistory)
            {
                //if current object id is same as current search id and greater than the minimum session history int
                if (a.Id == this.CurrentSearchId && a.Id > this.MinSessionHistory)
                {
                    //previous search id holds the value of id we want to navigate back to
                    this.PreviousSearchId = this.CurrentSearchId - 1;
                    this.CurrentSearchId = this.PreviousSearchId;
                    //loops through session history list again
                    foreach (Address b in sessionHistory)
                    {
                        //now checks if previous search id is equal to any of the objects id in the session history lists 
                        if (this.PreviousSearchId == b.Id)
                        {
                            //the matching objects url is assigned to url string defined at the start
                            this.TempUrl = b.Url;
                            //currentsearchurl also assigned with it.
                            this.CurrentSearchUrl = b.Url;
                        }
                    }
                }
            }
        }
        /// <summary>
        /// The ForwardButton is used by the ForwardButton_Click method in the BrowserForm class.
        /// </summary>
        /// <param name="sessionHistory"></param>
        public void ForwardButton(List<Address> sessionHistory)
        {
            //loops through session history list
            foreach (Address a in sessionHistory)
            {
                //checks if current object id equal to current search id and less than Max session int
                if (a.Id == this.CurrentSearchId && a.Id < this.MaxSessionHistory)
                {
                    //next id value is always the current search id + 1
                    this.NextSearchId = this.CurrentSearchId + 1;
                    //loops through session history list again
                    foreach (Address b in sessionHistory)
                    {
                        //locates the object id that matches with the next search id where we want to get to
                        if (this.NextSearchId == b.Id)
                        {
                            //url assigned with that objects url for use in http request and history object creation
                            this.TempUrl = b.Url;
                            this.CurrentSearchUrl = b.Url;
                        }
                    }
                }
            }
            //ensures ned search id has a value great than 0
            if (this.NextSearchId > 0)
            {
                //current search id now becomes the same as next search id
                this.CurrentSearchId = this.NextSearchId;
            }
        }
    }
}

