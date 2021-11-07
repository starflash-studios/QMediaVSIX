// Decompiled with JetBrains decompiler
// Type: Windows.UI.Composition.DistantLight
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Foundation.Numerics;

namespace Windows.UI.Composition
{
  /// <summary>An infinitely large distant light source that emits light in a single direction. For example, a distant light could be used to represent sunlight.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [Threading(ThreadingModel.Both)]
  [WebHostHidden]
  [DualApiPartition(version = 167772164)]
  public sealed class DistantLight : CompositionLight, IDistantLight, IDistantLight2
  {
    /// <summary>Color of the emitted DistantLight.</summary>
    /// <returns>Color of the emitted DistantLight.</returns>
    public extern Color Color { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>The Visual used to determine the light’s direction. The light's </summary>
    /// <returns>The Visual used to determine the light’s direction. The light's </returns>
    public extern Visual CoordinateSpace { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>The direction in which the light is pointing, specified relative to its CoordinateSpace Visual.</summary>
    /// <returns>The direction in which the light is cast.</returns>
    public extern Vector3 Direction { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the intensity of the light.</summary>
    /// <returns>The intensity of the light.</returns>
    public extern float Intensity { [MethodImpl] get; [MethodImpl] set; }
  }
}
