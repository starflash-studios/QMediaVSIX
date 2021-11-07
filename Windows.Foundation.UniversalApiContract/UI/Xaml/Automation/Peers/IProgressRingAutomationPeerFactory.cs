// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Automation.Peers.IProgressRingAutomationPeerFactory
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Controls;

namespace Windows.UI.Xaml.Automation.Peers
{
  [Guid(4091224139, 5502, 16572, 149, 147, 85, 188, 92, 113, 164, 246)]
  [ExclusiveTo(typeof (ProgressRingAutomationPeer))]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IProgressRingAutomationPeerFactory
  {
    ProgressRingAutomationPeer CreateInstanceWithOwner(
      ProgressRing owner,
      object baseInterface,
      out object innerInterface);
  }
}
