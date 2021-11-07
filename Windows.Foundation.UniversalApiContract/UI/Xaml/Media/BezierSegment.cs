// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.BezierSegment
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Media
{
  /// <summary>Represents a cubic Bezier curve drawn between two points.</summary>
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Static(typeof (IBezierSegmentStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  public sealed class BezierSegment : PathSegment, IBezierSegment
  {
    /// <summary>Initializes a new instance of the BezierSegment class.</summary>
    [MethodImpl]
    public extern BezierSegment();

    /// <summary>Gets or sets the first control point of the curve.</summary>
    /// <returns>The first control point of the curve. The default is a Point with value 0,0.</returns>
    public extern Point Point1 { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the second control point of the curve.</summary>
    /// <returns>The second control point of the curve.</returns>
    public extern Point Point2 { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the end point of the curve.</summary>
    /// <returns>The end point of the curve.</returns>
    public extern Point Point3 { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Identifies the Point1 dependency property.</summary>
    /// <returns>The identifier for the Point1 dependency property.</returns>
    public static extern DependencyProperty Point1Property { [MethodImpl] get; }

    /// <summary>Identifies the Point2 dependency property.</summary>
    /// <returns>The identifier for the Point2 dependency property.</returns>
    public static extern DependencyProperty Point2Property { [MethodImpl] get; }

    /// <summary>Identifies the Point3 dependency property.</summary>
    /// <returns>The identifier for the Point3 dependency property.</returns>
    public static extern DependencyProperty Point3Property { [MethodImpl] get; }
  }
}
