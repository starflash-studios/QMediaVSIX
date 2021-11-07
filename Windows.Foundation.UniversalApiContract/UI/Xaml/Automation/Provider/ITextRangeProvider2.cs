// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Automation.Provider.ITextRangeProvider2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Automation.Provider
{
  /// <summary>Extends the ITextRange interface to enable Microsoft UI Automation providers to programmatically open context menus that are contextual to text input operations.</summary>
  [WebHostHidden]
  [Guid(3552460283, 40788, 17986, 167, 165, 92, 24, 213, 238, 42, 63)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public interface ITextRangeProvider2 : ITextRangeProvider
  {
    /// <summary>Shows the available context menu for the owner element.</summary>
    void ShowContextMenu();
  }
}
