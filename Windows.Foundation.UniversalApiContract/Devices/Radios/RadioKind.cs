// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Radios.RadioKind
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Radios
{
  /// <summary>Enumeration that represents the kinds of radio devices.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum RadioKind
  {
    /// <summary>An unspecified kind of radio device.</summary>
    Other,
    /// <summary>A Wi-Fi radio.</summary>
    WiFi,
    /// <summary>A mobile broadband radio. </summary>
    MobileBroadband,
    /// <summary>A Bluetooth radio.</summary>
    Bluetooth,
    /// <summary>An FM radio. </summary>
    FM,
  }
}
