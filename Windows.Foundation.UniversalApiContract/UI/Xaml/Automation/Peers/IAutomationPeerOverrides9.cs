// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Automation.Peers.IAutomationPeerOverrides9
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Automation.Peers
{
  [ExclusiveTo(typeof (AutomationPeer))]
  [ContractVersion(typeof (UniversalApiContract), 458752)]
  [Guid(4084244107, 2330, 23989, 184, 150, 255, 120, 240, 25, 144, 201)]
  [WebHostHidden]
  internal interface IAutomationPeerOverrides9
  {
    bool IsDialogCore();
  }
}
