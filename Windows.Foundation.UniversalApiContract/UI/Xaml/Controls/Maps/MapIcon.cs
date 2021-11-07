// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.Maps.MapIcon
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
  /// <summary>Displays an image such as a pushpin with optional text on a MapControl. Use the default image or provide a custom image.</summary>
  [Static(typeof (IMapIconStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [Static(typeof (IMapIconStatics2), 65536, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  public sealed class MapIcon : MapElement, IMapIcon, IMapIcon2
  {
    /// <summary>Initializes a new instance of the MapIcon class.</summary>
    [MethodImpl]
    public extern MapIcon();

    /// <summary>Gets or sets the geographic location of the MapIcon on the MapControl. The location is the geographic location on the MapControl at which the NormalizedAnchorPoint of the MapIcon is positioned.</summary>
    /// <returns>The geographic location of the MapIcon on the MapControl.</returns>
    public extern Geopoint Location { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the optional text of the MapIcon.</summary>
    /// <returns>The title of the MapIcon.</returns>
    public extern string Title { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the anchor point of the MapIcon. The anchor point is the point on the MapIcon that is positioned at the point on the MapControl specified by the Location property.</summary>
    /// <returns>The anchor point of the MapIcon.</returns>
    public extern Point NormalizedAnchorPoint { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the image for the MapIcon. Provide an optional custom image to replace the default point of interest (POI) image.</summary>
    /// <returns>The point of interest (POI) image for the MapIcon.</returns>
    public extern IRandomAccessStreamReference Image { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the behavior of a MapIcon when it collides with other map features due to zoom level.</summary>
    /// <returns>The behavior of a MapIcon when it collides with other map features due to zoom level.</returns>
    public extern MapElementCollisionBehavior CollisionBehaviorDesired { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Identifies the CollisionBehaviorDesired dependency property.</summary>
    /// <returns>Identifier for the CollisionBehaviorDesired dependency property.</returns>
    public static extern DependencyProperty CollisionBehaviorDesiredProperty { [MethodImpl] get; }

    /// <summary>Identifies the Location dependency property.</summary>
    /// <returns>The identifier for the Location dependency property.</returns>
    public static extern DependencyProperty LocationProperty { [MethodImpl] get; }

    /// <summary>Identifies the Title dependency property.</summary>
    /// <returns>The identifier for the Title dependency property.</returns>
    public static extern DependencyProperty TitleProperty { [MethodImpl] get; }

    /// <summary>Identifies the NormalizedAnchorPoint dependency property.</summary>
    /// <returns>The identifier for the NormalizedAnchorPoint dependency property.</returns>
    public static extern DependencyProperty NormalizedAnchorPointProperty { [MethodImpl] get; }
  }
}
