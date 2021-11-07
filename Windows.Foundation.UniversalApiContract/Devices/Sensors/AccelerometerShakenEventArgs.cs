// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Sensors.AccelerometerShakenEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Sensors
{
  /// <summary>Provides data for the accelerometer-shaken event.</summary>
  [DualApiPartition(version = 100794368)]
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class AccelerometerShakenEventArgs : IAccelerometerShakenEventArgs
  {
    /// <summary>Gets the time at which the sensor reported the shaken event.</summary>
    /// <returns>The time at which the sensor reported the event.</returns>
    public extern DateTime Timestamp { [MethodImpl] get; }
  }
}
