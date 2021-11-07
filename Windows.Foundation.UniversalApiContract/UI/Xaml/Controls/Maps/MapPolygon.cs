// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.Maps.MapPolygon
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Devices.Geolocation;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls.Maps
{
  /// <summary>Represents a polygon on a MapControl.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [Static(typeof (IMapPolygonStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class MapPolygon : MapElement, IMapPolygon, IMapPolygon2
  {
    /// <summary>Initializes a new instance of the MapPolygon class.</summary>
    [MethodImpl]
    public extern MapPolygon();

    /// <summary>Gets or sets the collection of coordinates that define the MapPolygon shape.</summary>
    /// <returns>The collection of coordinates that define the MapPolygon shape.</returns>
    public extern Geopath Path { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the color used to draw the MapPolygon.</summary>
    /// <returns>The color to be used to draw the MapPolygon.</returns>
    public extern Color StrokeColor { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the width of the line used to draw the MapPolygon, in logical pixels.</summary>
    /// <returns>The width of the line used to draw the MapPolygon, in logical pixels.</returns>
    public extern double StrokeThickness { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a value that indicates whether the line used to draw the MapPolygon is dashed.</summary>
    /// <returns>**true** if the line used for drawing the MapPolygon is dashed; otherwise, **false**.</returns>
    public extern bool StrokeDashed { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the color used to fill the MapPolygon.</summary>
    /// <returns>The color to be used to fill the MapPolygon.</returns>
    public extern Color FillColor { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets a list of Geopath objects that define the MapPolygon shape.</summary>
    /// <returns>A list of Geopath objects that define the MapPolygon shape.</returns>
    public extern IVector<Geopath> Paths { [MethodImpl] get; }

    /// <summary>Identifies the Path dependency property.</summary>
    /// <returns>The identifier for the Path dependency property.</returns>
    public static extern DependencyProperty PathProperty { [MethodImpl] get; }

    /// <summary>Identifies the StrokeThickness dependency property.</summary>
    /// <returns>The identifier for the StrokeThickness dependency property.</returns>
    public static extern DependencyProperty StrokeThicknessProperty { [MethodImpl] get; }

    /// <summary>Identifies the StrokeDashed dependency property.</summary>
    /// <returns>The identifier for the StrokeDashed dependency property.</returns>
    public static extern DependencyProperty StrokeDashedProperty { [MethodImpl] get; }
  }
}
