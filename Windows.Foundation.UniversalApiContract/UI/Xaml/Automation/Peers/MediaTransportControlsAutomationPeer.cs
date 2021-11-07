// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Automation.Peers.MediaTransportControlsAutomationPeer
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Controls;

namespace Windows.UI.Xaml.Automation.Peers
{
  /// <summary>Exposes MediaTransportControls types to Microsoft UI Automation.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Threading(ThreadingModel.Both)]
  [WebHostHidden]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Composable(typeof (IMediaTransportControlsAutomationPeerFactory), CompositionType.Public, 65536, "Windows.Foundation.UniversalApiContract")]
  public class MediaTransportControlsAutomationPeer : 
    FrameworkElementAutomationPeer,
    IMediaTransportControlsAutomationPeer
  {
    /// <summary>Initializes a new instance of the MediaTransportControlsAutomationPeer class using the specified media transport controls.</summary>
    /// <param name="owner">The specified media transport controls.</param>
    [MethodImpl]
    public extern MediaTransportControlsAutomationPeer(MediaTransportControls owner);
  }
}
