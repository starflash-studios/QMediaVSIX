// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.SplitButton
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Input;

namespace Windows.UI.Xaml.Controls
{
  /// <summary>Represents a button with two parts that can be invoked separately. One part behaves like a standard button and the other part invokes a flyout.</summary>
  [ContractVersion(typeof (UniversalApiContract), 458752)]
  [WebHostHidden]
  [Threading(ThreadingModel.Both)]
  [Composable(typeof (ISplitButtonFactory), CompositionType.Public, 458752, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Static(typeof (ISplitButtonStatics), 458752, "Windows.Foundation.UniversalApiContract")]
  public class SplitButton : ContentControl, ISplitButton
  {
    /// <summary>Initializes a new instance of the SplitButton class.</summary>
    [MethodImpl]
    public extern SplitButton();

    /// <summary>Gets or sets the flyout associated with this button.</summary>
    /// <returns>The flyout associated with this button. The default is **null**.</returns>
    public extern FlyoutBase Flyout { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the command to invoke when this button is pressed.</summary>
    /// <returns>The command to invoke when this button is pressed. The default is **null**.</returns>
    public extern ICommand Command { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the parameter to pass to the Command property.</summary>
    /// <returns>The parameter to pass to the Command property. The default is **null**.</returns>
    public extern object CommandParameter { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Occurs when a button control is clicked.</summary>
    public extern event TypedEventHandler<SplitButton, SplitButtonClickEventArgs> Click;

    /// <summary>Identifies the Flyout dependency property.</summary>
    /// <returns>The identifier for the Flyout dependency property.</returns>
    public static extern DependencyProperty FlyoutProperty { [MethodImpl] get; }

    /// <summary>Identifies the Command dependency property.</summary>
    /// <returns>The identifier for the Command dependency property.</returns>
    public static extern DependencyProperty CommandProperty { [MethodImpl] get; }

    /// <summary>Identifies the CommandParameter dependency property.</summary>
    /// <returns>The identifier for the CommandParameter dependency property.</returns>
    public static extern DependencyProperty CommandParameterProperty { [MethodImpl] get; }
  }
}
