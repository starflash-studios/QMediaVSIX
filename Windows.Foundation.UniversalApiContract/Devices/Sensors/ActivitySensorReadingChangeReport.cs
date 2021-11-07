// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Sensors.ActivitySensorReadingChangeReport
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Sensors
{
  /// <summary>Represents data for the sensor trigger.</summary>
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [DualApiPartition(version = 167772160)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class ActivitySensorReadingChangeReport : IActivitySensorReadingChangeReport
  {
    /// <summary>Gets the reading of the sensor when it's triggered.</summary>
    /// <returns>The reading of the sensor when it's triggered.</returns>
    public extern ActivitySensorReading Reading { [MethodImpl] get; }
  }
}
