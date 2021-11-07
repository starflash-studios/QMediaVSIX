// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Geolocation.PositionSource
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Geolocation
{
  /// <summary>Indicates the source used to obtain a Geocoordinate.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum PositionSource
  {
    /// <summary>The position was obtained from cellular network data.</summary>
    Cellular,
    /// <summary>The position was obtained from satellite data.</summary>
    Satellite,
    /// <summary>The position was obtained from Wi-Fi network data.</summary>
    WiFi,
    /// <summary>(Starting with Windows 8.1.) The position was obtained from an IP address.</summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] IPAddress,
    /// <summary>(Starting with Windows 8.1.) The position was obtained from an unknown source.</summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] Unknown,
    /// <summary>(Starting with Windows 10, version 1607.) The position was obtained from the user's manually-set location.</summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 196608)] Default,
    /// <summary>(Starting with Windows 10, version 1607.) The position was obtained via the coarse location feature and was therefore intentionally made inaccurate to a degree.</summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 196608)] Obfuscated,
  }
}
