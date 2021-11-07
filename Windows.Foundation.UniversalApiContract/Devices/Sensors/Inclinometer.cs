// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Sensors.Inclinometer
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Graphics.Display;

namespace Windows.Devices.Sensors
{
  /// <summary>Represents an inclinometer sensor.</summary>
  [Static(typeof (IInclinometerStatics4), 327680, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [DualApiPartition(version = 100794368)]
  [Static(typeof (IInclinometerStatics3), 196608, "Windows.Foundation.UniversalApiContract")]
  [Static(typeof (IInclinometerStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [Static(typeof (IInclinometerStatics2), 65536, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  public sealed class Inclinometer : 
    IInclinometer,
    IInclinometerDeviceId,
    IInclinometer2,
    IInclinometer3,
    IInclinometer4
  {
    /// <summary>Gets the current inclinometer reading.</summary>
    /// <returns>The current inclinometer reading.</returns>
    [MethodImpl]
    public extern InclinometerReading GetCurrentReading();

    /// <summary>Gets the minimum report interval supported by the inclinometer.</summary>
    /// <returns>The minimum ReportInterval supported by the sensor.</returns>
    public extern uint MinimumReportInterval { [MethodImpl] get; }

    /// <summary>Gets or sets the current report interval for the inclinometer.</summary>
    /// <returns>The current report interval.</returns>
    public extern uint ReportInterval { [MethodImpl] set; [MethodImpl] get; }

    /// <summary>Occurs each time the inclinometer reports a new sensor reading.</summary>
    public extern event TypedEventHandler<Inclinometer, InclinometerReadingChangedEventArgs> ReadingChanged;

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

    /// <summary>Gets the InclinometerDataThreshold for the gyrometer sensor.</summary>
    /// <returns>
    /// </returns>
    public extern InclinometerDataThreshold ReportThreshold { [MethodImpl] get; }

    /// <summary>Gets the device selector.</summary>
    /// <param name="readingType">The type of sensor to retrieve.</param>
    /// <returns>Returns the device selector, if it exists; otherwise, null.</returns>
    [MethodImpl]
    public static extern string GetDeviceSelector(SensorReadingType readingType);

    /// <summary>Asynchronously obtains the sensor from its identifier.</summary>
    /// <param name="deviceId">The sensor identifier</param>
    /// <returns>Returns the Inclinometer object from its identifier.</returns>
    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<Inclinometer> FromIdAsync(
      string deviceId);

    /// <summary>Returns the default inclinometer based on the SensorReadingType.</summary>
    /// <param name="sensorReadingtype">The type of sensor to retrieve.</param>
    /// <returns>The default inclinometer or **null** if no inclinometers are found.</returns>
    [Overload("GetDefaultWithSensorReadingType")]
    [MethodImpl]
    public static extern Inclinometer GetDefault(SensorReadingType sensorReadingtype);

    /// <summary>Returns the default inclinometer for relative readings.</summary>
    /// <returns>The default inclinometer or null if no inclinometers are found.</returns>
    [MethodImpl]
    public static extern Inclinometer GetDefaultForRelativeReadings();

    /// <summary>Returns the default inclinometer for absolute readings.</summary>
    /// <returns>The default inclinometer or null if no inclinometers are found.</returns>
    [MethodImpl]
    public static extern Inclinometer GetDefault();
  }
}
