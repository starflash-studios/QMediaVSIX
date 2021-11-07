// Decompiled with JetBrains decompiler
// Type: Windows.Networking.NetworkOperators.MobileBroadbandCellNR
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Networking.NetworkOperators
{
  [ContractVersion(typeof (UniversalApiContract), 786432)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class MobileBroadbandCellNR : IMobileBroadbandCellNR
  {
    public extern IReference<long> CellId { [MethodImpl] get; }

    public extern IReference<int> ChannelNumber { [MethodImpl] get; }

    public extern IReference<int> PhysicalCellId { [MethodImpl] get; }

    public extern string ProviderId { [MethodImpl] get; }

    public extern IReference<double> ReferenceSignalReceivedPowerInDBm { [MethodImpl] get; }

    public extern IReference<double> ReferenceSignalReceivedQualityInDBm { [MethodImpl] get; }

    public extern IReference<int> TimingAdvanceInNanoseconds { [MethodImpl] get; }

    public extern IReference<int> TrackingAreaCode { [MethodImpl] get; }

    public extern IReference<double> SignalToNoiseRatioInDB { [MethodImpl] get; }
  }
}
