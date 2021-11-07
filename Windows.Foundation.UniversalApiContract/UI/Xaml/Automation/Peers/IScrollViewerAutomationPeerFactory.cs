// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Automation.Peers.IScrollViewerAutomationPeerFactory
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Controls;

namespace Windows.UI.Xaml.Automation.Peers
{
  [WebHostHidden]
  [Guid(655228797, 55661, 18681, 163, 106, 194, 82, 170, 156, 70, 112)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (ScrollViewerAutomationPeer))]
  internal interface IScrollViewerAutomationPeerFactory
  {
    ScrollViewerAutomationPeer CreateInstanceWithOwner(
      ScrollViewer owner,
      object baseInterface,
      out object innerInterface);
  }
}
