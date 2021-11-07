// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Automation.Peers.IRangeBaseAutomationPeerFactory
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Controls.Primitives;

namespace Windows.UI.Xaml.Automation.Peers
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  [ExclusiveTo(typeof (RangeBaseAutomationPeer))]
  [Guid(2189194753, 12408, 17529, 149, 234, 145, 55, 76, 160, 98, 7)]
  internal interface IRangeBaseAutomationPeerFactory
  {
    RangeBaseAutomationPeer CreateInstanceWithOwner(
      RangeBase owner,
      object baseInterface,
      out object innerInterface);
  }
}
