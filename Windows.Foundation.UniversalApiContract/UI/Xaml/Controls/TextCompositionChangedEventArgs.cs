// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.TextCompositionChangedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  /// <summary>Provides event data for the TextCompositionChanged event on TextBox and RichEditBox.</summary>
  [WebHostHidden]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class TextCompositionChangedEventArgs : ITextCompositionChangedEventArgs
  {
    /// <summary>Gets the starting location of the text that the user is composing with an Input Method Editor (IME).</summary>
    /// <returns>The starting location of the text that the user is composing with an [Input Method Editor (IME)](https://docs.microsoft.com/previous-versions/windows/apps/hh967427(v=win.10)).</returns>
    public extern int StartIndex { [MethodImpl] get; }

    /// <summary>Gets the length of the portion of the text that the user is composing with an Input Method Editor (IME).</summary>
    /// <returns>The length of the portion of the text that the user is composing with an [Input Method Editor (IME)](https://docs.microsoft.com/previous-versions/windows/apps/hh967427(v=win.10)).</returns>
    public extern int Length { [MethodImpl] get; }
  }
}
