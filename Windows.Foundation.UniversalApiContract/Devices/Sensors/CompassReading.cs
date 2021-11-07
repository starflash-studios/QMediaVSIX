// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Sensors.CompassReading
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Sensors
{
  /// <summary>Represents a compass reading.</summary>
  [DualApiPartition(version = 100794368)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class CompassReading : 
    ICompassReading,
    ICompassReadingHeadingAccuracy,
    ICompassReading2
  {
    /// <summary>Gets the time at which the sensor reported the reading.</summary>
    /// <returns>The time at which the sensor reported the reading.</returns>
    public extern DateTime Timestamp { [MethodImpl] get; }

    /// <summary>Gets the heading in degrees relative to magnetic-north.</summary>
    /// <returns>The magnetic-north heading.</returns>
    public extern double HeadingMagneticNorth { [MethodImpl] get; }

    /// <summary>Gets the heading in degrees relative to geographic true-north.</summary>
    /// <returns>The true-north heading.</returns>
    public extern IReference<double> HeadingTrueNorth { [MethodImpl] get; }

    /// <summary>Gets the compass's heading accuracy.</summary>
    /// <returns>The compass's heading accuracy.</returns>
    public extern MagnetometerAccuracy HeadingAccuracy { [MethodImpl] get; }

    /// <summary>Gets the performance count associated with the reading. This allows the reading to be synchronized with other devices and processes on the system.</summary>
    /// <returns>The performance count for the reading. Null if this property is not supported on the sensor.</returns>
    public extern IReference<TimeSpan> PerformanceCount { [MethodImpl] get; }

    /// <summary>Gets the data properties reported by the sensor.</summary>
    /// <returns>Contains a key/value pair for each data property reported by the sensor for the given reading. The key is a string of the property key, and the value is the value of the property that the key represents.</returns>
    public extern IMapView<string, object> Properties { [MethodImpl] get; }
  }
}
