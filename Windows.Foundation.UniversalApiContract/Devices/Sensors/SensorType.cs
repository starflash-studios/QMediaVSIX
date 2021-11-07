// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Sensors.SensorType
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Sensors
{
  /// <summary>Indicates the type of sensor.</summary>
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  public enum SensorType
  {
    /// <summary>An Accelerometer.</summary>
    Accelerometer,
    /// <summary>An ActivitySensor.</summary>
    ActivitySensor,
    /// <summary>A Barometer.</summary>
    Barometer,
    /// <summary>A Compass.</summary>
    Compass,
    /// <summary>A custom sensor.</summary>
    CustomSensor,
    /// <summary>A Gyrometer.</summary>
    Gyroscope,
    /// <summary>A ProximitySensor.</summary>
    ProximitySensor,
    /// <summary>An Inclinometer.</summary>
    Inclinometer,
    /// <summary>A LightSensor.</summary>
    LightSensor,
    /// <summary>An OrientationSensor.</summary>
    OrientationSensor,
    /// <summary>A Pedometer.</summary>
    Pedometer,
    /// <summary>A relative Inclinometer.</summary>
    RelativeInclinometer,
    /// <summary>A relative OrientationSensor.</summary>
    RelativeOrientationSensor,
    /// <summary>A SimpleOrientationSensor.</summary>
    SimpleOrientationSensor,
  }
}
