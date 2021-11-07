// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Radios.RadioState
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Radios
{
  /// <summary>Enumeration that describes possible radio states.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum RadioState
  {
    /// <summary>The radio state is unknown, or the radio is in a bad or uncontrollable state.</summary>
    Unknown,
    /// <summary>The radio is powered on.</summary>
    On,
    /// <summary>The radio is powered off.</summary>
    Off,
    /// <summary>The radio is powered off and disabled by the device firmware or a hardware switch on the device.</summary>
    Disabled,
  }
}
