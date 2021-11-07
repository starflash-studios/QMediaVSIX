// Decompiled with JetBrains decompiler
// Type: Windows.UI.ViewManagement.Core.CoreInputViewKind
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.ViewManagement.Core
{
  /// <summary>Defines the values for specifying a preferred view for the input pane.</summary>
  [ContractVersion(typeof (UniversalApiContract), 458752)]
  public enum CoreInputViewKind
  {
    /// <summary>Show the default input pane view.</summary>
    Default,
    /// <summary>Show the software keyboard view.</summary>
    Keyboard,
    /// <summary>Show the handwriting pane view. If it is not available, it will show the software keyboard.</summary>
    Handwriting,
    /// <summary>Show the emoji pane view. If it is not available, it will show the emoji view of the software keyboard.</summary>
    Emoji,
    /// <summary>
    /// </summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 655360)] Symbols,
    [ContractVersion("Windows.Foundation.UniversalApiContract", 720896)] Clipboard,
    [ContractVersion("Windows.Foundation.UniversalApiContract", 851968)] Dictation,
  }
}
