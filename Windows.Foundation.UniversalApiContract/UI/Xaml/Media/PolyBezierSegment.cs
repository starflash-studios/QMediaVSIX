// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.PolyBezierSegment
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Markup;

namespace Windows.UI.Xaml.Media
{
  /// <summary>Represents one or more cubic Bezier curves.</summary>
  [Static(typeof (IPolyBezierSegmentStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [ContentProperty(Name = "Points")]
  [WebHostHidden]
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class PolyBezierSegment : PathSegment, IPolyBezierSegment
  {
    /// <summary>Initializes a new instance of the PolyBezierSegment class.</summary>
    [MethodImpl]
    public extern PolyBezierSegment();

    /// <summary>Gets or sets the Point collection that defines this PolyBezierSegment object.</summary>
    /// <returns>The collection of points that defines this PolyBezierSegment object.</returns>
    public extern PointCollection Points { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Identifies the Points  dependency property.</summary>
    /// <returns>The identifier for the Points  dependency property.</returns>
    public static extern DependencyProperty PointsProperty { [MethodImpl] get; }
  }
}
