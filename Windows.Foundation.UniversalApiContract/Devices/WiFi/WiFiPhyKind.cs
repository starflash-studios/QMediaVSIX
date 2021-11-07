// Decompiled with JetBrains decompiler
// Type: Windows.Devices.WiFi.WiFiPhyKind
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.WiFi
{
  /// <summary>Describes PHY types supported by standard 802.11.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum WiFiPhyKind
  {
    /// <summary>Unspecified PHY type</summary>
    Unknown,
    /// <summary>Frequency-hopping, spread-spectrum (FHSS) PHY.</summary>
    Fhss,
    /// <summary>Direct sequence, spread-spectrum (DSSS) PHY.</summary>
    Dsss,
    /// <summary>Infrared (IR) baseband PHY.</summary>
    IRBaseband,
    /// <summary>Orthogonal frequency division multiplex (OFDM) PHY.</summary>
    Ofdm,
    /// <summary>High-rated DSSS (HRDSSS) PHY.</summary>
    Hrdsss,
    /// <summary>Extended Rate (ERP) PHY.</summary>
    Erp,
    /// <summary>High Throughput (HT) PHY for 802.11n PHY.</summary>
    HT,
    /// <summary>Very High Throughput (VHT) PHY for 802.11ac PHY.</summary>
    Vht,
    /// <summary>Directional multi-gigabit (DMG) PHY for 802.11ad.</summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 196608)] Dmg,
    /// <summary>High-Efficiency Wireless (HEW) PHY for 802.11ax.</summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 458752)] HE,
  }
}
