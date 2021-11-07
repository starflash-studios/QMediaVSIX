// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.TextBoxBeforeTextChangingEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  /// <summary>Provides event data for the TextBox.BeforeTextChanging event.</summary>
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  [WebHostHidden]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class TextBoxBeforeTextChangingEventArgs : ITextBoxBeforeTextChangingEventArgs
  {
    /// <summary>Gets the new text that is entered into the text box.</summary>
    /// <returns>The new text value that is entered into the text box.</returns>
    public extern string NewText { [MethodImpl] get; }

    /// <summary>Gets or sets a value that indicates whether to cancel the text changes.</summary>
    /// <returns>**true** to cancel the text changes; otherwise, **false**. The default is **false**.</returns>
    public extern bool Cancel { [MethodImpl] get; [MethodImpl] set; }
  }
}
