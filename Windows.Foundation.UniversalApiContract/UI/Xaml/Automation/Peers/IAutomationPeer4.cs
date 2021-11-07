// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Automation.Peers.IAutomationPeer4
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Automation.Peers
{
  [ExclusiveTo(typeof (AutomationPeer))]
  [Guid(1981605714, 29633, 20292, 190, 117, 67, 196, 158, 192, 212, 213)]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  internal interface IAutomationPeer4
  {
    AutomationLandmarkType GetLandmarkType();

    string GetLocalizedLandmarkType();
  }
}
