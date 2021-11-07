// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Automation.Peers.IButtonBaseAutomationPeerFactory
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Controls.Primitives;

namespace Windows.UI.Xaml.Automation.Peers
{
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (ButtonBaseAutomationPeer))]
  [Guid(2315520286, 59058, 19552, 167, 89, 193, 60, 164, 81, 101, 237)]
  internal interface IButtonBaseAutomationPeerFactory
  {
    ButtonBaseAutomationPeer CreateInstanceWithOwner(
      ButtonBase owner,
      object baseInterface,
      out object innerInterface);
  }
}
