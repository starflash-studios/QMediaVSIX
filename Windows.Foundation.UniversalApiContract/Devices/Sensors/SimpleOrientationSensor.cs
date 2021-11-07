// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Sensors.SimpleOrientationSensor
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Graphics.Display;

namespace Windows.Devices.Sensors
{
  /// <summary>Represents a simple orientation sensor.</summary>
  [Static(typeof (ISimpleOrientationSensorStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [DualApiPartition(version = 100794368)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Static(typeof (ISimpleOrientationSensorStatics2), 458752, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  public sealed class SimpleOrientationSensor : 
    ISimpleOrientationSensor,
    ISimpleOrientationSensorDeviceId,
    ISimpleOrientationSensor2
  {
    /// <summary>Gets the default simple orientation sensor.</summary>
    /// <returns>The default simple orientation sensor.</returns>
    [MethodImpl]
    public extern SimpleOrientation GetCurrentOrientation();

    /// <summary>Occurs each time the simple orientation sensor reports a new sensor reading</summary>
    public extern event TypedEventHandler<SimpleOrientationSensor, SimpleOrientationSensorOrientationChangedEventArgs> OrientationChanged;

    /// <summary>Gets the device identifier used in the SimpleOrientationSensor.FromIdAsync method.</summary>
    /// <returns>The device identifier.</returns>
    public extern string DeviceId { [MethodImpl] get; }

    /// <summary>Gets or sets the transformation that needs to be applied to sensor data. Transformations to be applied are tied to the display orientation with which to align the sensor data.</summary>
    /// <returns>A DisplayOrientations -typed value that specifies the display orientation with which to align the sensor data.</returns>
    public extern DisplayOrientations ReadingTransform { [MethodImpl] set; [MethodImpl] get; }

    /// <summary>Retrieves an Advanced Query Syntax (AQS) string used to enumerate the available SimpleOrientationSensor devices.</summary>
    /// <returns>The device selector, if it exists; otherwise, null.</returns>
    [MethodImpl]
    public static extern string GetDeviceSelector();

    /// <summary>Asynchronously retrieves a SimpleOrientationSensor object based on the specified device identifier.</summary>
    /// <param name="deviceId">The SimpleOrientationSensor device identifier.</param>
    /// <returns>After the operation completes, returns the SimpleOrientationSensor instance based on the value of deviceId.</returns>
    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<SimpleOrientationSensor> FromIdAsync(
      string deviceId);

    /// <summary>Gets the default simple orientation sensor.</summary>
    /// <returns>The default simple orientation sensor or null if no simple orientation sensors are found.</returns>
    [MethodImpl]
    public static extern SimpleOrientationSensor GetDefault();
  }
}
