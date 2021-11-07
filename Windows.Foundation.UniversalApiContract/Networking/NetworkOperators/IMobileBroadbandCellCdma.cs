// Decompiled with JetBrains decompiler
// Type: Windows.Networking.NetworkOperators.IMobileBroadbandCellCdma
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Networking.NetworkOperators
{
  [Guid(100774836, 16666, 20270, 130, 135, 118, 245, 101, 12, 96, 205)]
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  [ExclusiveTo(typeof (MobileBroadbandCellCdma))]
  internal interface IMobileBroadbandCellCdma
  {
    IReference<int> BaseStationId { get; }

    IReference<int> BaseStationPNCode { get; }

    IReference<double> BaseStationLatitude { get; }

    IReference<double> BaseStationLongitude { get; }

    IReference<TimeSpan> BaseStationLastBroadcastGpsTime { get; }

    IReference<int> NetworkId { get; }

    IReference<double> PilotSignalStrengthInDB { get; }

    IReference<int> SystemId { get; }
  }
}
