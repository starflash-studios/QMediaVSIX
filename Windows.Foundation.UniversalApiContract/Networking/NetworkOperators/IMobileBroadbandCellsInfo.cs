// Decompiled with JetBrains decompiler
// Type: Windows.Networking.NetworkOperators.IMobileBroadbandCellsInfo
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Networking.NetworkOperators
{
  [Guid(2309576234, 58482, 19877, 146, 156, 222, 97, 113, 29, 210, 97)]
  [ExclusiveTo(typeof (MobileBroadbandCellsInfo))]
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  internal interface IMobileBroadbandCellsInfo
  {
    IVectorView<MobileBroadbandCellCdma> NeighboringCellsCdma { get; }

    IVectorView<MobileBroadbandCellGsm> NeighboringCellsGsm { get; }

    IVectorView<MobileBroadbandCellLte> NeighboringCellsLte { get; }

    IVectorView<MobileBroadbandCellTdscdma> NeighboringCellsTdscdma { get; }

    IVectorView<MobileBroadbandCellUmts> NeighboringCellsUmts { get; }

    IVectorView<MobileBroadbandCellCdma> ServingCellsCdma { get; }

    IVectorView<MobileBroadbandCellGsm> ServingCellsGsm { get; }

    IVectorView<MobileBroadbandCellLte> ServingCellsLte { get; }

    IVectorView<MobileBroadbandCellTdscdma> ServingCellsTdscdma { get; }

    IVectorView<MobileBroadbandCellUmts> ServingCellsUmts { get; }
  }
}
