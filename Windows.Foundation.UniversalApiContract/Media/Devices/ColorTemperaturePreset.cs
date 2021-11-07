// Decompiled with JetBrains decompiler
// Type: Windows.Media.Devices.ColorTemperaturePreset
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Devices
{
  /// <summary>Defines the values for the possible color temperature presets.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum ColorTemperaturePreset
  {
    /// <summary>Indicates that the color temperature is set automatically.</summary>
    Auto,
    /// <summary>Indicates that the color temperature is set manually.</summary>
    Manual,
    /// <summary>Indicates that the color temperature is adjusted for a cloudy scene.</summary>
    Cloudy,
    /// <summary>Indicates that the color temperature is adjusted for a daylight scene.</summary>
    Daylight,
    /// <summary>Indicates that the color temperature is adjusted for a scene lit by a flash.</summary>
    Flash,
    /// <summary>Indicates that the color temperature is adjusted for a scene lit by fluorescent light.</summary>
    Fluorescent,
    /// <summary>Indicates that the color temperature is adjusted for a scene lit by tungsten light.</summary>
    Tungsten,
    /// <summary>Indicates that the color temperature is adjusted for a scene lit by candlelight.</summary>
    Candlelight,
  }
}
