// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Sensors.Gyrometer
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Graphics.Display;

namespace Windows.Devices.Sensors
{
  /// <summary>Represents a gyrometer sensor.</summary>
  [DualApiPartition(version = 100794368)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Static(typeof (IGyrometerStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [Static(typeof (IGyrometerStatics2), 327680, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  public sealed class Gyrometer : 
    IGyrometer,
    IGyrometerDeviceId,
    IGyrometer2,
    IGyrometer3,
    IGyrometer4
  {
    /// <summary>Gets the current gyrometer reading.</summary>
    /// <returns>This method has no parameters.</returns>
    [MethodImpl]
    public extern GyrometerReading GetCurrentReading();

    /// <summary>Gets the minimum report interval supported by the gyrometer.</summary>
    /// <returns>The minimum ReportInterval supported by the sensor.</returns>
    public extern uint MinimumReportInterval { [MethodImpl] get; }

    /// <summary>Gets or sets the current report interval for the gyrometer.</summary>
    /// <returns>The current report interval.</returns>
    public extern uint ReportInterval { [MethodImpl] set; [MethodImpl] get; }

    /// <summary>Occurs each time the gyrometer reports the current sensor reading.</summary>
    public extern event TypedEventHandler<Gyrometer, GyrometerReadingChangedEventArgs> ReadingChanged;

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

    /// <summary>Gets the GyrometerDataThreshold for the gyrometer sensor.</summary>
    /// <returns>
    /// </returns>
    public extern GyrometerDataThreshold ReportThreshold { [MethodImpl] get; }

    /// <summary>Gets the device selector.</summary>
    /// <returns>Returns the device selector, if it exists; otherwise, null.</returns>
    [MethodImpl]
    public static extern string GetDeviceSelector();

    /// <summary>Asynchronously obtains the sensor from its identifier.</summary>
    /// <param name="deviceId">The sensor identifier</param>
    /// <returns>Returns the Gyrometer object from its identifier.</returns>
    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<Gyrometer> FromIdAsync(
      string deviceId);

    /// <summary>Returns the default gyrometer.</summary>
    /// <returns>The default gyrometer or null if no integrated gyrometers are found.</returns>
    [MethodImpl]
    public static extern Gyrometer GetDefault();
  }
}
