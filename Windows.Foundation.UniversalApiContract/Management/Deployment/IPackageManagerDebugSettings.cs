// Decompiled with JetBrains decompiler
// Type: Windows.Management.Deployment.IPackageManagerDebugSettings
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.ApplicationModel;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Management.Deployment
{
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [ExclusiveTo(typeof (PackageManagerDebugSettings))]
  [Guid(442570371, 43400, 20431, 143, 15, 206, 23, 88, 152, 232, 235)]
  internal interface IPackageManagerDebugSettings
  {
    [RemoteAsync]
    [Overload("SetContentGroupStateAsync")]
    IAsyncAction SetContentGroupStateAsync(
      Package package,
      string contentGroupName,
      PackageContentGroupState state);

    [Overload("SetContentGroupStateWithPercentageAsync")]
    [RemoteAsync]
    IAsyncAction SetContentGroupStateAsync(
      Package package,
      string contentGroupName,
      PackageContentGroupState state,
      double completionPercentage);
  }
}
