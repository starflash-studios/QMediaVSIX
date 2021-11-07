// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Automation.Peers.IPasswordBoxAutomationPeerFactory
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Controls;

namespace Windows.UI.Xaml.Automation.Peers
{
  [WebHostHidden]
  [ExclusiveTo(typeof (PasswordBoxAutomationPeer))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(2889711326, 56484, 18460, 181, 32, 74, 155, 63, 59, 23, 156)]
  internal interface IPasswordBoxAutomationPeerFactory
  {
    PasswordBoxAutomationPeer CreateInstanceWithOwner(
      PasswordBox owner,
      object baseInterface,
      out object innerInterface);
  }
}
