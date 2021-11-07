// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Sensors.Pedometer
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Sensors
{
  /// <summary>Provides an interface for a pedometer to measure the number of steps taken.</summary>
  [DualApiPartition(version = 167772160)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Static(typeof (IPedometerStatics2), 131072, "Windows.Foundation.UniversalApiContract")]
  [Static(typeof (IPedometerStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class Pedometer : IPedometer, IPedometer2
  {
    /// <summary>Gets the device identifier.</summary>
    /// <returns>The device identifier.</returns>
    public extern string DeviceId { [MethodImpl] get; }

    /// <summary>Gets the power that the sensor consumes.</summary>
    /// <returns>The amount of power consumed in milliwatts.</returns>
    public extern double PowerInMilliwatts { [MethodImpl] get; }

    /// <summary>The smallest report interval that is supported by this pedometer.</summary>
    /// <returns>The smallest ReportInterval supported by the sensor.</returns>
    public extern uint MinimumReportInterval { [MethodImpl] get; }

    /// <summary>Gets or sets the current report interval for the pedometer.</summary>
    /// <returns>The current report interval.</returns>
    public extern uint ReportInterval { [MethodImpl] set; [MethodImpl] get; }

    /// <summary>Occurs each time the pedometer reports a new value.</summary>
    public extern event TypedEventHandler<Pedometer, PedometerReadingChangedEventArgs> ReadingChanged;

    /// <summary>Gets the current step information from the pedometer sensor.</summary>
    /// <returns>A collection of the step information available from the sensor.</returns>
    [MethodImpl]
    public extern IMapView<PedometerStepKind, PedometerReading> GetCurrentReadings();

    /// <summary>Gets readings from the trigger details in background task.</summary>
    /// <param name="triggerDetails">The trigger details received from the background task.</param>
    /// <returns>The collection of pedometer data retrieved from the trigger details.</returns>
    [MethodImpl]
    public static extern IVectorView<PedometerReading> GetReadingsFromTriggerDetails(
      SensorDataThresholdTriggerDetails triggerDetails);

    /// <summary>Obtains the pedometer from its identifier.</summary>
    /// <param name="deviceId">The sensor identifier.</param>
    /// <returns>Returns the Pedometer object from its identifier.</returns>
    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<Pedometer> FromIdAsync(
      string deviceId);

    /// <summary>Asynchronously obtains the default pedometer.</summary>
    /// <returns>Asynchronously returns a Pedometer object that represents the default sensor.</returns>
    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<Pedometer> GetDefaultAsync();

    /// <summary>Gets the device selector.</summary>
    /// <returns>Returns the device selector, if it exists; otherwise null.</returns>
    [MethodImpl]
    public static extern string GetDeviceSelector();

    [RemoteAsync]
    [Overload("GetSystemHistoryAsync")]
    [MethodImpl]
    public static extern IAsyncOperation<IVectorView<PedometerReading>> GetSystemHistoryAsync(
      DateTime fromTime);

    [Overload("GetSystemHistoryWithDurationAsync")]
    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<IVectorView<PedometerReading>> GetSystemHistoryAsync(
      DateTime fromTime,
      TimeSpan duration);
  }
}
