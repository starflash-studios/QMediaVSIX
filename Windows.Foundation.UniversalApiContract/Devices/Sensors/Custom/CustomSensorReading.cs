// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Sensors.Custom.CustomSensorReading
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Sensors.Custom
{
  /// <summary>Represents a property set of key/value pairs that contain the custom data sent from the sensor’s driver to the app.</summary>
  [DualApiPartition(version = 167772160)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Threading(ThreadingModel.Both)]
  public sealed class CustomSensorReading : ICustomSensorReading, ICustomSensorReading2
  {
    /// <summary>Gets the time at which the sensor reported the reading.</summary>
    /// <returns>The instant in time when the sensor reported the reading.</returns>
    public extern DateTime Timestamp { [MethodImpl] get; }

    /// <summary>Gets the property set for the sensor.</summary>
    /// <returns>The property set for the sensor. This set contains the key/value pair for each property in the set.</returns>
    public extern IMapView<string, object> Properties { [MethodImpl] get; }

    /// <summary>Gets the performance count associated with the reading. This allows the reading to be synchronized with other devices and processes on the system.</summary>
    /// <returns>The performance count for the reading. Null if this property is not supported on the sensor.</returns>
    public extern IReference<TimeSpan> PerformanceCount { [MethodImpl] get; }
  }
}
