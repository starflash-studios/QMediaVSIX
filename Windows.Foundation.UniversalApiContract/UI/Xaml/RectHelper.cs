// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.RectHelper
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml
{
  /// <summary>Provides helper methods to evaluate or set Rect values. C# and Microsoft Visual Basic code should use members of Rect instead.</summary>
  [WebHostHidden]
  [Static(typeof (IRectHelperStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class RectHelper : IRectHelper
  {
    /// <summary>Gets a static Rect value where the Rect has no size or position (all values 0). C# and Microsoft Visual Basic code should use Rect.Empty instead.</summary>
    /// <returns>A Rect with all values as 0.</returns>
    public static extern Rect Empty { [MethodImpl] get; }

    /// <summary>Creates a new Rect value based on the element values of a Rect structure. C# and Microsoft Visual Basic code should use the Rect(Double,Double,Double,Double) constructor instead.</summary>
    /// <param name="x">The pixel value to set for **X**.</param>
    /// <param name="y">The pixel value to set for **Y**.</param>
    /// <param name="width">The pixel value to set for **Width**.</param>
    /// <param name="height">The pixel value to set for **Height**.</param>
    /// <returns>The created Rect.</returns>
    [MethodImpl]
    public static extern Rect FromCoordinatesAndDimensions(
      float x,
      float y,
      float width,
      float height);

    /// <summary>Creates a new Rect value based on two points. C# and Microsoft Visual Basic code should use the Rect(Point,Point) constructor instead.</summary>
    /// <param name="point1">The first point.</param>
    /// <param name="point2">The second point.</param>
    /// <returns>The created Rect.</returns>
    [MethodImpl]
    public static extern Rect FromPoints(Point point1, Point point2);

    /// <summary>Creates a new Rect value based on a Point that specifies the upper-left origin, and a Size that specifies the width and height. C# and Microsoft Visual Basic code should use the Rect(Point,Size) constructor instead.</summary>
    /// <param name="location">The Point location of the origin (upper left).</param>
    /// <param name="size">The Size that specifies width and height.</param>
    /// <returns>The created Rect value.</returns>
    [MethodImpl]
    public static extern Rect FromLocationAndSize(Point location, Size size);

    /// <summary>Returns whether a specified Rect is equivalent to an Empty Rect. C# and Microsoft Visual Basic code should use Rect.IsEmpty instead.</summary>
    /// <param name="target">The Rect to evaluate.</param>
    /// <returns>**true** if the specified Rect is equivalent to an Empty Rect; otherwise, **false**.</returns>
    [MethodImpl]
    public static extern bool GetIsEmpty(Rect target);

    /// <summary>Gets a "Bottom" value for the specified Rect. So long as **Height** is positive, "Bottom" is evaluated as **Y** + **Height**. C# and Microsoft Visual Basic code should use Rect.Bottom instead.</summary>
    /// <param name="target">The Rect to evaluate.</param>
    /// <returns>The evaluated "Bottom" value.</returns>
    [MethodImpl]
    public static extern float GetBottom(Rect target);

    /// <summary>Gets a "Left" value for the specified Rect. So long as **Width** is positive, "Left" is evaluated as **X**. C# and Microsoft Visual Basic code should use Rect.Left instead.</summary>
    /// <param name="target">The Rect to evaluate.</param>
    /// <returns>The evaluated "Left" value.</returns>
    [MethodImpl]
    public static extern float GetLeft(Rect target);

    /// <summary>Gets a "Right" value for the specified Rect. So long as **Width** is positive, "Right" is evaluated as **X** + **Width**. C# and Microsoft Visual Basic code should use Rect.Right instead.</summary>
    /// <param name="target">The Rect to evaluate.</param>
    /// <returns>The evaluated "Right" value.</returns>
    [MethodImpl]
    public static extern float GetRight(Rect target);

    /// <summary>Gets a "Top" value for the specified Rect. So long as **Height** is positive, "Top" is evaluated as **Y**. C# and Microsoft Visual Basic code should use Rect.Top instead.</summary>
    /// <param name="target">The Rect to evaluate.</param>
    /// <returns>The evaluated "Top" value.</returns>
    [MethodImpl]
    public static extern float GetTop(Rect target);

    /// <summary>Returns whether a given Point is within the bounds of a given Rect, for a shared coordinate reference. C# and Microsoft Visual Basic code should use Rect.Contains instead.</summary>
    /// <param name="target">The Rect to evaluate.</param>
    /// <param name="point">The Point to check for containment.</param>
    /// <returns>**true** if *point* is within the *target* bounds; otherwise, **false**.</returns>
    [MethodImpl]
    public static extern bool Contains(Rect target, Point point);

    /// <summary>Provides comparison of the values of two Rect values. C# and Microsoft Visual Basic code should use the Equality (=) operator or Equals method instead.</summary>
    /// <param name="target">The first Rect to compare.</param>
    /// <param name="value">The second Rect to compare.</param>
    /// <returns>**true** if *target* and *value* hold equivalent values; otherwise, **false**.</returns>
    [MethodImpl]
    public static extern bool Equals(Rect target, Rect value);

    /// <summary>Returns the areas of two specified Rect values that intersect, as a new Rect. C# and Microsoft Visual Basic code should use Rect.Intersect instead.</summary>
    /// <param name="target">The first Rect to check for intersection.</param>
    /// <param name="rect">The second Rect to check for intersection.</param>
    /// <returns>A Rect that represents the areas of *target* and *rect* that intersect. Can be an Empty value if there is no intersection.</returns>
    [MethodImpl]
    public static extern Rect Intersect(Rect target, Rect rect);

    /// <summary>Creates a rectangle that is exactly large enough to contain the a specified rectangle and a specified point. C# and Microsoft Visual Basic code should use Rect.Union(Point) instead.</summary>
    /// <param name="target">The rectangle to include.</param>
    /// <param name="point">The point to include.</param>
    /// <returns>A rectangle that is exactly large enough to contain the specified rectangle and point.</returns>
    [Overload("UnionWithPoint")]
    [DefaultOverload]
    [MethodImpl]
    public static extern Rect Union(Rect target, Point point);

    /// <summary>Creates a rectangle that is exactly large enough to contain the two specified rectangles. C# and Microsoft Visual Basic code should use Rect.Union(Rect) instead.</summary>
    /// <param name="target">The first rectangle to include.</param>
    /// <param name="rect">The second rectangle to include.</param>
    /// <returns>A rectangle that is exactly large enough to contain the two specified rectangles.</returns>
    [Overload("UnionWithRect")]
    [MethodImpl]
    public static extern Rect Union(Rect target, Rect rect);
  }
}
