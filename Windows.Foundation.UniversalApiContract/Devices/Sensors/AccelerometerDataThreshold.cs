// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Sensors.AccelerometerDataThreshold
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Sensors
{
  /// <summary>Provides access to accelerometer data thresholds (also known as change sensitivity).</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 655360)]
  public sealed class AccelerometerDataThreshold : IAccelerometerDataThreshold
  {
    /// <summary>Gets or sets the minimum amount of acceleration increase or decrease along the x-axis required to reach the threshold, measured in in g-force.</summary>
    /// <returns>The accelerometer data threshold for the x-axis, in g-force.</returns>
    public extern double XAxisInGForce { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the minimum amount of acceleration increase or decrease along the y-axis required to reach the threshold, measured in in g-force.</summary>
    /// <returns>The accelerometer data threshold for the y-axis, in g-force.</returns>
    public extern double YAxisInGForce { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the minimum amount of acceleration increase or decrease along the z-axis required to reach the threshold, measured in in g-force.</summary>
    /// <returns>The accelerometer data threshold for the z-axis, in g-force.</returns>
    public extern double ZAxisInGForce { [MethodImpl] get; [MethodImpl] set; }
  }
}
