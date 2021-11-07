// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Sensors.ProximitySensor
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Sensors
{
  /// <summary>Provides an interface for a proximity sensor to determine whether or not an object is detected.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Static(typeof (IProximitySensorStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [Static(typeof (IProximitySensorStatics2), 131072, "Windows.Foundation.UniversalApiContract")]
  [DualApiPartition(version = 167772160)]
  [Threading(ThreadingModel.Both)]
  public sealed class ProximitySensor : IProximitySensor
  {
    /// <summary>Gets the device identifier.</summary>
    /// <returns>The device identifier.</returns>
    public extern string DeviceId { [MethodImpl] get; }

    /// <summary>The largest distance where the proximity sensor can detect an object.</summary>
    /// <returns>The maximum distance in millimeters where the proximity sensor supports detecting an object.</returns>
    public extern IReference<uint> MaxDistanceInMillimeters { [MethodImpl] get; }

    /// <summary>The shortest distance where the proximity sensor can detect an object.</summary>
    /// <returns>The minimum distance in millimeters where the proximity sensor supports detecting an object.</returns>
    public extern IReference<uint> MinDistanceInMillimeters { [MethodImpl] get; }

    /// <summary>Gets the current reading for the proximity sensor.</summary>
    /// <returns>Indicates whether or not the proximity sensor detects an object, and if so, the distance to that object.</returns>
    [MethodImpl]
    public extern ProximitySensorReading GetCurrentReading();

    /// <summary>Occurs each time the proximity sensor reports a new value.</summary>
    public extern event TypedEventHandler<ProximitySensor, ProximitySensorReadingChangedEventArgs> ReadingChanged;

    /// <summary>Creates a controller responsible for turning the display on or off based on the ProximitySensorReading.</summary>
    /// <returns>The controller for the phone display.</returns>
    [MethodImpl]
    public extern ProximitySensorDisplayOnOffController CreateDisplayOnOffController();

    /// <summary>Gets readings from the trigger details in background task.</summary>
    /// <param name="triggerDetails">The trigger details received from the background task.</param>
    /// <returns>The collection of proximity data retrieved from the trigger details.</returns>
    [MethodImpl]
    public static extern IVectorView<ProximitySensorReading> GetReadingsFromTriggerDetails(
      SensorDataThresholdTriggerDetails triggerDetails);

    /// <summary>Gets the device selector.</summary>
    /// <returns>Returns the device selector. If no device selector is available, this method returns null.</returns>
    [MethodImpl]
    public static extern string GetDeviceSelector();

    /// <summary>Obtains the proximity sensor from its identifier.</summary>
    /// <param name="sensorId">The sensor identifier.</param>
    /// <returns>Returns the ProximitySensor object from its identifier.</returns>
    [MethodImpl]
    public static extern ProximitySensor FromId(string sensorId);
  }
}
