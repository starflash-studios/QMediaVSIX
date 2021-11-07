// Decompiled with JetBrains decompiler
// Type: Windows.Services.Maps.OfflineMaps.IOfflineMapPackageQueryResult
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Services.Maps.OfflineMaps
{
  [Guid(1431852049, 14817, 20033, 164, 225, 95, 72, 114, 190, 225, 153)]
  [ExclusiveTo(typeof (OfflineMapPackageQueryResult))]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  internal interface IOfflineMapPackageQueryResult
  {
    OfflineMapPackageQueryStatus Status { get; }

    IVectorView<OfflineMapPackage> Packages { get; }
  }
}
