// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Automation.Provider.ISpreadsheetProvider
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Automation.Provider
{
  /// <summary>Provides access to items (cells) in a spreadsheet.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  [Guid(355831955, 48537, 19709, 159, 7, 59, 20, 179, 21, 226, 61)]
  public interface ISpreadsheetProvider
  {
    /// <summary>Returns a Microsoft UI Automation element that represents the spreadsheet cell that has the specified name.</summary>
    /// <param name="name">The name of the target cell.</param>
    /// <returns>A Microsoft UI Automation element that represents the target cell.</returns>
    IRawElementProviderSimple GetItemByName(string name);
  }
}
