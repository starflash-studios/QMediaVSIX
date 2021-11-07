// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.SwapChainPanel
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Core;

namespace Windows.UI.Xaml.Controls
{
  /// <summary>Provides a hosting surface, where Microsoft DirectX swap chains provide content that can be rendered into a XAML UI. A SwapChainPanel element is a key component for an app that renders Microsoft DirectX graphics and then presents those visuals within a XAML page.</summary>
  [WebHostHidden]
  [Static(typeof (ISwapChainPanelStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [Composable(typeof (ISwapChainPanelFactory), CompositionType.Public, 65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  public class SwapChainPanel : Grid, ISwapChainPanel
  {
    /// <summary>Initializes a new instance of the SwapChainPanel class.</summary>
    [MethodImpl]
    public extern SwapChainPanel();

    /// <summary>Gets the x-axis scale factor of the SwapChainPanel.</summary>
    /// <returns>The x-axis scale factor of the SwapChainPanel. A value of 1.0 means no scaling is applied.</returns>
    public extern float CompositionScaleX { [MethodImpl] get; }

    /// <summary>Gets the y-axis scale factor of the SwapChainPanel.</summary>
    /// <returns>The y-axis scale factor of the SwapChainPanel. A value of 1.0 means no scaling is applied.</returns>
    public extern float CompositionScaleY { [MethodImpl] get; }

    /// <summary>Occurs when the composition scale factor of the SwapChainPanel has changed.</summary>
    public extern event TypedEventHandler<SwapChainPanel, object> CompositionScaleChanged;

    /// <summary>Creates a core input object that handles the input types as specified by the *deviceTypes* parameter. This core input object can process input events on a background thread.</summary>
    /// <param name="deviceTypes">A combined value of the enumeration.</param>
    /// <returns>An object that represents the input subsystem for interoperation purposes and can be used for input event connection points.</returns>
    [MethodImpl]
    public extern CoreIndependentInputSource CreateCoreIndependentInputSource(
      CoreInputDeviceTypes deviceTypes);

    /// <summary>Identifies the CompositionScaleX dependency property.</summary>
    /// <returns>The identifier for the CompositionScaleX dependency property.</returns>
    public static extern DependencyProperty CompositionScaleXProperty { [MethodImpl] get; }

    /// <summary>Identifies the CompositionScaleY dependency property.</summary>
    /// <returns>The identifier for the CompositionScaleY dependency property.</returns>
    public static extern DependencyProperty CompositionScaleYProperty { [MethodImpl] get; }
  }
}
