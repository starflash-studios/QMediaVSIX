// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Automation.SpreadsheetItemPatternIdentifiers
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Automation
{
  /// <summary>Contains values used as automation property identifiers for properties of the ISpreadsheetItemProvider pattern.</summary>
  [Threading(ThreadingModel.Both)]
  [WebHostHidden]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Static(typeof (ISpreadsheetItemPatternIdentifiersStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  public sealed class SpreadsheetItemPatternIdentifiers : ISpreadsheetItemPatternIdentifiers
  {
    /// <summary>Identifies the Formula automation property.</summary>
    /// <returns>The automation property identifier.</returns>
    public static extern AutomationProperty FormulaProperty { [MethodImpl] get; }
  }
}
