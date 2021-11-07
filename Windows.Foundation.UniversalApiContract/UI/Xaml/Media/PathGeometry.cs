// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.PathGeometry
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Markup;

namespace Windows.UI.Xaml.Media
{
  /// <summary>Represents a complex vector-based shape that may be composed of arcs, curves, ellipses, lines, and rectangles.</summary>
  [Threading(ThreadingModel.Both)]
  [ContentProperty(Name = "Figures")]
  [WebHostHidden]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Static(typeof (IPathGeometryStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class PathGeometry : Geometry, IPathGeometry
  {
    /// <summary>Initializes a new instance of the PathGeometry class.</summary>
    [MethodImpl]
    public extern PathGeometry();

    /// <summary>Gets or sets a value that determines how the intersecting areas contained in the PathGeometry are combined.</summary>
    /// <returns>A FillRule enumeration value that indicates how the intersecting areas of the PathGeometry are combined. The default is **EvenOdd**.</returns>
    public extern FillRule FillRule { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the collection of PathFigure objects that describe the contents of a path.</summary>
    /// <returns>A collection of PathFigure objects that describe the contents of a path. Each individual PathFigure describes a shape.</returns>
    public extern PathFigureCollection Figures { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Identifies the FillRule dependency property.</summary>
    /// <returns>The identifier for the FillRule dependency property.</returns>
    public static extern DependencyProperty FillRuleProperty { [MethodImpl] get; }

    /// <summary>Identifies the Figures dependency property.</summary>
    /// <returns>The identifier for the Figures dependency property.</returns>
    public static extern DependencyProperty FiguresProperty { [MethodImpl] get; }
  }
}
