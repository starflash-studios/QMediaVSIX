// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Sensors.CompassDataThreshold
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Sensors
{
  /// <summary>Provides access to compass data thresholds (also known as change sensitivity).</summary>
  [ContractVersion(typeof (UniversalApiContract), 655360)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class CompassDataThreshold : ICompassDataThreshold
  {
    /// <summary>Gets or sets the minimum amount of directional change required to reach the threshold, measured in degrees.</summary>
    /// <returns>The compass data threshold, in degrees.</returns>
    public extern double Degrees { [MethodImpl] get; [MethodImpl] set; }
  }
}
