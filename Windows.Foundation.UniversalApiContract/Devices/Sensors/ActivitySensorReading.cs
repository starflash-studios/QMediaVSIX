// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Sensors.ActivitySensorReading
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Sensors
{
  /// <summary>Represents the reading of an activity sensor that provides readings for the sensor.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [DualApiPartition(version = 167772160)]
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class ActivitySensorReading : IActivitySensorReading
  {
    /// <summary>Gets the time at which the sensor reported the reading.</summary>
    /// <returns>The instant in time when the sensor reported the reading.</returns>
    public extern DateTime Timestamp { [MethodImpl] get; }

    /// <summary>Gets the activity type for the sensor.</summary>
    /// <returns>A ActivityType -typed value that specifies the current activity for the sensor.</returns>
    public extern ActivityType Activity { [MethodImpl] get; }

    /// <summary>Gets the reading confidence for the sensor.</summary>
    /// <returns>A ActivitySensorReadingConfidence -typed value that specifies the reading confidence for the sensor.</returns>
    public extern ActivitySensorReadingConfidence Confidence { [MethodImpl] get; }
  }
}
