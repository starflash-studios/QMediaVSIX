// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Automation.Peers.IFrameworkElementAutomationPeerStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Automation.Peers
{
  [WebHostHidden]
  [Guid(3116415383, 10272, 17569, 165, 168, 155, 128, 30, 220, 38, 158)]
  [ExclusiveTo(typeof (FrameworkElementAutomationPeer))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IFrameworkElementAutomationPeerStatics
  {
    AutomationPeer FromElement(UIElement element);

    AutomationPeer CreatePeerForElement(UIElement element);
  }
}
