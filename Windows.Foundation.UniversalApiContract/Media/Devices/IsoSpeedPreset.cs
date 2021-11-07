// Decompiled with JetBrains decompiler
// Type: Windows.Media.Devices.IsoSpeedPreset
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Devices
{
  /// <summary>Defines the possible values for ISO speed presets.</summary>
  /// <deprecated type="deprecate">IsoSpeedPreset may not be available in future versions of Windows Phone. Starting with Windows Phone 8.1, use SetAutoAsync, Auto, SetValueAsync, and Value instead</deprecated>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Deprecated("IsoSpeedPreset may not be available in future versions of Windows Phone. Starting with Windows Phone 8.1, use SetAutoAsync, Auto, SetValueAsync, and Value instead", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract")]
  public enum IsoSpeedPreset
  {
    /// <summary>The film speed is automatically set.</summary>
    Auto,
    /// <summary>The film speed is set to 50 ISO.</summary>
    Iso50,
    /// <summary>The film speed is set to 80 ISO.</summary>
    Iso80,
    /// <summary>The film speed is set to 100 ISO.</summary>
    Iso100,
    /// <summary>The film speed is set to 200 ISO.</summary>
    Iso200,
    /// <summary>The film speed is set to 400 ISO.</summary>
    Iso400,
    /// <summary>The film speed is set to 800 ISO.</summary>
    Iso800,
    /// <summary>The film speed is set to 1600 ISO.</summary>
    Iso1600,
    /// <summary>The film speed is set to 3200 ISO.</summary>
    Iso3200,
    /// <summary>The film speed is set to 6400 ISO.</summary>
    Iso6400,
    /// <summary>The film speed is set to 12800 ISO.</summary>
    Iso12800,
    /// <summary>The film speed is set to 25600 ISO.</summary>
    Iso25600,
  }
}
