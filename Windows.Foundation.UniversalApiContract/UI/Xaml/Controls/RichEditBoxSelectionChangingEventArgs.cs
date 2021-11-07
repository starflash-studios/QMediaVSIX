// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.RichEditBoxSelectionChangingEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  /// <summary>Provides event data for the RichEditBox.SelectionChanging event.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 458752)]
  public sealed class RichEditBoxSelectionChangingEventArgs : IRichEditBoxSelectionChangingEventArgs
  {
    /// <summary>Gets the starting index of the text selection.</summary>
    /// <returns>The starting index of the text selection.</returns>
    public extern int SelectionStart { [MethodImpl] get; }

    /// <summary>Gets the length of the text selection.</summary>
    /// <returns>The length of the text selection.</returns>
    public extern int SelectionLength { [MethodImpl] get; }

    /// <summary>Gets or sets a value that indicates whether the selection operation should be canceled.</summary>
    /// <returns>**true** to cancel the selection operation; otherwise, **false**. The default is **false**.</returns>
    public extern bool Cancel { [MethodImpl] get; [MethodImpl] set; }
  }
}
