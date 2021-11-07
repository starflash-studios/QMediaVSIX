// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Automation.Peers.IMediaTransportControlsAutomationPeerFactory
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Controls;

namespace Windows.UI.Xaml.Automation.Peers
{
  [ExclusiveTo(typeof (MediaTransportControlsAutomationPeer))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  [Guid(4095520771, 57603, 19120, 129, 42, 160, 143, 189, 181, 112, 206)]
  internal interface IMediaTransportControlsAutomationPeerFactory
  {
    MediaTransportControlsAutomationPeer CreateInstanceWithOwner(
      MediaTransportControls owner,
      object baseInterface,
      out object innerInterface);
  }
}
