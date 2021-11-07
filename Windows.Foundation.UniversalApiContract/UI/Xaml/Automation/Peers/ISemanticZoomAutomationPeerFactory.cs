// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Automation.Peers.ISemanticZoomAutomationPeerFactory
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Controls;

namespace Windows.UI.Xaml.Automation.Peers
{
  [Guid(4112045133, 42131, 17558, 176, 119, 150, 116, 199, 244, 197, 250)]
  [WebHostHidden]
  [ExclusiveTo(typeof (SemanticZoomAutomationPeer))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface ISemanticZoomAutomationPeerFactory
  {
    SemanticZoomAutomationPeer CreateInstanceWithOwner(
      SemanticZoom owner,
      object baseInterface,
      out object innerInterface);
  }
}
