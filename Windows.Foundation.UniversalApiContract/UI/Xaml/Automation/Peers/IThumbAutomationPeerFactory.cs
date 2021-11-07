// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Automation.Peers.IThumbAutomationPeerFactory
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Controls.Primitives;

namespace Windows.UI.Xaml.Automation.Peers
{
  [ExclusiveTo(typeof (ThumbAutomationPeer))]
  [Guid(2533835775, 44865, 17920, 181, 93, 38, 212, 61, 248, 96, 225)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  internal interface IThumbAutomationPeerFactory
  {
    ThumbAutomationPeer CreateInstanceWithOwner(
      Thumb owner,
      object baseInterface,
      out object innerInterface);
  }
}
