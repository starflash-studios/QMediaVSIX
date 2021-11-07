// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Sensors.OrientationSensor
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Graphics.Display;

namespace Windows.Devices.Sensors
{
  /// <summary>Represents an orientation sensor.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [Static(typeof (IOrientationSensorStatics4), 327680, "Windows.Foundation.UniversalApiContract")]
  [Static(typeof (IOrientationSensorStatics2), 65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Static(typeof (IOrientationSensorStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [Static(typeof (IOrientationSensorStatics3), 196608, "Windows.Foundation.UniversalApiContract")]
  [DualApiPartition(version = 100794368)]
  [Threading(ThreadingModel.Both)]
  public sealed class OrientationSensor : 
    IOrientationSensor,
    IOrientationSensorDeviceId,
    IOrientationSensor2,
    IOrientationSensor3
  {
    /// <summary>Gets the current sensor reading.</summary>
    /// <returns>The current sensor reading.</returns>
    [MethodImpl]
    public extern OrientationSensorReading GetCurrentReading();

    /// <summary>Gets the minimum report interval supported by the sensor.</summary>
    /// <returns>The minimum ReportInterval supported by the sensor.</returns>
    public extern uint MinimumReportInterval { [MethodImpl] get; }

    /// <summary>Gets or sets the report interval supported by the sensor.</summary>
    /// <returns>The report interval supported by the sensor.</returns>
    public extern uint ReportInterval { [MethodImpl] set; [MethodImpl] get; }

    /// <summary>Occurs each time the orientation sensor reports a new sensor reading.</summary>
    public extern event TypedEventHandler<OrientationSensor, OrientationSensorReadingChangedEventArgs> ReadingChanged;

    /// <summary>Gets the device identifier.</summary>
    /// <returns>The device identifier.</returns>
    public extern string DeviceId { [MethodImpl] get; }

    /// <summary>Gets or sets the transformation that needs to be applied to sensor data. Transformations to be applied are tied to the display orientation with which to align the sensor data.</summary>
    /// <returns>A DisplayOrientations -typed value that specifies the display orientation with which to align the sensor data.</returns>
    public extern DisplayOrientations ReadingTransform { [MethodImpl] set; [MethodImpl] get; }

    /// <summary>Gets the sensor reading type.</summary>
    /// <returns>A SensorReadingType -typed value that specifies the sensor reading type.</returns>
    public extern SensorReadingType ReadingType { [MethodImpl] get; }

    /// <summary>Gets or sets the delay between batches of sensor information.</summary>
    /// <returns>The delay between batches of sensor information in milliseconds.</returns>
    public extern uint ReportLatency { [MethodImpl] set; [MethodImpl] get; }

    /// <summary>Gets the maximum number of events that can be batched by the sensor.</summary>
    /// <returns>The maximum number of batched events.</returns>
    public extern uint MaxBatchSize { [MethodImpl] get; }

    /// <summary>Gets the device selector.</summary>
    /// <param name="readingType">The type of sensor to retrieve.</param>
    /// <returns>Returns the device selector, if it exists; otherwise, null.</returns>
    [Overload("GetDeviceSelector")]
    [MethodImpl]
    public static extern string GetDeviceSelector(SensorReadingType readingType);

    /// <summary>Gets the device selector.</summary>
    /// <param name="readingType">The type of sensor to retrieve. An Absolute SensorReadingType returns an OrientationSensor using an accelerometer, a gyromoter, and magnetometer to determine the orientation with respect to magnetic North. A Relative SensorReadingType returns an OrientationSensor using an accelerometer and gyrometer only (no magnetometer), measuring relative to where the sensor was first instantiated.</param>
    /// <param name="optimizationGoal">Indicates the preferences of optimization for the sensor. This field is only used if an Absolute SensorReadingType is specified. An optimizationGoal of Precision will return an OrientationSensor using an accelereometer, a gyrometer, and a magnetometer to determine orientation with respect to magnetic North. This has the potential to use a lot of power due to it’s use of a gyrometer.</param>
    /// <returns>Returns the device selector, if it exists; otherwise, null.</returns>
    [Overload("GetDeviceSelectorWithSensorReadingTypeAndSensorOptimizationGoal")]
    [MethodImpl]
    public static extern string GetDeviceSelector(
      SensorReadingType readingType,
      SensorOptimizationGoal optimizationGoal);

    /// <summary>Asynchronously obtains the sensor from its identifier.</summary>
    /// <param name="deviceId">The sensor identifier</param>
    /// <returns>Returns the OrientationSensor object from its identifier.</returns>
    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<OrientationSensor> FromIdAsync(
      string deviceId);

    /// <summary>Returns the default orientation sensor, taking into account accuracy preferences.</summary>
    /// <param name="sensorReadingtype">The type of sensor to retrieve. An Absolute SensorReadingType returns an OrientationSensor using an accelerometer, a gyromoter, and magnetometer to determine the orientation with respect to magnetic North. A Relative SensorReadingType returns an OrientationSensor using an accelerometer and gyrometer only (no magnetometer), measuring relative to where the sensor was first instantiated.”</param>
    /// <returns>The default orientation sensor or **null** if no orientation sensors are found.</returns>
    [Overload("GetDefaultWithSensorReadingType")]
    [MethodImpl]
    public static extern OrientationSensor GetDefault(
      SensorReadingType sensorReadingtype);

    /// <summary>Returns the default orientation sensor, taking into account power and accuracy preferences.</summary>
    /// <param name="sensorReadingType">The type of sensor to retrieve. An Absolute SensorReadingType returns an OrientationSensor using an accelerometer, a gyromoter, and magnetometer to determine the orientation with respect to magnetic North. A Relative SensorReadingType returns an OrientationSensor using an accelerometer and gyrometer only (no magnetometer), measuring relative to where the sensor was first instantiated.</param>
    /// <param name="optimizationGoal">Indicates the preferences of optimization for the sensor. This field is only used if an Absolute SensorReadingType is specified. An optimizationGoal of Precision will return an OrientationSensor using an accelereometer, a gyrometer, and a magnetometer to determine orientation with respect to magnetic North. This has the potential to use a lot of power due to it’s use of a gyrometer.</param>
    /// <returns>The default orientation sensor or **null** if no orientation sensors are found.</returns>
    [Overload("GetDefaultWithSensorReadingTypeAndSensorOptimizationGoal")]
    [MethodImpl]
    public static extern OrientationSensor GetDefault(
      SensorReadingType sensorReadingType,
      SensorOptimizationGoal optimizationGoal);

    /// <summary>Returns the default orientation sensor for relative readings.</summary>
    /// <returns>The default orientation sensor or null if no orientation sensors are found.</returns>
    [MethodImpl]
    public static extern OrientationSensor GetDefaultForRelativeReadings();

    /// <summary>Returns the default orientation sensor for absolute readings.</summary>
    /// <returns>The default orientation sensor or **null** if no orientation sensors are found.</returns>
    [Overload("GetDefault")]
    [MethodImpl]
    public static extern OrientationSensor GetDefault();
  }
}
