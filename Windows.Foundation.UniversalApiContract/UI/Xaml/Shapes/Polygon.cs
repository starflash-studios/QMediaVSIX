// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Shapes.Polygon
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Media;

namespace Windows.UI.Xaml.Shapes
{
  /// <summary>Draws a polygon, which is a connected series of lines that form a closed shape.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [WebHostHidden]
  [Static(typeof (IPolygonStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class Polygon : Shape, IPolygon
  {
    /// <summary>Initializes a new instance of the Polygon class.</summary>
    [MethodImpl]
    public extern Polygon();

    /// <summary>Gets or sets a value that specifies how the interior fill of the shape is determined.</summary>
    /// <returns>A value of the enumeration. The default is **EvenOdd**.</returns>
    public extern FillRule FillRule { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a collection that contains the vertex points of the polygon.</summary>
    /// <returns>A collection of Point structures that describes the vertex points of the polygon. The default is null. The value can be expressed as a string for XAML or type conversion.</returns>
    public extern PointCollection Points { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Identifies the FillRule dependency property.</summary>
    /// <returns>The identifier for the FillRule dependency property.</returns>
    public static extern DependencyProperty FillRuleProperty { [MethodImpl] get; }

    /// <summary>Identifies the Points dependency property.</summary>
    /// <returns>The identifier for the Points dependency property.</returns>
    public static extern DependencyProperty PointsProperty { [MethodImpl] get; }
  }
}
