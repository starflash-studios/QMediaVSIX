// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Automation.Peers.IAutomationPeerOverrides4
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Automation.Peers
{
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  [ExclusiveTo(typeof (AutomationPeer))]
  [Guid(2978401698, 23878, 19405, 168, 17, 38, 154, 209, 91, 58, 238)]
  [WebHostHidden]
  internal interface IAutomationPeerOverrides4
  {
    AutomationLandmarkType GetLandmarkTypeCore();

    string GetLocalizedLandmarkTypeCore();
  }
}
