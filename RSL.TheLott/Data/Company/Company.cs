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
using RSL.TheLott.Core;
using System.Net;
//***********************************************************************************************
//  Class:        Company
//  Purpose:      Calls APIs to call, parse and return Company details, including Products.
//  Depenencies:  None
//***********************************************************************************************
// Ticket      Date         Author      Change
//-----------------------------------------------------------------------------------------------
//             15/03/2023   G.Jones     Initial Version
//***********************************************************************************************
namespace RSL.TheLott.Data.Company
{
  /// <summary>
  /// Class <c>Lotteries Company ProductsV1</c> Details of a Company, including products.
  /// v1  Inital Version
  /// </summary>
  public class LotteriesCompanyProductsV1
  {
    [JsonProperty("CompanyId")] public string CompanyId { get; set; }
    [JsonProperty("CompanyDisplayName")] public string CompanyDisplayName { get; set; }
    [JsonProperty("CompanyDescription")] public string CompanyDescription { get; set; }
    [JsonProperty("CompanyLogoUrl")] public string CompanyLogoUrl { get; set; }

    public List<CompanyProductV1> Products { get; set; }
  }
  public class CompanyProductV1
  {
    public string ProductId { get; set; }
    public string FullProductName { get; set; }
    public string LongProductName { get; set; }
    public string ShortProductName { get; set; }
    public string AbbreviatedName { get; set; }
    public string MicroName { get; set; }
    public string ProductLogoUrl { get; set; }
    public string ProductClass { get; set; }
    public string ProductStatus { get; set; }
  }
  internal class CompaniesResponse
  {
    public List<LotteriesCompanyProductsV1> Companies { get; set; }
    public object ErrorInfo { get; set; }
    public bool Success { get; set; }
  }
  internal class CompanyProductResponse
  {
    public List<CompanyProductV1> CompanyProducts { get; set; }
    public object ErrorInfo { get; set; }
    public bool Success { get; set; }
  }
  internal class Companies
  {
    private CompaniesResponse companiesData;
    private CompanyProductResponse companyProductsData;
    private RSL.TheLott.Core.WebClient webClient;

    public List<LotteriesCompanyProductsV1> companies
    {
      get
      {
        if (companiesData.Companies.Count == 0)
        {
          GetLottoCompanies();
        }

        return companiesData.Companies;
      }
    }
  
    /// <summary>
    /// Companies Data contstructor.
    /// </summary>
    public Companies()
    {
      try
      {
        companiesData = new CompaniesResponse();
        webClient = new Core.WebClient();

        GetLottoCompanies();
      }
      catch (Exception)
      {
        //Call the Corporate Standard Erorr Routines
        throw;
      }
    }

    #region Lott Companies
    private void GetLottoCompanies()
    {
      try
      {
        // Execute Api call
        var httpResponseMessage = webClient.Get("companyproducts");

        // Process Json string result to fetch final deserialized model
        PopulateLottoCompanies(httpResponseMessage);
      }
      catch (System.Exception ex)
      {
        //todo: log error here
        throw;
      }
    }
    public void PopulateLottoCompanies(HttpResponseMessage pResult)
    {
      try
      {
        if (pResult.IsSuccessStatusCode)
        {
          string resultArray = pResult.Content.ReadAsStringAsync().GetAwaiter().GetResult();// Convert the HttpResponseMessage to string

          companiesData = JsonConvert.DeserializeObject<CompaniesResponse>(resultArray);
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


