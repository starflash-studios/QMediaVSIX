// Decompiled with JetBrains decompiler
// Type: Windows.UI.Input.Inking.InkStrokeBuilder
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Foundation.Numerics;

namespace Windows.UI.Input.Inking
{
  /// <summary>Builds strokes from raw pointer input.</summary>
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.None)]
  [DualApiPartition(version = 100794368)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Threading(ThreadingModel.Both)]
  public sealed class InkStrokeBuilder : IInkStrokeBuilder, IInkStrokeBuilder2, IInkStrokeBuilder3
  {
    /// <summary>Creates a new InkStrokeBuilder object that is used to construct InkStroke objects.</summary>
    [MethodImpl]
    public extern InkStrokeBuilder();

    /// <summary>Starts building the ink stroke.</summary>
    /// <param name="pointerPoint">The first point for the stroke.</param>
    [MethodImpl]
    public extern void BeginStroke(PointerPoint pointerPoint);

    /// <summary>Adds a new segment to the ink stroke.</summary>
    /// <param name="pointerPoint">The end point of the new segment.</param>
    /// <returns>The previous end point. This end point can be used when rendering the stroke.</returns>
    [MethodImpl]
    public extern PointerPoint AppendToStroke(PointerPoint pointerPoint);

    /// <summary>Stops building the ink stroke.</summary>
    /// <param name="pointerPoint">The last point for the stroke.</param>
    /// <returns>The stroke built from the points.</returns>
    [MethodImpl]
    public extern InkStroke EndStroke(PointerPoint pointerPoint);

    [MethodImpl]
    public extern InkStroke CreateStroke(IIterable<Point> points);

    /// <summary>Sets the default InkDrawingAttributes for all new ink strokes created after the current stroke.</summary>
    /// <param name="drawingAttributes">The default attributes.</param>
    [MethodImpl]
    public extern void SetDefaultDrawingAttributes(InkDrawingAttributes drawingAttributes);

    [MethodImpl]
    public extern InkStroke CreateStrokeFromInkPoints(
      IIterable<InkPoint> inkPoints,
      Matrix3x2 transform);

    [MethodImpl]
    public extern InkStroke CreateStrokeFromInkPoints(
      IIterable<InkPoint> inkPoints,
      Matrix3x2 transform,
      IReference<DateTime> strokeStartedTime,
      IReference<TimeSpan> strokeDuration);
  }
}
