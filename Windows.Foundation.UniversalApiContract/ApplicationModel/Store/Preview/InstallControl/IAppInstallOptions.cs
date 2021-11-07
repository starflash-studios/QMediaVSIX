// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Store.Preview.InstallControl.IAppInstallOptions
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Management.Deployment;

namespace Windows.ApplicationModel.Store.Preview.InstallControl
{
  [ExclusiveTo(typeof (AppInstallOptions))]
  [Guid(3380642560, 7352, 20150, 140, 159, 106, 48, 198, 74, 91, 81)]
  [ContractVersion(typeof (UniversalApiContract), 393216)]
  internal interface IAppInstallOptions
  {
    string CatalogId { get; set; }

    bool ForceUseOfNonRemovableStorage { get; set; }

    bool AllowForcedAppRestart { get; set; }

    bool Repair { get; set; }

    PackageVolume TargetVolume { get; set; }

    bool LaunchAfterInstall { get; set; }
  }
}
