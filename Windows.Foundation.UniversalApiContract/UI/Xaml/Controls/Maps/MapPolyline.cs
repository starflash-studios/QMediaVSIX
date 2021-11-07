// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.Maps.MapPolyline
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Devices.Geolocation;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls.Maps
{
  /// <summary>Represents a polyline on a MapControl.</summary>
  [WebHostHidden]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Static(typeof (IMapPolylineStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class MapPolyline : MapElement, IMapPolyline
  {
    /// <summary>Initializes a new instance of the MapPolyline class.</summary>
    [MethodImpl]
    public extern MapPolyline();

    /// <summary>Gets or sets the collection of coordinates that define the MapPolyline shape.</summary>
    /// <returns>The collection of coordinates that define the MapPolyline shape.</returns>
    public extern Geopath Path { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the color used to draw the MapPolyline.</summary>
    /// <returns>The color to be used to draw the MapPolyline.</returns>
    public extern Color StrokeColor { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the width of the line used to draw the MapPolyline, in logical pixels.</summary>
    /// <returns>The width of the line used to draw the MapPolyline, in logical pixels.</returns>
    public extern double StrokeThickness { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a value that indicates whether the line used to draw the MapPolyline is dashed.</summary>
    /// <returns>**true** if the line used for drawing the MapPolyline is dashed; otherwise, **false**.</returns>
    public extern bool StrokeDashed { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Identifies the Path dependency property.</summary>
    /// <returns>The identifier for the Path dependency property.</returns>
    public static extern DependencyProperty PathProperty { [MethodImpl] get; }

    /// <summary>Identifies the StrokeDashed dependency property.</summary>
    /// <returns>The identifier for the StrokeDashed dependency property.</returns>
    public static extern DependencyProperty StrokeDashedProperty { [MethodImpl] get; }
  }
}
