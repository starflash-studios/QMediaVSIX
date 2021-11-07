// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.AppExtensions.IAppExtensionCatalog
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.AppExtensions
{
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [ExclusiveTo(typeof (AppExtensionCatalog))]
  [Guid(2542215218, 33830, 19153, 144, 132, 146, 232, 140, 45, 162, 0)]
  internal interface IAppExtensionCatalog
  {
    [RemoteAsync]
    IAsyncOperation<IVectorView<AppExtension>> FindAllAsync();

    [RemoteAsync]
    IAsyncOperation<bool> RequestRemovePackageAsync(string packageFullName);

    event TypedEventHandler<AppExtensionCatalog, AppExtensionPackageInstalledEventArgs> PackageInstalled;

    event TypedEventHandler<AppExtensionCatalog, AppExtensionPackageUpdatingEventArgs> PackageUpdating;

    event TypedEventHandler<AppExtensionCatalog, AppExtensionPackageUpdatedEventArgs> PackageUpdated;

    event TypedEventHandler<AppExtensionCatalog, AppExtensionPackageUninstallingEventArgs> PackageUninstalling;

    event TypedEventHandler<AppExtensionCatalog, AppExtensionPackageStatusChangedEventArgs> PackageStatusChanged;
  }
}
