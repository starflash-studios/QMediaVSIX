// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.PathFigure
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Markup;

namespace Windows.UI.Xaml.Media
{
  /// <summary>Represents a subsection of a geometry, a single connected series of two-dimensional geometric segments.</summary>
  [WebHostHidden]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContentProperty(Name = "Segments")]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [Static(typeof (IPathFigureStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class PathFigure : DependencyObject, IPathFigure
  {
    /// <summary>Initializes a new instance of the PathFigure class.</summary>
    [MethodImpl]
    public extern PathFigure();

    /// <summary>Gets or sets the collection of segments that define the shape of this PathFigure object.</summary>
    /// <returns>The collection of segments that define the shape of this PathFigure object. The default is an empty collection.</returns>
    public extern PathSegmentCollection Segments { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the Point where the PathFigure begins.</summary>
    /// <returns>The Point where the PathFigure begins. The default is a Point with value 0,0.</returns>
    public extern Point StartPoint { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a value that indicates whether this figure's first and last segments are connected.</summary>
    /// <returns>**true** if the first and last segments of the figure are connected; otherwise, **false**.</returns>
    public extern bool IsClosed { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a value that indicates whether the contained area of this PathFigure is to be used for hit-testing, rendering, and clipping.</summary>
    /// <returns>**true** if the contained area of this PathFigure is to be used for hit-testing, rendering, and clipping; otherwise, **false**. The default is **true**.</returns>
    public extern bool IsFilled { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Identifies the Segments dependency property.</summary>
    /// <returns>The identifier for the Segments dependency property.</returns>
    public static extern DependencyProperty SegmentsProperty { [MethodImpl] get; }

    /// <summary>Identifies the StartPoint dependency property.</summary>
    /// <returns>The identifier for the StartPoint dependency property.</returns>
    public static extern DependencyProperty StartPointProperty { [MethodImpl] get; }

    /// <summary>Identifies the IsClosed dependency property.</summary>
    /// <returns>The identifier for the IsClosed dependency property.</returns>
    public static extern DependencyProperty IsClosedProperty { [MethodImpl] get; }

    /// <summary>Identifies the IsFilled dependency property.</summary>
    /// <returns>The identifier for the IsFilled dependency property.</returns>
    public static extern DependencyProperty IsFilledProperty { [MethodImpl] get; }
  }
}
