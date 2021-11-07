// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.Primitives.ButtonBase
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Input;

namespace Windows.UI.Xaml.Controls.Primitives
{
  /// <summary>Represents the base class for all button controls, such as Button, RepeatButton, and HyperlinkButton.</summary>
  [Static(typeof (IButtonBaseStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [WebHostHidden]
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Composable(typeof (IButtonBaseFactory), CompositionType.Protected, 65536, "Windows.Foundation.UniversalApiContract")]
  public class ButtonBase : ContentControl, IButtonBase
  {
    /// <summary>Provides base class initialization behavior for ButtonBase derived classes.</summary>
    [MethodImpl]
    protected extern ButtonBase();

    /// <summary>Gets or sets a value that indicates when the Click event occurs, in terms of device behavior.</summary>
    /// <returns>A value of the enumeration that indicates when the Click event occurs.</returns>
    public extern ClickMode ClickMode { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets a value that indicates whether a device pointer is located over this button control.</summary>
    /// <returns>**True** if a pointer is over the button control; otherwise **false**. The default is **false**.</returns>
    public extern bool IsPointerOver { [MethodImpl] get; }

    /// <summary>Gets a value that indicates whether a ButtonBase is currently in a pressed state.</summary>
    /// <returns>**True** if the ButtonBase is in a pressed state; otherwise **false**. The default is **false**.</returns>
    public extern bool IsPressed { [MethodImpl] get; }

    /// <summary>Gets or sets the command to invoke when this button is pressed.</summary>
    /// <returns>The command to invoke when this button is pressed. The default is null.</returns>
    public extern ICommand Command { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the parameter to pass to the Command property.</summary>
    /// <returns>The parameter to pass to the Command property. The default is null.</returns>
    public extern object CommandParameter { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Occurs when a button control is clicked.</summary>
    public extern event RoutedEventHandler Click;

    /// <summary>Identifies the ClickMode dependency property.</summary>
    /// <returns>The identifier for the ClickMode dependency property.</returns>
    public static extern DependencyProperty ClickModeProperty { [MethodImpl] get; }

    /// <summary>Identifies the IsPointerOver dependency property.</summary>
    /// <returns>The identifier for the IsPointerOver dependency property.</returns>
    public static extern DependencyProperty IsPointerOverProperty { [MethodImpl] get; }

    /// <summary>Identifies the IsPressed dependency property.</summary>
    /// <returns>The identifier for the IsPressed dependency property.</returns>
    public static extern DependencyProperty IsPressedProperty { [MethodImpl] get; }

    /// <summary>Identifier for the Command dependency property.</summary>
    /// <returns>The identifier for the Command dependency property.</returns>
    public static extern DependencyProperty CommandProperty { [MethodImpl] get; }

    /// <summary>Identifier for the CommandParameter dependency property.</summary>
    /// <returns>The identifier for the CommandParameter dependency property.</returns>
    public static extern DependencyProperty CommandParameterProperty { [MethodImpl] get; }
  }
}
