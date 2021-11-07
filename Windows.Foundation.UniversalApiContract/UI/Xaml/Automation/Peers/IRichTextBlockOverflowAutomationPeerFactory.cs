// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Automation.Peers.IRichTextBlockOverflowAutomationPeerFactory
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Controls;

namespace Windows.UI.Xaml.Automation.Peers
{
  [ExclusiveTo(typeof (RichTextBlockOverflowAutomationPeer))]
  [Guid(3177100899, 11284, 18021, 173, 239, 242, 176, 51, 148, 123, 235)]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IRichTextBlockOverflowAutomationPeerFactory
  {
    RichTextBlockOverflowAutomationPeer CreateInstanceWithOwner(
      RichTextBlockOverflow owner,
      object baseInterface,
      out object innerInterface);
  }
}
