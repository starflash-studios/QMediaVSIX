// Decompiled with JetBrains decompiler
// Type: Windows.Networking.NetworkOperators.IMobileBroadbandCellLte
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Networking.NetworkOperators
{
  [ExclusiveTo(typeof (MobileBroadbandCellLte))]
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  [Guid(2442643579, 11128, 17773, 139, 83, 170, 162, 93, 10, 247, 65)]
  internal interface IMobileBroadbandCellLte
  {
    IReference<int> CellId { get; }

    IReference<int> ChannelNumber { get; }

    IReference<int> PhysicalCellId { get; }

    string ProviderId { get; }

    IReference<double> ReferenceSignalReceivedPowerInDBm { get; }

    IReference<double> ReferenceSignalReceivedQualityInDBm { get; }

    IReference<int> TimingAdvanceInBitPeriods { get; }

    IReference<int> TrackingAreaCode { get; }
  }
}
