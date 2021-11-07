// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.Primitives.ToggleButton
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls.Primitives
{
  /// <summary>Represents a control that a user can select (check) or clear (uncheck). Base class for controls that can switch states, such as CheckBox and RadioButton.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Static(typeof (IToggleButtonStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [WebHostHidden]
  [Threading(ThreadingModel.Both)]
  [Composable(typeof (IToggleButtonFactory), CompositionType.Public, 65536, "Windows.Foundation.UniversalApiContract")]
  public class ToggleButton : ButtonBase, IToggleButton, IToggleButtonOverrides
  {
    /// <summary>Initializes a new instance of the ToggleButton class.</summary>
    [MethodImpl]
    public extern ToggleButton();

    /// <summary>Gets or sets whether the ToggleButton is checked.</summary>
    /// <returns>**true** if the ToggleButton is checked; **false** if the ToggleButton is unchecked; otherwise **null**. The default is **false**.</returns>
    public extern IReference<bool> IsChecked { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a value that indicates whether the control supports three states.</summary>
    /// <returns>**True** if the control supports three states; otherwise, **false**. The default is **false**.</returns>
    public extern bool IsThreeState { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Fires when a ToggleButton is checked.</summary>
    public extern event RoutedEventHandler Checked;

    /// <summary>Occurs when a ToggleButton is unchecked.</summary>
    public extern event RoutedEventHandler Unchecked;

    /// <summary>Fires when the state of a ToggleButton is switched to the indeterminate state.</summary>
    public extern event RoutedEventHandler Indeterminate;

    [MethodImpl]
    extern void IToggleButtonOverrides.OnToggle();

    /// <summary>Identifies the IsChecked dependency property.</summary>
    /// <returns>The identifier for the IsChecked dependency property.</returns>
    public static extern DependencyProperty IsCheckedProperty { [MethodImpl] get; }

    /// <summary>Identifies the IsThreeState dependency property.</summary>
    /// <returns>The identifier for the IsThreeState dependency property.</returns>
    public static extern DependencyProperty IsThreeStateProperty { [MethodImpl] get; }
  }
}
