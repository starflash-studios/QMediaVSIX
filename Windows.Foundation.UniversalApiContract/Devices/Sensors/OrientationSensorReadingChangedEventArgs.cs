// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Sensors.OrientationSensorReadingChangedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Sensors
{
  /// <summary>Provides data for the orientation-sensor reading-changed event.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [DualApiPartition(version = 100794368)]
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class OrientationSensorReadingChangedEventArgs : 
    IOrientationSensorReadingChangedEventArgs
  {
    /// <summary>Gets the current reading which includes a Quaternion, a RotationMatrix, and a timestamp.</summary>
    /// <returns>The current reading which includes a Quaternion, a RotationMatrix, and a timestamp.</returns>
    public extern OrientationSensorReading Reading { [MethodImpl] get; }
  }
}
