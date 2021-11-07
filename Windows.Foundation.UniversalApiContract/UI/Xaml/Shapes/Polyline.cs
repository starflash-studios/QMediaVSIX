// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Shapes.Polyline
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Media;

namespace Windows.UI.Xaml.Shapes
{
  /// <summary>Draws a series of connected straight lines.</summary>
  [Threading(ThreadingModel.Both)]
  [WebHostHidden]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Static(typeof (IPolylineStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  public sealed class Polyline : Shape, IPolyline
  {
    /// <summary>Initializes a new instance of the Polyline class.</summary>
    [MethodImpl]
    public extern Polyline();

    /// <summary>Gets or sets a value that specifies how the interior fill of the shape is determined.</summary>
    /// <returns>A value of the enumeration that specifies the fill behavior. The default is **EvenOdd**.</returns>
    public extern FillRule FillRule { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a collection that contains the vertex points of the Polyline.</summary>
    /// <returns>A collection of Point structures that describes the vertex points of the Polyline. The default is null.</returns>
    public extern PointCollection Points { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Identifies the FillRule dependency property.</summary>
    /// <returns>The identifier for the FillRule dependency property.</returns>
    public static extern DependencyProperty FillRuleProperty { [MethodImpl] get; }

    /// <summary>Identifies the Points dependency property.</summary>
    /// <returns>The identifier for the Points dependency property.</returns>
    public static extern DependencyProperty PointsProperty { [MethodImpl] get; }
  }
}
