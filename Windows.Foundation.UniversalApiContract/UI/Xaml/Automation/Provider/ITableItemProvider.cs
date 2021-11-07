// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Automation.Provider.ITableItemProvider
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Automation.Provider
{
  /// <summary>Exposes methods and properties to support Microsoft UI Automation client access to child controls of containers that implement ITableProvider. Implement this interface in order to support the capabilities that an automation client requests with a GetPattern call and PatternInterface.TableItem.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(992758221, 7650, 20194, 163, 225, 251, 85, 53, 89, 209, 93)]
  [WebHostHidden]
  public interface ITableItemProvider
  {
    /// <summary>Retrieves an array of UI Automation providers representing all the column headers associated with a table item or cell.</summary>
    /// <returns>An array of UI Automation providers.</returns>
    IRawElementProviderSimple[] GetColumnHeaderItems();

    /// <summary>Retrieves an array of UI Automation providers representing all the row headers associated with a table item or cell.</summary>
    /// <returns>An array of UI Automation providers.</returns>
    IRawElementProviderSimple[] GetRowHeaderItems();
  }
}
