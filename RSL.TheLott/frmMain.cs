using RSL.TheLott.Data.Company;
using RSL.TheLott.Data.Draws;
using RSL.TheLott.Data.Jurisdiction;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//***********************************************************************************************
//  Class:        frmMain
//  Purpose:      GUI to find Open Draws.
//  Depenencies:  None
//***********************************************************************************************
// Ticket      Date         Author      Change
//-----------------------------------------------------------------------------------------------
//             15/03/2023   G.Jones     Initial Version
//***********************************************************************************************
namespace RSL.TheLott
{
  public partial class frmMain : Form
  {
    public frmMain()
    {
      InitializeComponent();
    }

    private Jurisdictions jurisdictionsAll;
    private OpenDraws openDraws;
    private Companies companies;
    private void LoadSeedData()
    {
      try
      {
        jurisdictionsAll = new Jurisdictions();
        companies = new Companies();

        grdJurisdictions.DataSource = jurisdictionsAll.jurisdictions;
        grdLottoJurisdictions.DataSource = jurisdictionsAll.lottoJurisdictions;

        cbxCompany.DataSource = companies.companies;
        cbxCompany.ValueMember = "CompanyId";
        cbxCompany.DisplayMember = "CompanyDisplayName";

        openDraws = new OpenDraws();
      }
      catch (Exception ex)
      {
        //Call Corporate Standard Error Logging
        throw;
      }

    }

    private void FrmMain_Load(object sender, EventArgs e)
    {
      try
      {
        LoadSeedData();
        UpdateStatus();

        UpdateStatus();
      }
      catch (Exception ex)
      {
        //Call Corporate Standard Error Logging
        throw;
      }
    }

    private void UpdateStatus()
    {
      try
      {
        sblStatus.Text = "";

        if (cbxCompany.SelectedItem == null)
          sblStatus.Text = "Please select which Lotto Company to find Open Draws.";
        else
          if (clbProducts.SelectedItems.Count == 0)
          sblStatus.Text = "You can refine which Lotto draws to find by Product.";

        btnFindOpenDraws.Enabled = cbxCompany.SelectedItem != null;
      }
      catch (Exception ex)
      {
        //Call Corporate Standard Error Logging
      }
    }

    private void btnFindOpenDraws_Click(object sender, EventArgs e)
    {
      try
      {
        List<string> optionalProducts = new List<string>();

        sblStatus.Text = "Please wait.  Looking for Open Draws.";

        try
        {
          foreach (string selectedProduct in clbProducts.SelectedItems)
            foreach (CompanyProductV1 companyProduct in ((LotteriesCompanyProductsV1)cbxCompany.SelectedItem).Products)
              if (selectedProduct == (companyProduct.FullProductName + '(' + companyProduct.ShortProductName + ')'))
                optionalProducts.Add(companyProduct.ProductId);

          openDraws.GetTheOpenDraws(((LotteriesCompanyProductsV1)cbxCompany.SelectedItem).CompanyId, (int)numMaxDraws.Value, optionalProducts.ToArray());

          grdOpenDraws.DataSource = openDraws.theOpenDraws;
        }
        finally
        {
          optionalProducts.Clear();
          UpdateStatus();
        }
      }
      catch (Exception ex)
      {
        //Call Corporate Standard Error Logging
      }
    }

    private void cbxCompany_SelectedIndexChanged(object sender, EventArgs e)
    {
      try
      {
        clbProducts.Items.Clear();

        foreach (CompanyProductV1 companyProduct in ((LotteriesCompanyProductsV1)cbxCompany.SelectedItem).Products)
          clbProducts.Items.Add(companyProduct.FullProductName + '(' + companyProduct.ShortProductName + ')');

        UpdateStatus();
      }
      catch (Exception ex)
      {
        //Call Corporate Standard Error Logging
        throw;
      }
    }
  }
}