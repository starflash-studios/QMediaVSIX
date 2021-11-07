// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Automation.Peers.ITextBoxAutomationPeerFactory
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
  [ExclusiveTo(typeof (TextBoxAutomationPeer))]
  [Guid(32555111, 38507, 16688, 184, 114, 70, 158, 66, 189, 74, 127)]
  internal interface ITextBoxAutomationPeerFactory
  {
    TextBoxAutomationPeer CreateInstanceWithOwner(
      TextBox owner,
      object baseInterface,
      out object innerInterface);
  }
}
