// Decompiled with JetBrains decompiler
// Type: Windows.Networking.NetworkOperators.IMobileBroadbandCellTdscdma
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Networking.NetworkOperators
{
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  [Guid(249173589, 56078, 16770, 140, 218, 204, 65, 154, 123, 222, 8)]
  [ExclusiveTo(typeof (MobileBroadbandCellTdscdma))]
  internal interface IMobileBroadbandCellTdscdma
  {
    IReference<int> CellId { get; }

    IReference<int> CellParameterId { get; }

    IReference<int> ChannelNumber { get; }

    IReference<int> LocationAreaCode { get; }

    IReference<double> PathLossInDB { get; }

    string ProviderId { get; }

    IReference<double> ReceivedSignalCodePowerInDBm { get; }

    IReference<int> TimingAdvanceInBitPeriods { get; }
  }
}
