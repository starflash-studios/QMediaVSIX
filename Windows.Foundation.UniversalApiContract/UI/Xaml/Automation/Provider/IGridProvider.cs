// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Automation.Provider.IGridProvider
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Automation.Provider
{
  /// <summary>Exposes methods and properties to support access by a Microsoft UI Automation client to controls that act as containers for a collection of child elements. Implement this interface in order to support the capabilities that an automation client requests with a GetPattern call and PatternInterface.Grid.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(2338502560, 37676, 17552, 154, 19, 2, 253, 179, 154, 143, 91)]
  [WebHostHidden]
  public interface IGridProvider
  {
    /// <summary>Gets the total number of columns in a grid.</summary>
    /// <returns>The total number of columns in a grid.</returns>
    int ColumnCount { get; }

    /// <summary>Gets the total number of rows in a grid.</summary>
    /// <returns>The total number of rows in a grid.</returns>
    int RowCount { get; }

    /// <summary>Retrieves the UI Automation provider for the specified cell.</summary>
    /// <param name="row">The ordinal number of the row that contains the cell.</param>
    /// <param name="column">The ordinal number of the column that contains the cell.</param>
    /// <returns>The UI Automation provider for the specified cell.</returns>
    IRawElementProviderSimple GetItem(int row, int column);
  }
}
