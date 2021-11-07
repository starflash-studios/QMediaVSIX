// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Automation.Provider.IGridItemProvider
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Automation.Provider
{
  /// <summary>Exposes methods and properties to support access by a Microsoft UI Automation client to individual child controls of containers that implement IGridProvider. Implement this interface in order to support the capabilities that an automation client requests with a GetPattern call and PatternInterface.GridItem.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  [Guid(4294142012, 29703, 17851, 169, 54, 223, 62, 214, 211, 131, 125)]
  public interface IGridItemProvider
  {
    /// <summary>Gets the ordinal number of the column that contains the cell or item.</summary>
    /// <returns>A zero-based ordinal number that identifies the column that contains the cell or item.</returns>
    int Column { get; }

    /// <summary>Gets the number of columns that are spanned by a cell or item.</summary>
    /// <returns>The number of columns.</returns>
    int ColumnSpan { get; }

    /// <summary>Gets a UI Automation provider that implements IGridProvider and that represents the container of the cell or item.</summary>
    /// <returns>A UI Automation provider that implements the **Grid** control pattern and that represents the cell or item container.</returns>
    IRawElementProviderSimple ContainingGrid { get; }

    /// <summary>Gets the ordinal number of the row that contains the cell or item.</summary>
    /// <returns>A zero-based ordinal number that identifies the row that contains the cell or item.</returns>
    int Row { get; }

    /// <summary>Gets the number of rows spanned by a cell or item.</summary>
    /// <returns>The number of rows.</returns>
    int RowSpan { get; }
  }
}
