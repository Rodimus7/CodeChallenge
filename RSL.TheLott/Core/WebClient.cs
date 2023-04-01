using RSL.TheLott.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
//***********************************************************************************************
//  Class:        Web Client
//  Purpose:      Generic class to make calls to the Tatts APIs.
//  Depenencies:  None
//***********************************************************************************************
// Ticket      Date         Author      Change
//-----------------------------------------------------------------------------------------------
//             15/03/2023   G.Jones     Initial Version
//***********************************************************************************************
namespace RSL.TheLott.Core
{
  public class WebClient
  {
    public HttpResponseMessage Get(string pGetMethod)
    {
      try
      {
        string methodURL = Resources.ResourceManager.GetString("baseTattsURL") + pGetMethod;
        UriBuilder getURI = new UriBuilder(methodURL);
        //https://api.tatts.com/svc/sales/vmax/web/data/lotto/companies
        HttpClient client = new HttpClient(new HttpClientHandler { UseDefaultCredentials = true }) { BaseAddress = getURI.Uri };
        client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

        // Make an API call and receive HttpResponseMessage
        HttpResponseMessage responseMessage = client.GetAsync(methodURL, HttpCompletionOption.ResponseContentRead).GetAwaiter().GetResult();

        return responseMessage;
      }
      catch (Exception ex)
      {
        //Call Corporate Standard Error Logger
        throw;
      }
    }
  }
}
