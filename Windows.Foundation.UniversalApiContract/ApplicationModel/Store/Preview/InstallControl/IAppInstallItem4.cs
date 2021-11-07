// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Store.Preview.InstallControl.IAppInstallItem4
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Store.Preview.InstallControl
{
  [Guid(3268529682, 29183, 20424, 181, 64, 69, 61, 75, 55, 225, 209)]
  [ExclusiveTo(typeof (AppInstallItem))]
  [ContractVersion(typeof (UniversalApiContract), 393216)]
  internal interface IAppInstallItem4
  {
    bool LaunchAfterInstall { get; set; }
  }
}
