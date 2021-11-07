// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Store.Preview.InstallControl.IAppInstallItem
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Store.Preview.InstallControl
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (AppInstallItem))]
  [Guid(1238622123, 5770, 19647, 169, 58, 158, 68, 140, 130, 115, 125)]
  internal interface IAppInstallItem
  {
    string ProductId { get; }

    string PackageFamilyName { get; }

    AppInstallType InstallType { get; }

    bool IsUserInitiated { get; }

    AppInstallStatus GetCurrentStatus();

    void Cancel();

    void Pause();

    void Restart();

    event TypedEventHandler<AppInstallItem, object> Completed;

    event TypedEventHandler<AppInstallItem, object> StatusChanged;
  }
}
