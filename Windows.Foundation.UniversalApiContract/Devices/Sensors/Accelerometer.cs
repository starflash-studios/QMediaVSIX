// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Sensors.Accelerometer
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Graphics.Display;

namespace Windows.Devices.Sensors
{
  /// <summary>Represents an accelerometer sensor.</summary>
  [Static(typeof (IAccelerometerStatics3), 327680, "Windows.Foundation.UniversalApiContract")]
  [DualApiPartition(version = 100794368)]
  [Static(typeof (IAccelerometerStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Static(typeof (IAccelerometerStatics2), 196608, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class Accelerometer : 
    IAccelerometer,
    IAccelerometerDeviceId,
    IAccelerometer2,
    IAccelerometer3,
    IAccelerometer4,
    IAccelerometer5
  {
    /// <summary>Gets the current accelerometer reading.</summary>
    /// <returns>This method has no parameters.</returns>
    [MethodImpl]
    public extern AccelerometerReading GetCurrentReading();

    /// <summary>Gets the minimum report interval supported by the accelerometer.</summary>
    /// <returns>The minimum ReportInterval supported by the sensor.</returns>
    public extern uint MinimumReportInterval { [MethodImpl] get; }

    /// <summary>Gets or sets the current report interval for the accelerometer.</summary>
    /// <returns>The current report interval.</returns>
    public extern uint ReportInterval { [MethodImpl] set; [MethodImpl] get; }

    /// <summary>Occurs each time the accelerometer reports a new sensor reading.</summary>
    public extern event TypedEventHandler<Accelerometer, AccelerometerReadingChangedEventArgs> ReadingChanged;

    /// <summary>Occurs when the accelerometer detects that the PC has been shaken.</summary>
    public extern event TypedEventHandler<Accelerometer, AccelerometerShakenEventArgs> Shaken;

    /// <summary>Gets the device identifier.</summary>
    /// <returns>The device identifier.</returns>
    public extern string DeviceId { [MethodImpl] get; }

    /// <summary>Gets or sets the transformation that needs to be applied to sensor data. Transformations to be applied are tied to the display orientation with which to align the sensor data.</summary>
    /// <returns>A DisplayOrientations -typed value that specifies the display orientation with which to align the sensor data.</returns>
    public extern DisplayOrientations ReadingTransform { [MethodImpl] set; [MethodImpl] get; }

    /// <summary>Gets or sets the delay between batches of sensor information.</summary>
    /// <returns>The delay between batches of sensor information in milliseconds.</returns>
    public extern uint ReportLatency { [MethodImpl] set; [MethodImpl] get; }

    /// <summary>Gets the maximum number of events that can be batched by the sensor.</summary>
    /// <returns>The maximum number of batched events.</returns>
    public extern uint MaxBatchSize { [MethodImpl] get; }

    /// <summary>Gets the type of accelerometer sensor the is represented by this object.</summary>
    /// <returns>The type of accelerometer.</returns>
    public extern AccelerometerReadingType ReadingType { [MethodImpl] get; }

    /// <summary>Gets the AccelerometerDataThreshold for the accelerometer sensor.</summary>
    /// <returns>
    /// </returns>
    public extern AccelerometerDataThreshold ReportThreshold { [MethodImpl] get; }

    /// <summary>Asynchronously obtains the sensor from its identifier.</summary>
    /// <param name="deviceId">The sensor identifier</param>
    /// <returns>Returns the Accelerometer object from its identifier.</returns>
    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<Accelerometer> FromIdAsync(
      string deviceId);

    /// <summary>Gets the device selector.</summary>
    /// <param name="readingType">The type of sensor to retrieve.</param>
    /// <returns>Returns the device selector, if it exists; otherwise, null.</returns>
    [MethodImpl]
    public static extern string GetDeviceSelector(AccelerometerReadingType readingType);

    /// <summary>Returns the default accelerometer of a specific type of sensor. The possible accelerometer sensors are defined by AccelerometerReadingType.</summary>
    /// <param name="readingType">Indicates the type of accelerometer to retrieve.</param>
    /// <returns>The default accelerometer or **null** if no integrated accelerometers are found.</returns>
    [Overload("GetDefaultWithAccelerometerReadingType")]
    [MethodImpl]
    public static extern Accelerometer GetDefault(AccelerometerReadingType readingType);

    /// <summary>Returns the default accelerometer.</summary>
    /// <returns>The default accelerometer or null if no integrated accelerometers are found.</returns>
    [Overload("GetDefault")]
    [MethodImpl]
    public static extern Accelerometer GetDefault();
  }
}
