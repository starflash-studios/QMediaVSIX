// Decompiled with JetBrains decompiler
// Type: Windows.Services.Maps.OfflineMaps.IOfflineMapPackage
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Services.Maps.OfflineMaps
{
  [ExclusiveTo(typeof (OfflineMapPackage))]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [Guid(2811717435, 42421, 16708, 181, 37, 230, 140, 136, 98, 102, 75)]
  internal interface IOfflineMapPackage
  {
    OfflineMapPackageStatus Status { get; }

    string DisplayName { get; }

    string EnclosingRegionName { get; }

    ulong EstimatedSizeInBytes { get; }

    event TypedEventHandler<OfflineMapPackage, object> StatusChanged;

    [RemoteAsync]
    IAsyncOperation<OfflineMapPackageStartDownloadResult> RequestStartDownloadAsync();
  }
}
