// Decompiled with JetBrains decompiler
// Type: Windows.UI.Input.Inking.InkStroke
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
  /// <summary>A single ink stroke, including the Bézier curve parameters used for final rendering of the stroke.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [DualApiPartition(version = 100794368)]
  public sealed class InkStroke : IInkStroke, IInkStroke2, IInkStroke3, IInkStroke4
  {
    /// <summary>Gets or sets the properties associated with an InkStroke.</summary>
    /// <returns>The drawing attributes.</returns>
    public extern InkDrawingAttributes DrawingAttributes { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets the bounding box for the InkStroke.</summary>
    /// <returns>The bounding box.</returns>
    public extern Rect BoundingRect { [MethodImpl] get; }

    /// <summary>Gets whether the stroke is selected.</summary>
    /// <returns>True if the stroke is selected; otherwise, false.</returns>
    public extern bool Selected { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets whether the stroke is recognized.</summary>
    /// <returns>True if the stroke is recognized; otherwise, false.</returns>
    public extern bool Recognized { [MethodImpl] get; }

    /// <summary>Gets the rendering segments of the stroke.</summary>
    /// <returns>The collection of InkStrokeRenderingSegment objects.</returns>
    [MethodImpl]
    public extern IVectorView<InkStrokeRenderingSegment> GetRenderingSegments();

    /// <summary>Copies the InkStroke to another InkManager (or InkStrokeContainer ).</summary>
    /// <returns>The new stroke.</returns>
    [MethodImpl]
    public extern InkStroke Clone();

    /// <summary>Gets or sets an affine transformation matrix to apply to the InkStroke object.</summary>
    /// <returns>The 2-D transformation matrix.</returns>
    public extern Matrix3x2 PointTransform { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets the collection of InkPoint objects used to construct the InkStroke.</summary>
    /// <returns>The collection of InkPoint objects used to construct the InkStroke.</returns>
    [MethodImpl]
    public extern IVectorView<InkPoint> GetInkPoints();

    /// <summary>Gets the ink stroke identifier.</summary>
    /// <returns>The identifier for the ink stroke.</returns>
    public extern uint Id { [MethodImpl] get; }

    /// <summary>Gets or sets the date and time when the InkStroke was started.</summary>
    /// <returns>The date and time of day.</returns>
    public extern IReference<DateTime> StrokeStartedTime { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the time taken by the user to draw a single ink stroke.</summary>
    /// <returns>The time period expressed in 100-nanosecond units.</returns>
    public extern IReference<TimeSpan> StrokeDuration { [MethodImpl] get; [MethodImpl] set; }

    public extern uint PointerId { [MethodImpl] get; }
  }
}
