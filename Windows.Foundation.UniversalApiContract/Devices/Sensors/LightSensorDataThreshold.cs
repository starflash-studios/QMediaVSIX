// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Sensors.LightSensorDataThreshold
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Sensors
{
  /// <summary>Provides access to light data thresholds (also known as change sensitivity).</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 655360)]
  public sealed class LightSensorDataThreshold : ILightSensorDataThreshold
  {
    /// <summary>Gets or sets the minimum change in light (lux) required to reach the threshold, measured in percent.</summary>
    /// <returns>The light data threshold, in percent.</returns>
    public extern float LuxPercentage { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the minimum change in light (lux) required to reach the threshold, measured in absolute units of lux.</summary>
    /// <returns>The light data threshold, in absolute units of lux.</returns>
    public extern float AbsoluteLux { [MethodImpl] get; [MethodImpl] set; }
  }
}
