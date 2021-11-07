// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.PolyLineSegment
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Markup;

namespace Windows.UI.Xaml.Media
{
  /// <summary>Represents a set of line segments defined by a Point collection with each Point specifying the end point of a line segment.</summary>
  [ContentProperty(Name = "Points")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [Static(typeof (IPolyLineSegmentStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [WebHostHidden]
  [Threading(ThreadingModel.Both)]
  public sealed class PolyLineSegment : PathSegment, IPolyLineSegment
  {
    /// <summary>Initializes a new instance of the PolyLineSegment class.</summary>
    [MethodImpl]
    public extern PolyLineSegment();

    /// <summary>Gets or sets the collection of Point values that defines this PolyLineSegment object.</summary>
    /// <returns>The points that define this PolyLineSegment object.</returns>
    public extern PointCollection Points { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Identifies the Points  dependency property.</summary>
    /// <returns>The identifier for the Points  dependency property.</returns>
    public static extern DependencyProperty PointsProperty { [MethodImpl] get; }
  }
}
