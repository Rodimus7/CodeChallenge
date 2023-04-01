using System;
using System.Collections.Generic;
using System.Net.Http;
using RSL.TheLott.Properties;
using System.Windows.Forms;
using Microsoft.AspNet.Scaffolding;
using System.Security.Policy;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace RSL.TheLott.Data.Jurisdiction
{
  /// <summary>
  /// Class <c>JurisdictionV1</c> Detail of a Jurisdiction.
  /// v1  Inital Version
  /// </summary>
  public class JursidictionV1
  {
    [JsonProperty("JurisdictionId")] public string JurisdictionId { get; set; }
    [JsonProperty("DisplayName")] public string DisplayName { get; set; }
    [JsonProperty("CanRegister")] public bool CanRegister { get; set; }
    [JsonProperty("Country")] public string Country { get; set; }
    [JsonProperty("PhoneCode")] public string PhoneCode { get; set; }
    [JsonProperty("State")] public string State { get; set; }
  }
  internal class JurisdictionsResponse { 
    public List<JursidictionV1> Jurisdictions { get; set; }
    public object ErrorInfo { get; set; }
    public bool Success { get; set; }
  }
  internal class Jurisdictions
  {
    private JurisdictionsResponse jurisdictionsData; 
    private JurisdictionsResponse lottoJurisdictionsData;

    public List<JursidictionV1> jurisdictions
    {
      get
      {
        if (jurisdictionsData.Jurisdictions.Count == 0)
        {
          GetJurisdictions();
        }

        return jurisdictionsData.Jurisdictions;
      }
    }
    public List<JursidictionV1> lottoJurisdictions
    { 
      get 
      {
        if (lottoJurisdictionsData.Jurisdictions.Count == 0)
          GetLottoJurisdictions();

        return lottoJurisdictionsData.Jurisdictions;
      } 
    }
    

    /// <summary>
    /// Jurisdictions Data contstructor.
    /// </summary>
    public Jurisdictions()
    {
      try
      {
        //List<JursidictionV1> jurisdictions = new List<JursidictionV1>();
        jurisdictionsData = new JurisdictionsResponse();
        lottoJurisdictionsData = new JurisdictionsResponse();

        GetJurisdictions();
        GetLottoJurisdictions();
      }
      catch (Exception)
      {
        //Call the Corporate Standard Erorr Routines
        throw;
      }
    }


    public HttpResponseMessage RetrieveJurisdictions(string pJurisdictionURL)
    {
      try
      {
        string jurisdictionURL = Resources.ResourceManager.GetString("baseTheLottURL") + pJurisdictionURL;
        UriBuilder getJurisdictionURI = new UriBuilder(jurisdictionURL);

        HttpClient client = new HttpClient(new HttpClientHandler { UseDefaultCredentials = true }) { BaseAddress = getJurisdictionURI.Uri };
        client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

        // Make an API call and receive HttpResponseMessage
        HttpResponseMessage responseMessage = client.GetAsync(jurisdictionURL, HttpCompletionOption.ResponseContentRead).GetAwaiter().GetResult();

        return responseMessage;
      }
      catch (Exception ex)
      {

        throw;
      }
    }

    #region Jurisdictions
    private void GetJurisdictions()
    {
      // Execute Api call
      var httpResponseMessage = RetrieveJurisdictions("jurisdictions");

      // Process Json string result to fetch final deserialized model
      PopulateJursidictions(httpResponseMessage);
    }
    public void PopulateJursidictions(HttpResponseMessage pResult)
    {
      try
      {
        if (pResult.IsSuccessStatusCode)
        {
          string resultArray = pResult.Content.ReadAsStringAsync().GetAwaiter().GetResult();// Convert the HttpResponseMessage to string

          jurisdictionsData = JsonConvert.DeserializeObject<JurisdictionsResponse>(resultArray);
        }
      }
      catch (Exception)
      {

        throw;
      }
    }
    #endregion

    #region Lotto Jurisdictions
    private void GetLottoJurisdictions()
    {
      // Execute Api call
      var httpResponseMessage = RetrieveJurisdictions("lotteriesjurisdictions");

      // Process Json string result to fetch final deserialized model
      PopulateLottoJursidictions(httpResponseMessage);
    }
    public void PopulateLottoJursidictions(HttpResponseMessage pResult)
    {
      try
      {
        if (pResult.IsSuccessStatusCode)
        {
          string resultArray = pResult.Content.ReadAsStringAsync().GetAwaiter().GetResult();// Convert the HttpResponseMessage to string

          lottoJurisdictionsData = JsonConvert.DeserializeObject<JurisdictionsResponse>(resultArray);
        }
      }
      catch (Exception)
      {

        throw;
      }
    }
    #endregion
  }
}


