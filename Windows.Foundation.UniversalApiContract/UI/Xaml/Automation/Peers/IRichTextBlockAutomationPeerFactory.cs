// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Automation.Peers.IRichTextBlockAutomationPeerFactory
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Controls;

namespace Windows.UI.Xaml.Automation.Peers
{
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(540585569, 5001, 18042, 174, 214, 55, 51, 77, 169, 98, 43)]
  [ExclusiveTo(typeof (RichTextBlockAutomationPeer))]
  internal interface IRichTextBlockAutomationPeerFactory
  {
    RichTextBlockAutomationPeer CreateInstanceWithOwner(
      RichTextBlock owner,
      object baseInterface,
      out object innerInterface);
  }
}
