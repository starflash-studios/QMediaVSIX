// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.Maps.MapBillboard
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Devices.Geolocation;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.UI.Xaml.Controls.Maps
{
  /// <summary>Displays an image that scales and fades in relation to its distance from the ReferenceCamera of the MapBillboard.</summary>
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [WebHostHidden]
  [Activatable(typeof (IMapBillboardFactory), 262144, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  [Static(typeof (IMapBillboardStatics), 262144, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class MapBillboard : MapElement, IMapBillboard
  {
    /// <summary>Initializes a new instance of the MapBillboard class.</summary>
    /// <param name="camera">The MapCamera settings that define the current position of the reference camera.</param>
    [MethodImpl]
    public extern MapBillboard(MapCamera camera);

    /// <summary>Gets or sets the geographic location of the MapBillboard on the MapControl. The location is the geographic location on the MapControl at which the NormalizedAnchorPoint of the MapBillboard is positioned.</summary>
    /// <returns>The geographic location of the MapBillboard on the MapControl.</returns>
    public extern Geopoint Location { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the anchor point of the MapBillboard. The anchor point is the point on the MapBillboard that is positioned at the point on the MapControl specified by the Location property.</summary>
    /// <returns>The anchor point of the MapBillboard.</returns>
    public extern Point NormalizedAnchorPoint { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the image for the MapBillboard. Provide an optional custom image to replace the default point of interest (POI) image.</summary>
    /// <returns>The point of interest (POI) image for the MapBillboard.</returns>
    public extern IRandomAccessStreamReference Image { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the behavior of a MapBillboard when it collides with other map features due to zoom level.</summary>
    /// <returns>The behavior of a MapBillboard when it collides with other map features due to zoom level.</returns>
    public extern MapElementCollisionBehavior CollisionBehaviorDesired { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets the MapCamera settings that define the position and orientation where the image appears at a 1x scale.</summary>
    /// <returns>The MapCamera settings that define the position and orientation where the image appears at a 1x scale.</returns>
    public extern MapCamera ReferenceCamera { [MethodImpl] get; }

    /// <summary>Identifies the Location dependency property.</summary>
    /// <returns>The identifier for the Location dependency property.</returns>
    public static extern DependencyProperty LocationProperty { [MethodImpl] get; }

    /// <summary>Identifies the NormalizedAnchorPoint dependency property.</summary>
    /// <returns>The identifier for the NormalizedAnchorPoint dependency property.</returns>
    public static extern DependencyProperty NormalizedAnchorPointProperty { [MethodImpl] get; }

    /// <summary>Identifies the CollisionBehaviorDesired dependency property.</summary>
    /// <returns>Identifier for the CollisionBehaviorDesired dependency property.</returns>
    public static extern DependencyProperty CollisionBehaviorDesiredProperty { [MethodImpl] get; }
  }
}
