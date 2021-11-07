// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Sensors.InclinometerReading
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Sensors
{
  /// <summary>Represents an inclinometer reading.</summary>
  [DualApiPartition(version = 100794368)]
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class InclinometerReading : 
    IInclinometerReading,
    IInclinometerReadingYawAccuracy,
    IInclinometerReading2
  {
    /// <summary>Gets the time at which the sensor reported the reading.</summary>
    /// <returns>The time at which the sensor reported the reading.</returns>
    public extern DateTime Timestamp { [MethodImpl] get; }

    /// <summary>Gets the rotation in degrees around the x-axis.</summary>
    /// <returns>The rotation in degrees around the x-axis.</returns>
    public extern float PitchDegrees { [MethodImpl] get; }

    /// <summary>Gets the rotation in degrees around the y-axis.</summary>
    /// <returns>The rotation in degrees around the y-axis.</returns>
    public extern float RollDegrees { [MethodImpl] get; }

    /// <summary>Gets the rotation in degrees around the z-axis.</summary>
    /// <returns>The rotation in degrees around the z-axis.</returns>
    public extern float YawDegrees { [MethodImpl] get; }

    /// <summary>Gets the inclinometer's z-axis accuracy.</summary>
    /// <returns>The inclinometer's z-axis accuracy.</returns>
    public extern MagnetometerAccuracy YawAccuracy { [MethodImpl] get; }

    /// <summary>Gets the performance count associated with the reading. This allows the reading to be synchronized with other devices and processes on the system.</summary>
    /// <returns>The performance count for the reading. Null if this property is not supported on the sensor.</returns>
    public extern IReference<TimeSpan> PerformanceCount { [MethodImpl] get; }

    /// <summary>Gets a collection of key-value pairs that represent data properties reported by the sensor for the given reading.</summary>
    /// <returns>A collection of key-value pairs that represent data properties reported by the sensor for the given reading.</returns>
    public extern IMapView<string, object> Properties { [MethodImpl] get; }
  }
}
