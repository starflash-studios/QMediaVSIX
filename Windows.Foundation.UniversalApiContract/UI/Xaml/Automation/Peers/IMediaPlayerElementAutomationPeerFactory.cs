// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Automation.Peers.IMediaPlayerElementAutomationPeerFactory
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Controls;

namespace Windows.UI.Xaml.Automation.Peers
{
  [WebHostHidden]
  [Guid(142901367, 33455, 19737, 177, 112, 40, 42, 158, 14, 127, 55)]
  [ExclusiveTo(typeof (MediaPlayerElementAutomationPeer))]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  internal interface IMediaPlayerElementAutomationPeerFactory
  {
    MediaPlayerElementAutomationPeer CreateInstanceWithOwner(
      MediaPlayerElement owner,
      object baseInterface,
      out object innerInterface);
  }
}
