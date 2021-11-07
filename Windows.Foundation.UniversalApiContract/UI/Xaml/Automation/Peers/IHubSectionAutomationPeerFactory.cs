// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Automation.Peers.IHubSectionAutomationPeerFactory
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Controls;

namespace Windows.UI.Xaml.Automation.Peers
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(3331205096, 6124, 17193, 145, 174, 45, 11, 35, 57, 212, 152)]
  [ExclusiveTo(typeof (HubSectionAutomationPeer))]
  [WebHostHidden]
  internal interface IHubSectionAutomationPeerFactory
  {
    HubSectionAutomationPeer CreateInstanceWithOwner(
      HubSection owner,
      object baseInterface,
      out object innerInterface);
  }
}
