// Decompiled with JetBrains decompiler
// Type: Windows.Networking.NetworkOperators.MobileBroadbandAntennaSar
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Networking.NetworkOperators
{
  /// <summary>Represents the antenna on a broadband modem.</summary>
  [Activatable(typeof (IMobileBroadbandAntennaSarFactory), 393216, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class MobileBroadbandAntennaSar : IMobileBroadbandAntennaSar
  {
    /// <summary>Creates a new instance of a MobileBroadbandAntennaSar.</summary>
    /// <param name="antennaIndex">The identifier number of the antenna, in the form of a unique, zero-based index.</param>
    /// <param name="sarBackoffIndex">The OEM/IHV-variant value for SAR backoff, in the form of an index entry in the device OEM/IHV's mapping table.</param>
    [MethodImpl]
    public extern MobileBroadbandAntennaSar(int antennaIndex, int sarBackoffIndex);

    /// <summary>Gets the identifier number of the antenna, in the form of a unique, zero-based index.</summary>
    /// <returns>The identifier number of the antenna, as a zero-based index.</returns>
    public extern int AntennaIndex { [MethodImpl] get; }

    /// <summary>Gets the OEM/IHV-variant value for SAR backoff, in the form of an index entry in the device OEM/IHV's mapping table.</summary>
    /// <returns>The index entry for the SAR backoff value.</returns>
    public extern int SarBackoffIndex { [MethodImpl] get; }
  }
}
