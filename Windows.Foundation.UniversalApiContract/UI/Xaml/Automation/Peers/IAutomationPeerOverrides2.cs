// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Automation.Peers.IAutomationPeerOverrides2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Automation.Peers
{
  [WebHostHidden]
  [ExclusiveTo(typeof (AutomationPeer))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(637757482, 40358, 16419, 180, 150, 73, 110, 94, 242, 40, 210)]
  internal interface IAutomationPeerOverrides2
  {
    void ShowContextMenuCore();

    IVectorView<AutomationPeer> GetControlledPeersCore();
  }
}
