// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.IPackage6
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel
{
  [Guid(2333792578, 4823, 18260, 174, 78, 99, 140, 188, 14, 58, 46)]
  [ContractVersion(typeof (UniversalApiContract), 458752)]
  [ExclusiveTo(typeof (Package))]
  internal interface IPackage6
  {
    AppInstallerInfo GetAppInstallerInfo();

    [RemoteAsync]
    IAsyncOperation<PackageUpdateAvailabilityResult> CheckUpdateAvailabilityAsync();
  }
}
