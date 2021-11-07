// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Automation.Peers.ISearchBoxAutomationPeerFactory
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Controls;

namespace Windows.UI.Xaml.Automation.Peers
{
  [WebHostHidden]
  [ExclusiveTo(typeof (SearchBoxAutomationPeer))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(3015709744, 32682, 16827, 142, 145, 124, 118, 28, 82, 103, 241)]
  internal interface ISearchBoxAutomationPeerFactory
  {
    SearchBoxAutomationPeer CreateInstanceWithOwner(
      SearchBox owner,
      object baseInterface,
      out object innerInterface);
  }
}
