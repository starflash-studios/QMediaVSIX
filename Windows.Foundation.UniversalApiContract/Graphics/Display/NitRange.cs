// Decompiled with JetBrains decompiler
// Type: Windows.Graphics.Display.NitRange
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Graphics.Display
{
  /// <summary>Describes the minimum, maximum, and step size you can use when using nits to describe brightness on a device.</summary>
  [ContractVersion(typeof (UniversalApiContract), 393216)]
  public struct NitRange
  {
    /// <summary>The inclusive end point.</summary>
    public float MinNits;
    /// <summary>The inclusive start point.</summary>
    public float MaxNits;
    /// <summary>The step size, in nits, of the display brightness. Guaranteed to be a factor of (MinNits - MaxNits).</summary>
    public float StepSizeNits;
  }
}
