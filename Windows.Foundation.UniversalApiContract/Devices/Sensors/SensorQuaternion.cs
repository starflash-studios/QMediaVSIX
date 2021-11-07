// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Sensors.SensorQuaternion
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Sensors
{
  /// <summary>Represents a Quaternion.</summary>
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [DualApiPartition(version = 100794368)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class SensorQuaternion : ISensorQuaternion
  {
    /// <summary>Gets the w-value of the Quaternion.</summary>
    /// <returns>The w-value of the Quaternion.</returns>
    public extern float W { [MethodImpl] get; }

    /// <summary>Gets the x-value of the Quaternion.</summary>
    /// <returns>The x-value of the Quaternion.</returns>
    public extern float X { [MethodImpl] get; }

    /// <summary>Gets the y-value of the Quaternion.</summary>
    /// <returns>The y-value of the Quaternion.</returns>
    public extern float Y { [MethodImpl] get; }

    /// <summary>Gets the z-value of the Quaternion.</summary>
    /// <returns>The z-value of the Quaternion.</returns>
    public extern float Z { [MethodImpl] get; }
  }
}
