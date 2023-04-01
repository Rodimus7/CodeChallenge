using RSL.TheLott;
using RSL.TheLott.Data.Draws;
//***********************************************************************************************
//  Class:        openDrawsTest
//  Purpose:      Test Scenarios.
//  Depenencies:  None
//***********************************************************************************************
// Ticket      Date         Author      Change
//-----------------------------------------------------------------------------------------------
//             15/03/2023   G.Jones     Initial Version
//***********************************************************************************************
namespace TheLott.Test
{
  [TestClass]
  public class openDrawsTest
  {


    [TestMethod]
    public void SuccessWithOptionalProducts()
    {
      OpenDraws openDraws = new OpenDraws();

      openDraws.GetTheOpenDraws("GoldenCasket", 20, new[] { "TattsLotto", "MonWedLotto", "OzLotto", "MonWedLotto", "Powerball", "Super66" });

      var results = openDraws.theOpenDraws;

      // Assert
      Assert.IsTrue(openDraws.success);
    }


    [TestMethod]
    public void SuccessWithNoOptionalProducts()
    {

      OpenDraws openDraws = new OpenDraws();

      openDraws.GetTheOpenDraws("Tattersalls", 1, new string[] { });

      var results = openDraws.theOpenDraws;

      // Assert
      Assert.IsTrue(openDraws.success);
    }

    //TODO
    //Invalid Company
    //Invalid Product for a Company
    //No Company
  }
}