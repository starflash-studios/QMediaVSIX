// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Sensors.Barometer
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Sensors
{
  /// <summary>Provides an interface for a barometric sensor to measure atmospheric pressure.</summary>
  [Threading(ThreadingModel.Both)]
  [Static(typeof (IBarometerStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Static(typeof (IBarometerStatics2), 327680, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [DualApiPartition(version = 167772160)]
  public sealed class Barometer : IBarometer, IBarometer2, IBarometer3
  {
    /// <summary>Gets the current reading for the barometer.</summary>
    /// <returns>The current atmospheric pressure according to this sensor.</returns>
    [MethodImpl]
    public extern BarometerReading GetCurrentReading();

    /// <summary>Gets the device identifier.</summary>
    /// <returns>The device identifier.</returns>
    public extern string DeviceId { [MethodImpl] get; }

    /// <summary>The smallest report interval that is supported by this barometer sensor.</summary>
    /// <returns>The smallest ReportInterval supported by the sensor.</returns>
    public extern uint MinimumReportInterval { [MethodImpl] get; }

    /// <summary>Gets or sets the current report interval for the barometer.</summary>
    /// <returns>The current report interval.</returns>
    public extern uint ReportInterval { [MethodImpl] set; [MethodImpl] get; }

    /// <summary>Occurs each time the barometer sensor reports a new value.</summary>
    public extern event TypedEventHandler<Barometer, BarometerReadingChangedEventArgs> ReadingChanged;

    /// <summary>Gets or sets the delay between batches of sensor information.</summary>
    /// <returns>The delay between batches of sensor information in milliseconds.</returns>
    public extern uint ReportLatency { [MethodImpl] set; [MethodImpl] get; }

    /// <summary>Gets the maximum number of events that can be batched by the sensor.</summary>
    /// <returns>The maximum number of batched events.</returns>
    public extern uint MaxBatchSize { [MethodImpl] get; }

    /// <summary>Gets BarometerDataThreshold for the barometric pressure sensor.</summary>
    /// <returns>
    /// </returns>
    public extern BarometerDataThreshold ReportThreshold { [MethodImpl] get; }

    /// <summary>Asynchronously obtains the sensor from its identifier.</summary>
    /// <param name="deviceId">The sensor identifier</param>
    /// <returns>Returns the Barometer object from its identifier.</returns>
    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<Barometer> FromIdAsync(
      string deviceId);

    /// <summary>Gets the device selector.</summary>
    /// <returns>Returns the device selector, if it exists; otherwise, null.</returns>
    [MethodImpl]
    public static extern string GetDeviceSelector();

    /// <summary>Returns the default barometer sensor.</summary>
    /// <returns>The default barometer.</returns>
    [MethodImpl]
    public static extern Barometer GetDefault();
  }
}
