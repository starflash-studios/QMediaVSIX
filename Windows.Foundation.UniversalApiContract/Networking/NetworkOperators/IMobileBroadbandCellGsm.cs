// Decompiled with JetBrains decompiler
// Type: Windows.Networking.NetworkOperators.IMobileBroadbandCellGsm
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Networking.NetworkOperators
{
  [ExclusiveTo(typeof (MobileBroadbandCellGsm))]
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  [Guid(3432087302, 32480, 18360, 158, 31, 195, 180, 141, 249, 223, 91)]
  internal interface IMobileBroadbandCellGsm
  {
    IReference<int> BaseStationId { get; }

    IReference<int> CellId { get; }

    IReference<int> ChannelNumber { get; }

    IReference<int> LocationAreaCode { get; }

    string ProviderId { get; }

    IReference<double> ReceivedSignalStrengthInDBm { get; }

    IReference<int> TimingAdvanceInBitPeriods { get; }
  }
}
