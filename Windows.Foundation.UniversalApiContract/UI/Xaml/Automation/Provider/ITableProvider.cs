// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Automation.Provider.ITableProvider
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Automation.Provider
{
  /// <summary>Exposes methods and properties to support access by a Microsoft UI Automation client to controls that act as containers for a collection of child elements. The children of this element must implement ITableItemProvider and be organized in a two-dimensional logical coordinate system that can be traversed (a Microsoft UI Automation client can move to adjacent controls, which are headers or cells of the table) by using the keyboard.</summary>
  [WebHostHidden]
  [Guid(2056180633, 26660, 17813, 186, 179, 70, 75, 201, 160, 68, 23)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public interface ITableProvider
  {
    /// <summary>Gets the primary direction of traversal for the table.</summary>
    /// <returns>The primary direction of traversal, as a value of the enumeration.</returns>
    RowOrColumnMajor RowOrColumnMajor { get; }

    /// <summary>Returns a collection of UI Automation providers that represents all the column headers in a table.</summary>
    /// <returns>An array of UI Automation providers.</returns>
    IRawElementProviderSimple[] GetColumnHeaders();

    /// <summary>Returns a collection of UI Automation providers that represents all row headers in the table.</summary>
    /// <returns>An array of UI Automation providers.</returns>
    IRawElementProviderSimple[] GetRowHeaders();
  }
}
