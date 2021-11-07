// Decompiled with JetBrains decompiler
// Type: Windows.Networking.NetworkOperators.MobileBroadbandCellCdma
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Networking.NetworkOperators
{
  /// <summary>Represents CDMA network provider/cell information including identifications as well as its respective signal strength.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  public sealed class MobileBroadbandCellCdma : IMobileBroadbandCellCdma
  {
    /// <summary>Gets the base station ID. </summary>
    /// <returns>The base station ID.</returns>
    public extern IReference<int> BaseStationId { [MethodImpl] get; }

    /// <summary>Gets the base station PN Number. </summary>
    /// <returns>The base station PN Number.</returns>
    public extern IReference<int> BaseStationPNCode { [MethodImpl] get; }

    /// <summary>Gets the base station latitude.</summary>
    /// <returns>The base station latitude.</returns>
    public extern IReference<double> BaseStationLatitude { [MethodImpl] get; }

    /// <summary>Gets the base station longitude.</summary>
    /// <returns>The base station longitude.</returns>
    public extern IReference<double> BaseStationLongitude { [MethodImpl] get; }

    /// <summary>Gets the time elapsed since the location information from base station reached mobile station.</summary>
    /// <returns>The time elapsed since the location information from base station reached mobile station.</returns>
    public extern IReference<TimeSpan> BaseStationLastBroadcastGpsTime { [MethodImpl] get; }

    /// <summary>Gets the network ID in CDMA only.</summary>
    /// <returns>The network ID in CDMA</returns>
    public extern IReference<int> NetworkId { [MethodImpl] get; }

    /// <summary>Gets the pilot signal strength in dB. </summary>
    /// <returns>The pilot signal strength in dB.</returns>
    public extern IReference<double> PilotSignalStrengthInDB { [MethodImpl] get; }

    /// <summary>Gets the system ID in CDMA only.</summary>
    /// <returns>The system ID in CDMA</returns>
    public extern IReference<int> SystemId { [MethodImpl] get; }
  }
}
