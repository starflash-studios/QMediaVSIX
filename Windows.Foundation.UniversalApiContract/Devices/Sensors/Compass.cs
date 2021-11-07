// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Sensors.Compass
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Graphics.Display;

namespace Windows.Devices.Sensors
{
  /// <summary>Represents a compass sensor.</summary>
  [Threading(ThreadingModel.Both)]
  [DualApiPartition(version = 100794368)]
  [Static(typeof (ICompassStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [Static(typeof (ICompassStatics2), 327680, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class Compass : ICompass, ICompassDeviceId, ICompass2, ICompass3, ICompass4
  {
    /// <summary>Gets the current compass reading.</summary>
    /// <returns>The current compass reading.</returns>
    [MethodImpl]
    public extern CompassReading GetCurrentReading();

    /// <summary>Gets the minimum report interval supported by the compass.</summary>
    /// <returns>The minimum ReportInterval supported by the sensor.</returns>
    public extern uint MinimumReportInterval { [MethodImpl] get; }

    /// <summary>Gets or sets the current report interval for the compass.</summary>
    /// <returns>The current report interval.</returns>
    public extern uint ReportInterval { [MethodImpl] set; [MethodImpl] get; }

    /// <summary>Occurs each time the compass reports a new sensor reading.</summary>
    public extern event TypedEventHandler<Compass, CompassReadingChangedEventArgs> ReadingChanged;

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

    /// <summary>Gets the CompassDataThreshold for the compass sensor.</summary>
    /// <returns>
    /// </returns>
    public extern CompassDataThreshold ReportThreshold { [MethodImpl] get; }

    /// <summary>Gets the device selector.</summary>
    /// <returns>Returns the device selector, if it exists; otherwise, null.</returns>
    [MethodImpl]
    public static extern string GetDeviceSelector();

    /// <summary>Asynchronously obtains the sensor from its identifier.</summary>
    /// <param name="deviceId">The sensor identifier</param>
    /// <returns>Returns the Compass object from its identifier.</returns>
    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<Compass> FromIdAsync(string deviceId);

    /// <summary>Returns the default compass.</summary>
    /// <returns>The default compass or null if no integrated compasses are found.</returns>
    [MethodImpl]
    public static extern Compass GetDefault();
  }
}
