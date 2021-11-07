// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.SwapChainBackgroundPanel
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Core;

namespace Windows.UI.Xaml.Controls
{
  /// <summary>Implements a XAML layout surface target for Microsoft DirectX interoperation scenarios. This panel has some atypical restrictions on its usage within an app window; see Remarks.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Composable(typeof (ISwapChainBackgroundPanelFactory), CompositionType.Public, 65536, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  public class SwapChainBackgroundPanel : Grid, ISwapChainBackgroundPanel, ISwapChainBackgroundPanel2
  {
    /// <summary>Initializes a new instance of the SwapChainBackgroundPanel class.</summary>
    [MethodImpl]
    public extern SwapChainBackgroundPanel();

    /// <summary>Creates a core input object that handles the input types as specified by the *deviceTypes* parameter.</summary>
    /// <param name="deviceTypes">A combined value of the enumeration.</param>
    /// <returns>An object that represents the input subsystem for interoperation purposes and can be used for input event connection points.</returns>
    [MethodImpl]
    public extern CoreIndependentInputSource CreateCoreIndependentInputSource(
      CoreInputDeviceTypes deviceTypes);
  }
}
