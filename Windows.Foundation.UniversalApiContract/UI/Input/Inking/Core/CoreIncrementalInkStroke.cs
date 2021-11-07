// Decompiled with JetBrains decompiler
// Type: Windows.UI.Input.Inking.Core.CoreIncrementalInkStroke
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Foundation.Numerics;

namespace Windows.UI.Input.Inking.Core
{
  /// <summary>Represents a single ink stroke that can be rendered incrementally, using individual InkPoint objects.</summary>
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  [DualApiPartition(version = 167772164)]
  [WebHostHidden]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Activatable(typeof (ICoreIncrementalInkStrokeFactory), 327680, "Windows.Foundation.UniversalApiContract")]
  public sealed class CoreIncrementalInkStroke : ICoreIncrementalInkStroke
  {
    [MethodImpl]
    public extern CoreIncrementalInkStroke(
      InkDrawingAttributes drawingAttributes,
      Matrix3x2 pointTransform);

    [MethodImpl]
    public extern Rect AppendInkPoints(IIterable<InkPoint> inkPoints);

    /// <summary>Creates a new ink stroke.</summary>
    /// <returns>The new ink stroke.</returns>
    [MethodImpl]
    public extern InkStroke CreateInkStroke();

    /// <summary>Gets the ink stroke attributes associated with the drawing of a CoreIncrementalInkStroke.</summary>
    /// <returns>The ink stroke attributes.</returns>
    public extern InkDrawingAttributes DrawingAttributes { [MethodImpl] get; }

    /// <summary>Gets or sets an affine transformation matrix to apply to the CoreIncrementalInkStroke object.</summary>
    /// <returns>The position and angle of the stroke as a 3*2 floating point matrix.</returns>
    public extern Matrix3x2 PointTransform { [MethodImpl] get; }

    /// <summary>Gets the bounding rectangle of the CoreIncrementalInkStroke.</summary>
    /// <returns>The bounding rectangle of the CoreIncrementalInkStroke.</returns>
    public extern Rect BoundingRect { [MethodImpl] get; }
  }
}
