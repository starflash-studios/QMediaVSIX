// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Automation.Peers.IRatingControlAutomationPeerFactory
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Controls;

namespace Windows.UI.Xaml.Automation.Peers
{
  [WebHostHidden]
  [Guid(4051300978, 38982, 17970, 139, 156, 190, 111, 168, 211, 201, 187)]
  [ExclusiveTo(typeof (RatingControlAutomationPeer))]
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  internal interface IRatingControlAutomationPeerFactory
  {
    RatingControlAutomationPeer CreateInstanceWithOwner(
      RatingControl owner,
      object baseInterface,
      out object innerInterface);
  }
}
