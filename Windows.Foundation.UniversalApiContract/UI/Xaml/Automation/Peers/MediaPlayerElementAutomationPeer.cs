// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Automation.Peers.MediaPlayerElementAutomationPeer
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Controls;

namespace Windows.UI.Xaml.Automation.Peers
{
  /// <summary>Exposes MediaPlayerElement types to Microsoft UI Automation.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [WebHostHidden]
  [Threading(ThreadingModel.Both)]
  [Composable(typeof (IMediaPlayerElementAutomationPeerFactory), CompositionType.Public, 196608, "Windows.Foundation.UniversalApiContract")]
  public class MediaPlayerElementAutomationPeer : 
    FrameworkElementAutomationPeer,
    IMediaPlayerElementAutomationPeer
  {
    /// <summary>Initializes a new instance of the MediaPlayerElementAutomationPeer class.</summary>
    /// <param name="owner">The MediaPlayerElement to create a peer for.</param>
    [MethodImpl]
    public extern MediaPlayerElementAutomationPeer(MediaPlayerElement owner);
  }
}
