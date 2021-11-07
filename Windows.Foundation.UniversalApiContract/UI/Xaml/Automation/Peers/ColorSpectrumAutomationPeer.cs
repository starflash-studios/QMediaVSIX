// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Automation.Peers.ColorSpectrumAutomationPeer
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Controls.Primitives;

namespace Windows.UI.Xaml.Automation.Peers
{
  /// <summary>Exposes **ColorSpectrum ** types to Microsoft UI Automation.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  [Composable(typeof (IColorSpectrumAutomationPeerFactory), CompositionType.Public, 327680, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  [WebHostHidden]
  public class ColorSpectrumAutomationPeer : 
    FrameworkElementAutomationPeer,
    IColorSpectrumAutomationPeer
  {
    /// <summary>Initializes a new instance of the **ColorSpectrumAutomationPeer** class.</summary>
    /// <param name="owner">The **ColorSpectrum ** control instance to create the peer for.</param>
    [MethodImpl]
    public extern ColorSpectrumAutomationPeer(ColorSpectrum owner);
  }
}
