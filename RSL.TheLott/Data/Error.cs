using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//***********************************************************************************************
//  Class:        Error
//  Purpose:      Tatts Service Error Info Class.
//  Depenencies:  None
//***********************************************************************************************
// Ticket      Date         Author      Change
//-----------------------------------------------------------------------------------------------
//             15/03/2023   G.Jones     Initial Version
//***********************************************************************************************
namespace RSL.TheLott.Data
{
  public struct TattsSvcErrorInfo
  {
    Int32 SystemId;
    Int32 ErrorNo;
    String DisplayMessage;
    bool ContactSupport;
    String SupportErrorReference;
  }
  internal class Error
  {
  }
}
