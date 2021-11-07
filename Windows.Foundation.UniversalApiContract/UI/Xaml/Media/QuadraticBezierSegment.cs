// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.QuadraticBezierSegment
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Media
{
  /// <summary>Creates a quadratic Bezier curve between two points in a PathFigure.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Threading(ThreadingModel.Both)]
  [Static(typeof (IQuadraticBezierSegmentStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [WebHostHidden]
  public sealed class QuadraticBezierSegment : PathSegment, IQuadraticBezierSegment
  {
    /// <summary>Initializes a new instance of the QuadraticBezierSegment class.</summary>
    [MethodImpl]
    public extern QuadraticBezierSegment();

    /// <summary>Gets or sets the control point of the curve.</summary>
    /// <returns>The control point of this QuadraticBezierSegment. The default value is a Point with value 0,0.</returns>
    public extern Point Point1 { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the end Point of this QuadraticBezierSegment.</summary>
    /// <returns>The end point of this QuadraticBezierSegment. The default value is a Point with value 0,0.</returns>
    public extern Point Point2 { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Identifies the Point1  dependency property.</summary>
    /// <returns>The identifier for the Point1  dependency property.</returns>
    public static extern DependencyProperty Point1Property { [MethodImpl] get; }

    /// <summary>Identifies the Point2  dependency property.</summary>
    /// <returns>The identifier for the Point2  dependency property.</returns>
    public static extern DependencyProperty Point2Property { [MethodImpl] get; }
  }
}
