// Decompiled with JetBrains decompiler
// Type: Windows.Networking.NetworkOperators.MobileBroadbandCellLte
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Networking.NetworkOperators
{
  /// <summary>Represents LTE network provider/cell information including identifications as well as its respective signal strength.</summary>
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  public sealed class MobileBroadbandCellLte : IMobileBroadbandCellLte
  {
    /// <summary>Gets the cell ID.</summary>
    /// <returns>The cell ID.</returns>
    public extern IReference<int> CellId { [MethodImpl] get; }

    /// <summary>Gets the UNTRA Absolute Radio Frequency Channel Number for serving cell.</summary>
    /// <returns>The UNTRA Absolute Radio Frequency Channel Number for serving cell.</returns>
    public extern IReference<int> ChannelNumber { [MethodImpl] get; }

    /// <summary>Gets the pysical cell ID.</summary>
    /// <returns>The cell ID.</returns>
    public extern IReference<int> PhysicalCellId { [MethodImpl] get; }

    /// <summary>Gets a concatenated string of MCC and MNC.</summary>
    /// <returns>The provider ID.</returns>
    public extern string ProviderId { [MethodImpl] get; }

    /// <summary>Gets the average Reference Signal Received Power in dBm.</summary>
    /// <returns>The average Reference Signal Received Power in dBm.</returns>
    public extern IReference<double> ReferenceSignalReceivedPowerInDBm { [MethodImpl] get; }

    /// <summary>Gets the average Reference Signal Received Quality in dBm.</summary>
    /// <returns>The average Reference Signal Received Quality in dBm.</returns>
    public extern IReference<double> ReferenceSignalReceivedQualityInDBm { [MethodImpl] get; }

    /// <summary>Gets the Timing Advance in bit periods, where a bit period is 48/13us.</summary>
    /// <returns>The Timing Advance in bit periods.</returns>
    public extern IReference<int> TimingAdvanceInBitPeriods { [MethodImpl] get; }

    /// <summary>Gets the Tracking Area Code.</summary>
    /// <returns>The Tracking Area Code.</returns>
    public extern IReference<int> TrackingAreaCode { [MethodImpl] get; }
  }
}
