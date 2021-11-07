// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Automation.Peers.IRepeatButtonAutomationPeerFactory
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Controls.Primitives;

namespace Windows.UI.Xaml.Automation.Peers
{
  [ExclusiveTo(typeof (RepeatButtonAutomationPeer))]
  [Guid(1785723348, 22366, 20064, 189, 214, 236, 20, 65, 155, 79, 246)]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IRepeatButtonAutomationPeerFactory
  {
    RepeatButtonAutomationPeer CreateInstanceWithOwner(
      RepeatButton owner,
      object baseInterface,
      out object innerInterface);
  }
}
