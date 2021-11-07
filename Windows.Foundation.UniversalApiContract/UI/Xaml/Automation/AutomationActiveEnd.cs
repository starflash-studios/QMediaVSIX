// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Automation.AutomationActiveEnd
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Automation
{
  /// <summary>Defines values for the SelectionActiveEnd text attribute, which indicates the location of the caret relative to a text range that represents the currently selected text.</summary>
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum AutomationActiveEnd
  {
    /// <summary>The caret is not at either end of the text range.</summary>
    None,
    /// <summary>The caret is at the beginning of the text range.</summary>
    Start,
    /// <summary>The caret is at the end of the text range.</summary>
    End,
  }
}
