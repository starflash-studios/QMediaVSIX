// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Automation.TableItemPatternIdentifiers
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Automation
{
  /// <summary>Contains values used as identifiers by ITableProvider.</summary>
  [Static(typeof (ITableItemPatternIdentifiersStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  public sealed class TableItemPatternIdentifiers : ITableItemPatternIdentifiers
  {
    /// <summary>Identifies the automation property that retrieves all the column headers associated with a table item or cell.</summary>
    /// <returns>The automation property identifier.</returns>
    public static extern AutomationProperty ColumnHeaderItemsProperty { [MethodImpl] get; }

    /// <summary>Identifies the automation property that retrieves all the row headers associated with a table item or cell.</summary>
    /// <returns>The automation property identifier.</returns>
    public static extern AutomationProperty RowHeaderItemsProperty { [MethodImpl] get; }
  }
}
