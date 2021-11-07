// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Sensors.LightSensor
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Sensors
{
  /// <summary>Represents an ambient-light sensor.</summary>
  [DualApiPartition(version = 100794368)]
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Static(typeof (ILightSensorStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Static(typeof (ILightSensorStatics2), 327680, "Windows.Foundation.UniversalApiContract")]
  public sealed class LightSensor : ILightSensor, ILightSensorDeviceId, ILightSensor2, ILightSensor3
  {
    /// <summary>Gets the current ambient-light sensor reading.</summary>
    /// <returns>The current ambient-light sensor reading.</returns>
    [MethodImpl]
    public extern LightSensorReading GetCurrentReading();

    /// <summary>Gets the minimum report interval supported by the sensor.</summary>
    /// <returns>The minimum ReportInterval supported by the sensor.</returns>
    public extern uint MinimumReportInterval { [MethodImpl] get; }

    /// <summary>Gets or sets the current report interval for the ambient light sensor.</summary>
    /// <returns>The current report interval.</returns>
    public extern uint ReportInterval { [MethodImpl] set; [MethodImpl] get; }

    /// <summary>Occurs each time the ambient-light sensor reports a new sensor reading.</summary>
    public extern event TypedEventHandler<LightSensor, LightSensorReadingChangedEventArgs> ReadingChanged;

    /// <summary>Gets the device identifier.</summary>
    /// <returns>The device identifier.</returns>
    public extern string DeviceId { [MethodImpl] get; }

    /// <summary>Gets or sets the delay between batches of sensor information.</summary>
    /// <returns>The delay between batches of sensor information in milliseconds.</returns>
    public extern uint ReportLatency { [MethodImpl] set; [MethodImpl] get; }

    /// <summary>Gets the maximum number of events that can be batched by the sensor.</summary>
    /// <returns>The maximum number of batched events.</returns>
    public extern uint MaxBatchSize { [MethodImpl] get; }

    /// <summary>Gets the LightSensorDataThreshold for the light sensor.</summary>
    /// <returns>
    /// </returns>
    public extern LightSensorDataThreshold ReportThreshold { [MethodImpl] get; }

    /// <summary>Gets the device selector.</summary>
    /// <returns>Returns the device selector, if it exists; otherwise, null.</returns>
    [MethodImpl]
    public static extern string GetDeviceSelector();

    /// <summary>Asynchronously obtains the sensor from its identifier.</summary>
    /// <param name="deviceId">The sensor identifier</param>
    /// <returns>Returns the LightSensor object from its identifier.</returns>
    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<LightSensor> FromIdAsync(
      string deviceId);

    /// <summary>Returns the default ambient-light sensor.</summary>
    /// <returns>The default ambient-light sensor or null if no integrated light sensors are found.</returns>
    [MethodImpl]
    public static extern LightSensor GetDefault();
  }
}
