// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Sensors.InclinometerDataThreshold
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Sensors
{
  /// <summary>Provides access to inclinometer data thresholds (also known as change sensitivity).</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 655360)]
  public sealed class InclinometerDataThreshold : IInclinometerDataThreshold
  {
    /// <summary>Gets or sets the minimum change in rotation around the pitch-axis (transverse axis) required to reach the threshold, measured in degrees.</summary>
    /// <returns>The inclinometer data threshold for the pitch-axis, in degrees.</returns>
    public extern float PitchInDegrees { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the minimum change in rotation around the roll-axis (longitudinal axis) required to reach the threshold, measured in degrees.</summary>
    /// <returns>The inclinometer data threshold for the roll-axis, in degrees.</returns>
    public extern float RollInDegrees { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the minimum change of rotation around the yaw-axis (vertical axis) required to reach the threshold, measured in degrees.</summary>
    /// <returns>The inclinometer data threshold for the yaw-axis, in degrees.</returns>
    public extern float YawInDegrees { [MethodImpl] get; [MethodImpl] set; }
  }
}
