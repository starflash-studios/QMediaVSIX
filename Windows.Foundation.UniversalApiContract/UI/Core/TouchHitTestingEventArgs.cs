// Decompiled with JetBrains decompiler
// Type: Windows.UI.Core.TouchHitTestingEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Core
{
  /// <summary>Contains the arguments returned by the TouchHitTesting event.</summary>
  [MarshalingBehavior(MarshalingType.Standard)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  public sealed class TouchHitTestingEventArgs : ITouchHitTestingEventArgs, ICoreWindowEventArgs
  {
    /// <summary>Gets or sets the proximity evaluation score for an object relative to the touch contact area.</summary>
    /// <returns>Proximity evaluation of an object.</returns>
    public extern CoreProximityEvaluation ProximityEvaluation { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets the screen coordinates of the touch point reported by the touch digitizer.</summary>
    /// <returns>Screen position of the input pointer, in device-independent pixel (DIP).</returns>
    public extern Point Point { [MethodImpl] get; }

    /// <summary>Gets the bounding rectangle of the touch contact area.</summary>
    /// <returns>Bounding rectangle of the touch contact area.</returns>
    public extern Rect BoundingBox { [MethodImpl] get; }

    /// <summary>Returns a ranking for the rectangle as the probable touch target and an adjusted touch point within the rectangle. The rank is determined through a comparison of targeting heuristics for all rectangles that intersect the touch contact area.</summary>
    /// <param name="controlBoundingBox">The Rect that defines the bounding box of the UI element.</param>
    /// <returns>The CoreProximityEvaluation structure that holds the rank and adjusted touch point data.</returns>
    [Overload("EvaluateProximityToRect")]
    [DefaultOverload]
    [MethodImpl]
    public extern CoreProximityEvaluation EvaluateProximity(
      Rect controlBoundingBox);

    /// <summary>Returns a ranking for the polygon as the probable touch target and an adjusted touch point within the polygon. The rank is determined through a comparison of targeting heuristics for all polygons that intersect the touch contact area.</summary>
    /// <param name="controlVertices">The array of x-y screen coordinates that define the shape of the UI element (the number of vertices in the polygon). This value must be greater than or equal to 3.</param>
    /// <returns>The CoreProximityEvaluation structure that holds the rank and adjusted touch point data.</returns>
    [Overload("EvaluateProximityToPolygon")]
    [MethodImpl]
    public extern CoreProximityEvaluation EvaluateProximity(
      Point[] controlVertices);

    /// <summary>Gets or sets a value indicating whether the TouchHitTesting event was handled.</summary>
    /// <returns>True if the event is handled; otherwise, false.</returns>
    public extern bool Handled { [MethodImpl] get; [MethodImpl] set; }
  }
}
