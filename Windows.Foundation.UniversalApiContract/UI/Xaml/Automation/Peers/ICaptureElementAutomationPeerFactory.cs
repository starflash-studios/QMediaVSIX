// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Automation.Peers.ICaptureElementAutomationPeerFactory
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Controls;

namespace Windows.UI.Xaml.Automation.Peers
{
  [Guid(2610097992, 34281, 18537, 177, 117, 143, 124, 244, 90, 109, 159)]
  [ExclusiveTo(typeof (CaptureElementAutomationPeer))]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface ICaptureElementAutomationPeerFactory
  {
    CaptureElementAutomationPeer CreateInstanceWithOwner(
      CaptureElement owner,
      object baseInterface,
      out object innerInterface);
  }
}
