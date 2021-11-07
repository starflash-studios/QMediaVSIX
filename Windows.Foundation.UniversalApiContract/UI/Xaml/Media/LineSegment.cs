// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.LineSegment
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Media
{
  /// <summary>Represents a line drawn between two points, which can be part of a PathFigure within Path data.</summary>
  [WebHostHidden]
  [Threading(ThreadingModel.Both)]
  [Static(typeof (ILineSegmentStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class LineSegment : PathSegment, ILineSegment
  {
    /// <summary>Initializes a new instance of the LineSegment class.</summary>
    [MethodImpl]
    public extern LineSegment();

    /// <summary>Gets or sets the end point of the line segment.</summary>
    /// <returns>The end point of the line segment. The default is a Point with value 0,0.</returns>
    public extern Point Point { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Identifies the Point dependency property.</summary>
    /// <returns>The identifier for the Point dependency property.</returns>
    public static extern DependencyProperty PointProperty { [MethodImpl] get; }
  }
}
