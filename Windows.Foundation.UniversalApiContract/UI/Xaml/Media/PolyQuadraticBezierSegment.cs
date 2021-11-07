// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.PolyQuadraticBezierSegment
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Markup;

namespace Windows.UI.Xaml.Media
{
  /// <summary>Represents a set of quadratic Bezier segments.</summary>
  [Threading(ThreadingModel.Both)]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [Static(typeof (IPolyQuadraticBezierSegmentStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContentProperty(Name = "Points")]
  public sealed class PolyQuadraticBezierSegment : PathSegment, IPolyQuadraticBezierSegment
  {
    /// <summary>Initializes a new instance of the PolyQuadraticBezierSegment class.</summary>
    [MethodImpl]
    public extern PolyQuadraticBezierSegment();

    /// <summary>Gets or sets the Point collection that defines this PolyQuadraticBezierSegment object.</summary>
    /// <returns>A collection of points that defines the shape of this PolyQuadraticBezierSegment object. The default value is an empty collection.</returns>
    public extern PointCollection Points { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Identifies the Points  dependency property.</summary>
    /// <returns>The identifier for the Points  dependency property.</returns>
    public static extern DependencyProperty PointsProperty { [MethodImpl] get; }
  }
}
