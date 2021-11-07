// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.ArcSegment
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Media
{
  /// <summary>Represents an elliptical arc between two points.</summary>
  [Threading(ThreadingModel.Both)]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [WebHostHidden]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Static(typeof (IArcSegmentStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  public sealed class ArcSegment : PathSegment, IArcSegment
  {
    /// <summary>Initializes a new instance of the ArcSegment class.</summary>
    [MethodImpl]
    public extern ArcSegment();

    /// <summary>Gets or sets the endpoint of the elliptical arc.</summary>
    /// <returns>The point to which the arc is drawn. The default is a Point with value 0,0.</returns>
    public extern Point Point { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the x-radius and y-radius of the arc as a Size structure.</summary>
    /// <returns>A Size structure that describes the x-radius and y-radius of the elliptical arc. The Size structure's **Width** value specifies the arc's x-radius; its **Height** value specifies the arc's y-radius. The default is a Size with value 0,0.</returns>
    public extern Size Size { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the amount (in degrees) by which the ellipse is rotated about the x-axis.</summary>
    /// <returns>The amount (in degrees) by which the ellipse is rotated about the x-axis. The default is 0.</returns>
    public extern double RotationAngle { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a value that indicates whether the arc should be greater than 180 degrees.</summary>
    /// <returns>**true** if the arc should be greater than 180 degrees; otherwise, **false**.</returns>
    public extern bool IsLargeArc { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a value that specifies whether the arc is drawn in the **Clockwise** or **Counterclockwise** direction.</summary>
    /// <returns>One of the enumeration values that specifies the direction in which the arc is drawn. The default is **Counterclockwise**.</returns>
    public extern SweepDirection SweepDirection { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Identifies the Point dependency property.</summary>
    /// <returns>The Point dependency property identifier.</returns>
    public static extern DependencyProperty PointProperty { [MethodImpl] get; }

    /// <summary>Identifies the Size dependency property.</summary>
    /// <returns>The Size dependency property identifier.</returns>
    public static extern DependencyProperty SizeProperty { [MethodImpl] get; }

    /// <summary>Identifies the RotationAngle dependency property.</summary>
    /// <returns>The RotationAngle dependency property identifier.</returns>
    public static extern DependencyProperty RotationAngleProperty { [MethodImpl] get; }

    /// <summary>Identifies the IsLargeArc dependency property.</summary>
    /// <returns>The IsLargeArc dependency property identifier.</returns>
    public static extern DependencyProperty IsLargeArcProperty { [MethodImpl] get; }

    /// <summary>Identifies the SweepDirection dependency property.</summary>
    /// <returns>The SweepDirection dependency property identifier.</returns>
    public static extern DependencyProperty SweepDirectionProperty { [MethodImpl] get; }
  }
}
