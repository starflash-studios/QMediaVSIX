// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Automation.AutomationCaretPosition
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Automation
{
  /// <summary>Defines the caret position.</summary>
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum AutomationCaretPosition
  {
    /// <summary>Caret position is unknown.</summary>
    Unknown,
    /// <summary>Caret is at the end of the line.</summary>
    EndOfLine,
    /// <summary>Caret is at the beginning of the line.</summary>
    BeginningOfLine,
  }
}
