// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Sensors.GyrometerDataThreshold
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Sensors
{
  /// <summary>Provides access to gyrometer data thresholds (also known as change sensitivity).</summary>
  [ContractVersion(typeof (UniversalApiContract), 655360)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class GyrometerDataThreshold : IGyrometerDataThreshold
  {
    /// <summary>Gets or sets the minimum change of angular velocity around the x-axis required to reach the threshold, measured in degrees per second.</summary>
    /// <returns>The gyrometer data threshold for the x-axis, in degrees per second.</returns>
    public extern double XAxisInDegreesPerSecond { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the minimum change of angular velocity around the y-axis required to reach the threshold, measured in degrees per second.</summary>
    /// <returns>The gyrometer data threshold for the y-axis, in degrees per second.</returns>
    public extern double YAxisInDegreesPerSecond { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the minimum change of angular velocity around the x-axis required to reach the threshold, measured in degrees per second.</summary>
    /// <returns>The gyrometer data threshold for the x-axis, in degrees per second.</returns>
    public extern double ZAxisInDegreesPerSecond { [MethodImpl] get; [MethodImpl] set; }
  }
}
