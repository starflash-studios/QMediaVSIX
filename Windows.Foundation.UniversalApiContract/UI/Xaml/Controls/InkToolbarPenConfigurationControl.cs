// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.InkToolbarPenConfigurationControl
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  /// <summary>Represents an object used to configure an optional flyout associated with an InkToolbarCustomPenButton. An "extension glyph" is displayed on the button to indicate the existence of the flyout.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [Composable(typeof (IInkToolbarPenConfigurationControlFactory), CompositionType.Public, 196608, "Windows.Foundation.UniversalApiContract")]
  [WebHostHidden]
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [Static(typeof (IInkToolbarPenConfigurationControlStatics), 196608, "Windows.Foundation.UniversalApiContract")]
  public class InkToolbarPenConfigurationControl : Control, IInkToolbarPenConfigurationControl
  {
    /// <summary>Initializes a new instance of the InkToolbarPenConfigurationControl class.</summary>
    [MethodImpl]
    public extern InkToolbarPenConfigurationControl();

    /// <summary>Gets the InkToolbarPenButton from which to derive the ConfigurationContent for the optional flyout.</summary>
    /// <returns>The base pen from which ConfigurationContent is derived.</returns>
    public extern InkToolbarPenButton PenButton { [MethodImpl] get; }

    /// <summary>Identifies the PenButton dependency property.</summary>
    /// <returns>The identifier for the PenButton dependency property.</returns>
    public static extern DependencyProperty PenButtonProperty { [MethodImpl] get; }
  }
}
