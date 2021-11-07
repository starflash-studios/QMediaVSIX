// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.IPackageCatalog
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel
{
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [ExclusiveTo(typeof (PackageCatalog))]
  [Guid(587872081, 40419, 17477, 190, 116, 145, 251, 50, 90, 190, 254)]
  internal interface IPackageCatalog
  {
    event TypedEventHandler<PackageCatalog, PackageStagingEventArgs> PackageStaging;

    event TypedEventHandler<PackageCatalog, PackageInstallingEventArgs> PackageInstalling;

    event TypedEventHandler<PackageCatalog, PackageUpdatingEventArgs> PackageUpdating;

    event TypedEventHandler<PackageCatalog, PackageUninstallingEventArgs> PackageUninstalling;

    event TypedEventHandler<PackageCatalog, PackageStatusChangedEventArgs> PackageStatusChanged;
  }
}
