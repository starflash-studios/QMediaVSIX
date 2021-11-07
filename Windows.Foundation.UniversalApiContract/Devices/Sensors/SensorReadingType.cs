// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Sensors.SensorReadingType
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Sensors
{
  /// <summary>Specifies the sensor reading type.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum SensorReadingType
  {
    /// <summary>The sensor reading type is absolute. **Absolute** sensors provide a reading that uses all of the sensors available.</summary>
    Absolute,
    /// <summary>The sensor reading type is relative. **Relative** sensors provide a reading that is accurate under most conditions, but might not be as accurate as it attempts to not use all sensors available. See the Remarks for more information.</summary>
    Relative,
  }
}
