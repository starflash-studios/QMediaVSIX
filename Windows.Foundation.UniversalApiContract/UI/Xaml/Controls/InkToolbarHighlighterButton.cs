// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.InkToolbarHighlighterButton
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  /// <summary>Represents an InkToolbar toggle button control that activates the built-in highlighter pen.</summary>
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [WebHostHidden]
  [Composable(typeof (IInkToolbarHighlighterButtonFactory), CompositionType.Public, 196608, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public class InkToolbarHighlighterButton : InkToolbarPenButton, IInkToolbarHighlighterButton
  {
    /// <summary>Initializes a new instance of the InkToolbarHighlighterButton class.</summary>
    [MethodImpl]
    public extern InkToolbarHighlighterButton();
  }
}
