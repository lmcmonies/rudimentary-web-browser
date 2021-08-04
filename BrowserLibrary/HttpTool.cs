
using System;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;

namespace BrowserLibrary
{
    /// <summary>
    /// HttpTool provides the browser application with a way to execute Http GET requests.
    /// One instance of the HttpClient is defined here and reused throughought the application. 
    /// </summary>
    public static class HttpTool
    {
        public static int StatusCode { get; set; }

        static readonly HttpClient httpClient = new HttpClient();

        /// <summary>
        /// GetRequest takes in a string which is a url from the GUI. 
        /// It performs GET requests and returns response data to the GUI 
        /// for display purposes. It performs them asynchronously. 
        /// </summary>
        /// <param name="url"></param>
        /// <returns></returns>
        public static async Task<string> GetRequest(string url)
        {
            try
            {
                //The asynchronous http request which is stored in response. 
                HttpResponseMessage response = await httpClient.GetAsync(url);
                //status code is cast to an int and stored
                StatusCode = (int)response.StatusCode;
                response.EnsureSuccessStatusCode();
                if (response.IsSuccessStatusCode)
                {
                    //response content is stored in content
                    HttpContent content = response.Content;
                    //ensures content is serealised to string format so it can be used
                    string data = await content.ReadAsStringAsync();
                    //ensures there is data
                    if (data != null)
                    {
                        //returns the data back to the GUI where the request was executed for display.
                        return data;
                    }
                }
            }
            catch (HttpRequestException e)
            {
               
                Console.WriteLine("\nException Caught!");
                Console.WriteLine("Message :{0} ", e.Message);
            }
            catch (WebException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (ArgumentNullException e)
            {
               Console.WriteLine(e.Message);
            }
            catch(TaskCanceledException e)
            {
                Console.WriteLine(e.Message);
            }
            catch(InvalidOperationException e)
            {
                Console.WriteLine(e);
            }
            catch (UriFormatException e)
            {
                Console.WriteLine(e);
            }
            return string.Empty;
        }
    }
}
