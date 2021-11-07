// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Sensors.AccelerometerReadingType
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Sensors
{
  /// <summary>Indicates the type of accelerometer.</summary>
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  public enum AccelerometerReadingType
  {
    /// <summary>A standard accelerometer takes into account all of the forces impacting the sensor.</summary>
    Standard,
    /// <summary>A linear accelerometer does not take into account the influence of gravity.</summary>
    Linear,
    /// <summary>A gravity accelerometer is only interested in the influence of gravity on a sensor.</summary>
    Gravity,
  }
}
