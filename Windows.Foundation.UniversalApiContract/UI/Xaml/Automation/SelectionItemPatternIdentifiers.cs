// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Automation.SelectionItemPatternIdentifiers
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Automation
{
  /// <summary>Contains values used as identifiers by ISelectionItemProvider.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Threading(ThreadingModel.Both)]
  [Static(typeof (ISelectionItemPatternIdentifiersStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [WebHostHidden]
  public sealed class SelectionItemPatternIdentifiers : ISelectionItemPatternIdentifiers
  {
    /// <summary>Identifies the IsSelected automation property.</summary>
    /// <returns>The automation property identifier.</returns>
    public static extern AutomationProperty IsSelectedProperty { [MethodImpl] get; }

    /// <summary>Identifies the SelectionContainer automation property.</summary>
    /// <returns>The automation property identifier.</returns>
    public static extern AutomationProperty SelectionContainerProperty { [MethodImpl] get; }
  }
}
