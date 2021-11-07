// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Automation.Peers.ISelectorAutomationPeerFactory
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Controls.Primitives;

namespace Windows.UI.Xaml.Automation.Peers
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(2068993606, 33435, 19916, 189, 82, 90, 141, 3, 153, 56, 122)]
  [WebHostHidden]
  [ExclusiveTo(typeof (SelectorAutomationPeer))]
  internal interface ISelectorAutomationPeerFactory
  {
    SelectorAutomationPeer CreateInstanceWithOwner(
      Selector owner,
      object baseInterface,
      out object innerInterface);
  }
}
