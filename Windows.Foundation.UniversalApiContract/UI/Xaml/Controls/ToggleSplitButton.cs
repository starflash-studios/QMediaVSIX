// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.ToggleSplitButton
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  /// <summary>Represents a button with two parts that can be invoked separately. One part behaves like a toggle button and the other part invokes a flyout.</summary>
  [WebHostHidden]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 458752)]
  [Composable(typeof (IToggleSplitButtonFactory), CompositionType.Public, 458752, "Windows.Foundation.UniversalApiContract")]
  public class ToggleSplitButton : SplitButton, IToggleSplitButton
  {
    /// <summary>Initializes a new instance of the ToggleSplitButton class.</summary>
    [MethodImpl]
    public extern ToggleSplitButton();

    /// <summary>Gets or sets whether the ToggleSplitButton is checked.</summary>
    /// <returns>**true** if the ToggleSplitButton is checked; **false** if the ToggleSplitButton is unchecked. The default is **false**.</returns>
    public extern bool IsChecked { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Occurs when the value of the IsChecked property is changed.</summary>
    public extern event TypedEventHandler<ToggleSplitButton, ToggleSplitButtonIsCheckedChangedEventArgs> IsCheckedChanged;
  }
}
