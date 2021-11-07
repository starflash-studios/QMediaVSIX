// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Sensors.ProximitySensorReading
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Sensors
{
  /// <summary>Represents a reading from the proximity sensor.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [DualApiPartition(version = 167772160)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Threading(ThreadingModel.Both)]
  public sealed class ProximitySensorReading : IProximitySensorReading
  {
    /// <summary>Gets the time for the most recent proximity sensor reading.</summary>
    /// <returns>The time when the proximity sensor reported the reading.</returns>
    public extern DateTime Timestamp { [MethodImpl] get; }

    /// <summary>Gets whether or not an object is detected by the proximity sensor.</summary>
    /// <returns>True if an object is detected by the proximity sensor; otherwise false.</returns>
    public extern bool IsDetected { [MethodImpl] get; }

    /// <summary>Gets the distance from the proximity sensor to the detected object.</summary>
    /// <returns>The distance between the sensor and the object in millimeters.</returns>
    public extern IReference<uint> DistanceInMillimeters { [MethodImpl] get; }
  }
}
