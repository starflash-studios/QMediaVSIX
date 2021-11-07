// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Sensors.AccelerometerReading
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Sensors
{
  /// <summary>Represents an accelerometer reading.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [DualApiPartition(version = 100794368)]
  public sealed class AccelerometerReading : IAccelerometerReading, IAccelerometerReading2
  {
    /// <summary>Gets the time at which the sensor reported the reading.</summary>
    /// <returns>The instant in time when the sensor reported the reading.</returns>
    public extern DateTime Timestamp { [MethodImpl] get; }

    /// <summary>Gets the g-force acceleration along the x-axis.</summary>
    /// <returns>The x-axis acceleration in g's.</returns>
    public extern double AccelerationX { [MethodImpl] get; }

    /// <summary>Gets the g-force acceleration along the y-axis.</summary>
    /// <returns>The y-axis acceleration in g's.</returns>
    public extern double AccelerationY { [MethodImpl] get; }

    /// <summary>Gets the g-force acceleration along the z-axis.</summary>
    /// <returns>The g-force acceleration along the z-axis.</returns>
    public extern double AccelerationZ { [MethodImpl] get; }

    /// <summary>Gets the performance count associated with the reading. This allows the reading to be synchronized with other devices and processes on the system.</summary>
    /// <returns>The performance count for the reading. Null if this property is not supported on the sensor.</returns>
    public extern IReference<TimeSpan> PerformanceCount { [MethodImpl] get; }

    /// <summary>Gets the data properties reported by the sensor.</summary>
    /// <returns>Contains a key/value pair for each data property reported by the sensor for the given reading. The key is a string of the property key, and the value is the value of the property that the key represents.</returns>
    public extern IMapView<string, object> Properties { [MethodImpl] get; }
  }
}
