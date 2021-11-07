// Decompiled with JetBrains decompiler
// Type: Windows.UI.Input.ManipulationVelocities
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Input
{
  /// <summary>Contains the velocities of the accumulated transformations for the current interaction.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public struct ManipulationVelocities
  {
    /// <summary>The straight line velocity in device-independent pixel (DIP) per millisecond.</summary>
    public Point Linear;
    /// <summary>The rotational velocity in degrees per millisecond.</summary>
    public float Angular;
    /// <summary>The expansion, or scaling, velocity in device-independent pixel (DIP) per millisecond.</summary>
    public float Expansion;
  }
}
