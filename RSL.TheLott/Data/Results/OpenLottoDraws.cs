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
using System.Linq;
using System.IO;
//***********************************************************************************************
//  Class:        OpenLottoDraws
//  Purpose:      Calls APIs to call, parse and return Open Draw information.
//  Depenencies:  None
//***********************************************************************************************
// Ticket      Date         Author      Change
//-----------------------------------------------------------------------------------------------
//             15/03/2023   G.Jones     Initial Version
//***********************************************************************************************
namespace RSL.TheLott.Data.Draws
{
  public class OpenDraws
  {
    public class Draw
    {
      public string ProductId { get; set; }
      public int DrawNumber { get; set; }
      public string DrawDisplayName { get; set; }
      public DateTime DrawDate { get; set; }
      public string DrawLogoUrl { get; set; }
      public string DrawType { get; set; }
      public double Div1Amount { get; set; }
      public bool IsDiv1Estimated { get; set; }
      public bool IsDiv1Unknown { get; set; }
      public DateTime DrawCloseDateTimeUTC { get; set; }
      public DateTime DrawEndSellDateTimeUTC { get; set; }
      public double DrawCountDownTimerSeconds { get; set; }
      public string DaysOfWeek { get; set; }
      public double PrizeBoostPercent { get; set; }
      public double PrizeBoost { get; set; }
    }

    internal class OpenDrawsResponse
    {
      public List<Draw> Draws { get; set; }
      public object ErrorInfo { get; set; }
      public bool Success { get; set; }
    }
    internal class OpenDrawsRequest
    {
      public string CompanyId { get; set; }

      public int MaxDrawCount { get; set; }

      public string[] OptionalProductFilter { get; set; }
    }

    internal OpenDrawsResponse openDrawsData;
    public List<Draw> theOpenDraws { get { return openDrawsData.Draws; } }
    public object errorInfo { get { return openDrawsData.ErrorInfo; } }
    public bool success { get { return openDrawsData.Success; } }
    internal async Task<OpenDrawsResponse> GetOpenDraws(string pCompanyId, int pMaxDrawCount, string[] pProductFilters)
    {
      try
      {
        return await RetrieveOpen<OpenDrawsResponse>(pCompanyId, pMaxDrawCount, pProductFilters).ConfigureAwait(false);
      }
      catch (System.Exception ex)
      {
        //todo: log error here
        throw;
      }
    }

    internal async Task<OpenDrawsResponse> RetrieveOpen<OpenDrawsResponse>(string pCompanyId, int pMaxDrawCount, string[] pProductFilters)
    {
      try
      {
        string openDrawsURL = Resources.ResourceManager.GetString("baseTheLottURL") + "lotto/opendraws";
        UriBuilder openDrawsURI = new UriBuilder(openDrawsURL);

        HttpClient _httpClient = new HttpClient()
        {
          BaseAddress = openDrawsURI.Uri
        };

        var drawRequest = new OpenDrawsRequest()
        {
          CompanyId = pCompanyId,
          MaxDrawCount = pMaxDrawCount,
          OptionalProductFilter = pProductFilters
        };

        var myContent = JsonConvert.SerializeObject(drawRequest);

        var buffer = System.Text.Encoding.UTF8.GetBytes(myContent);
        var byteContent = new ByteArrayContent(buffer);

        var response = await _httpClient.PostAsync(openDrawsURL, byteContent).ConfigureAwait(false);

        if (response.IsSuccessStatusCode == true)
        {
          var json = await response.Content.ReadAsStringAsync();

          openDrawsData = JsonConvert.DeserializeObject<OpenDraws.OpenDrawsResponse>(json);
          return JsonConvert.DeserializeObject<OpenDrawsResponse>(json);
        }
        else
        {
          // log response
          return default(OpenDrawsResponse);
        }

      }
      catch (System.Exception ex)
      {
        //todo: log error here
        throw;
      }
    }

    public void GetTheOpenDraws(string pCompanyId, int pMaxDrawCount, string[] pProductFilters)
    {
      try
      {
        GetOpenDraws(pCompanyId, pMaxDrawCount, pProductFilters).Result?.Draws.ToList();
      }
      catch (System.Exception ex)
      {
        //todo: log error here
        throw;
      }
    }
    public OpenDraws()
    {
    }
  }
}