// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.RadioButton
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Controls.Primitives;

namespace Windows.UI.Xaml.Controls
{
  /// <summary>Represents a button that allows a user to select a single option from a group of options.</summary>
  [WebHostHidden]
  [Threading(ThreadingModel.Both)]
  [Static(typeof (IRadioButtonStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Composable(typeof (IRadioButtonFactory), CompositionType.Public, 65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  public class RadioButton : ToggleButton, IRadioButton
  {
    /// <summary>Initializes a new instance of the RadioButton class.</summary>
    [MethodImpl]
    public extern RadioButton();

    /// <summary>Gets or sets the name that specifies which RadioButton controls are mutually exclusive.</summary>
    /// <returns>The name that specifies which RadioButton controls are mutually exclusive. The default is null.</returns>
    public extern string GroupName { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Identifies the GroupName dependency property.</summary>
    /// <returns>The identifier for GroupName dependency property.</returns>
    public static extern DependencyProperty GroupNameProperty { [MethodImpl] get; }
  }
}
