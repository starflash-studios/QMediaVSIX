// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Automation.GridItemPatternIdentifiers
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Automation
{
  /// <summary>Contains values used as identifiers by IGridItemProvider.</summary>
  [Static(typeof (IGridItemPatternIdentifiersStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [WebHostHidden]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class GridItemPatternIdentifiers : IGridItemPatternIdentifiers
  {
    /// <summary>Identifies the Column automation property.</summary>
    /// <returns>The automation property identifier.</returns>
    public static extern AutomationProperty ColumnProperty { [MethodImpl] get; }

    /// <summary>Identifies the ColumnSpan automation property.</summary>
    /// <returns>The automation property identifier.</returns>
    public static extern AutomationProperty ColumnSpanProperty { [MethodImpl] get; }

    /// <summary>Identifies the ContainingGrid automation property.</summary>
    /// <returns>The automation property identifier.</returns>
    public static extern AutomationProperty ContainingGridProperty { [MethodImpl] get; }

    /// <summary>Identifies the Row automation property.</summary>
    /// <returns>The automation property identifier.</returns>
    public static extern AutomationProperty RowProperty { [MethodImpl] get; }

    /// <summary>Identifies the RowSpan property.</summary>
    /// <returns>The automation property identifier.</returns>
    public static extern AutomationProperty RowSpanProperty { [MethodImpl] get; }
  }
}
