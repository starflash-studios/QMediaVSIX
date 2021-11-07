// Decompiled with JetBrains decompiler
// Type: Windows.UI.Composition.CompositionRadialGradientBrush
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Foundation.Numerics;

namespace Windows.UI.Composition
{
  /// <summary>Represents a brush that paints an area with a radial gradient.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 524288)]
  [Threading(ThreadingModel.Both)]
  [WebHostHidden]
  public sealed class CompositionRadialGradientBrush : 
    CompositionGradientBrush,
    ICompositionRadialGradientBrush
  {
    /// <summary>Gets or sets the two-dimensional coordinates of the center of the ellipse that contains the gradient.</summary>
    /// <returns>The two-dimensional coordinates of the center of the ellipse the gradient is housed in. The default is a Vector2 with values (0.5, 0.5).</returns>
    public extern Vector2 EllipseCenter { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the radii of the ellipse that contains the gradient.</summary>
    /// <returns>The radii of the ellipse that contains the gradient. The default is a Vector2 with values (0.5, 0.5).</returns>
    public extern Vector2 EllipseRadius { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the two-dimensional coordinates of the origin of the gradient.</summary>
    /// <returns>The two-dimensional coordinates of the origin of the gradient. The default is a Vector2 with values (0, 0).</returns>
    public extern Vector2 GradientOriginOffset { [MethodImpl] get; [MethodImpl] set; }
  }
}
