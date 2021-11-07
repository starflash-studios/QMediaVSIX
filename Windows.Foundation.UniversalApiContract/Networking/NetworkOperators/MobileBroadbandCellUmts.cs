// Decompiled with JetBrains decompiler
// Type: Windows.Networking.NetworkOperators.MobileBroadbandCellUmts
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Networking.NetworkOperators
{
  /// <summary>Represents UMTS network provider/cell information including identifications as well as its respective signal strength.</summary>
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class MobileBroadbandCellUmts : IMobileBroadbandCellUmts
  {
    /// <summary>Gets the cell ID.</summary>
    /// <returns>The cell ID.</returns>
    public extern IReference<int> CellId { [MethodImpl] get; }

    /// <summary>Gets the UTRAN Absolute Radio Frequency Channel Number for serving cell.</summary>
    /// <returns>The UTRAN Absolute Radio Frequency Channel Number for serving cell.</returns>
    public extern IReference<int> ChannelNumber { [MethodImpl] get; }

    /// <summary>Gets the Location Area Code (LAC).</summary>
    /// <returns>The Location Area Code (LAC).</returns>
    public extern IReference<int> LocationAreaCode { [MethodImpl] get; }

    /// <summary>Gets the path loss in dB. </summary>
    /// <returns>The path loss in dB.</returns>
    public extern IReference<double> PathLossInDB { [MethodImpl] get; }

    /// <summary>Gets the primary scrambling code of serving cell.</summary>
    /// <returns>The primary scrambling code of serving cell.</returns>
    public extern IReference<int> PrimaryScramblingCode { [MethodImpl] get; }

    /// <summary>Gets a concatenated string of MCC and MNC.</summary>
    /// <returns>The provider ID.</returns>
    public extern string ProviderId { [MethodImpl] get; }

    /// <summary>Gets the received signal code power in dBm. </summary>
    /// <returns>The received signal code power in dBm.</returns>
    public extern IReference<double> ReceivedSignalCodePowerInDBm { [MethodImpl] get; }

    /// <summary>Gets the signal to noise ratio in dB. </summary>
    /// <returns>The received signal code power in dBm.</returns>
    public extern IReference<double> SignalToNoiseRatioInDB { [MethodImpl] get; }
  }
}
