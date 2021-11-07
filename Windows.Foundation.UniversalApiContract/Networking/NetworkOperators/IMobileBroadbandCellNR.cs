// Decompiled with JetBrains decompiler
// Type: Windows.Networking.NetworkOperators.IMobileBroadbandCellNR
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Networking.NetworkOperators
{
  [Guid(2705264107, 26364, 19275, 131, 169, 164, 135, 163, 165, 160, 166)]
  [ContractVersion(typeof (UniversalApiContract), 786432)]
  [ExclusiveTo(typeof (MobileBroadbandCellNR))]
  internal interface IMobileBroadbandCellNR
  {
    IReference<long> CellId { get; }

    IReference<int> ChannelNumber { get; }

    IReference<int> PhysicalCellId { get; }

    string ProviderId { get; }

    IReference<double> ReferenceSignalReceivedPowerInDBm { get; }

    IReference<double> ReferenceSignalReceivedQualityInDBm { get; }

    IReference<int> TimingAdvanceInNanoseconds { get; }

    IReference<int> TrackingAreaCode { get; }

    IReference<double> SignalToNoiseRatioInDB { get; }
  }
}
