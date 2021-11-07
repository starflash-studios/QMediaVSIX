// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Sensors.ActivitySensor
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Sensors
{
  /// <summary>Represents an activity sensor that provides the activity and status of a sensor.</summary>
  [DualApiPartition(version = 167772160)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Static(typeof (IActivitySensorStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Threading(ThreadingModel.Both)]
  public sealed class ActivitySensor : IActivitySensor
  {
    /// <summary>Asynchronously gets the current sensor reading.</summary>
    /// <returns>Asynchronously returns a ActivitySensorReading object that represents info about the sensor.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<ActivitySensorReading> GetCurrentReadingAsync();

    /// <summary>Gets the list of activity types that the sensor pledges to perform.</summary>
    /// <returns>The list of ActivityType -typed values for the activity types that the sensor pledges to perform.</returns>
    public extern IVector<ActivityType> SubscribedActivities { [MethodImpl] get; }

    /// <summary>Gets the power in milliwatts that the sensor consumes.</summary>
    /// <returns>The power in milliwatts that the sensor consumes.</returns>
    public extern double PowerInMilliwatts { [MethodImpl] get; }

    /// <summary>Gets the device identifier.</summary>
    /// <returns>The device identifier.</returns>
    public extern string DeviceId { [MethodImpl] get; }

    /// <summary>Gets the list of activity types that the sensor supports.</summary>
    /// <returns>The list of ActivityType -typed values for the activity types that the sensor supports.</returns>
    public extern IVectorView<ActivityType> SupportedActivities { [MethodImpl] get; }

    /// <summary>Gets the minimum report interval supported by the sensor.</summary>
    /// <returns>The minimum report interval supported by the sensor.</returns>
    public extern uint MinimumReportInterval { [MethodImpl] get; }

    /// <summary>Occurs each time the sensor reports a new sensor reading.</summary>
    public extern event TypedEventHandler<ActivitySensor, ActivitySensorReadingChangedEventArgs> ReadingChanged;

    /// <summary>Asynchronously obtains the default sensor.</summary>
    /// <returns>Asynchronously returns a ActivitySensor object that represents the default sensor.</returns>
    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<ActivitySensor> GetDefaultAsync();

    /// <summary>Gets the device selector.</summary>
    /// <returns>Returns the device selector, if it exists; otherwise, null.</returns>
    [MethodImpl]
    public static extern string GetDeviceSelector();

    /// <summary>Asynchronously obtains the sensor from its identifier.</summary>
    /// <param name="deviceId">The sensor identifier</param>
    /// <returns>Returns the ActivitySensor object from its identifier.</returns>
    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<ActivitySensor> FromIdAsync(
      string deviceId);

    [RemoteAsync]
    [Overload("GetSystemHistoryAsync")]
    [MethodImpl]
    public static extern IAsyncOperation<IVectorView<ActivitySensorReading>> GetSystemHistoryAsync(
      DateTime fromTime);

    [RemoteAsync]
    [Overload("GetSystemHistoryWithDurationAsync")]
    [MethodImpl]
    public static extern IAsyncOperation<IVectorView<ActivitySensorReading>> GetSystemHistoryAsync(
      DateTime fromTime,
      TimeSpan duration);
  }
}
