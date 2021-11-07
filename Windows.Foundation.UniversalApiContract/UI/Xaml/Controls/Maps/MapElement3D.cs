// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.Maps.MapElement3D
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Devices.Geolocation;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Foundation.Numerics;

namespace Windows.UI.Xaml.Controls.Maps
{
  /// <summary>Represents a 3D element displayed on a MapControl.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [Activatable(327680, "Windows.Foundation.UniversalApiContract")]
  [Static(typeof (IMapElement3DStatics), 327680, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  public sealed class MapElement3D : MapElement, IMapElement3D
  {
    /// <summary>Creates a MapElement3D instance.</summary>
    [MethodImpl]
    public extern MapElement3D();

    /// <summary>Gets or sets the geographic location of the MapElement3D on the MapControl. .</summary>
    /// <returns>The geographic location of the MapElement3D on the MapControl.</returns>
    public extern Geopoint Location { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the 3D model that represents a 3D object.</summary>
    /// <returns>the 3D model that represents a 3D object.</returns>
    public extern MapModel3D Model { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the directional heading of the 3D map element in degrees, where 0 or 360 = North, 90 = East, 180 = South, and 270 = West.</summary>
    /// <returns>The directional heading of the map in degrees, where 0 or 360 = North, 90 = East, 180 = South, and 270 = West. The default value is 0.</returns>
    public extern double Heading { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a value that indicates by how many degrees you want the 3D map element to be tilted. A value of 0 is looking out at the horizon and a value of -90 is looking straight down. A value of 90 is looking straight up. The default value is 0.</summary>
    /// <returns>A value that indicates by how many degrees you want the 3D map element to be tilted.</returns>
    public extern double Pitch { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the roll of the 3D map element in degrees, where -90 is tilting to the left and +90 is tilting to the right.</summary>
    /// <returns>The roll of the 3D map element in degrees, where -90 is tilting to the left and +90 is tilting to the right.</returns>
    public extern double Roll { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>The scale to apply to the 3D map element.</summary>
    /// <returns>The scale to apply to the 3D map element. A value of Vector3 (1.0,1.0,1.0) is equivalent to 100%.</returns>
    public extern Vector3 Scale { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Identifies the LocationProperty dependency property.</summary>
    /// <returns>The LocationProperty dependency property.</returns>
    public static extern DependencyProperty LocationProperty { [MethodImpl] get; }

    /// <summary>Identifies the Heading dependency property.</summary>
    /// <returns>The Heading dependency property.</returns>
    public static extern DependencyProperty HeadingProperty { [MethodImpl] get; }

    /// <summary>Identifies the Pitch dependency property.</summary>
    /// <returns>The Pitch dependency property.</returns>
    public static extern DependencyProperty PitchProperty { [MethodImpl] get; }

    /// <summary>Identifies the Pitch dependency property.</summary>
    /// <returns>The Pitch dependency property.</returns>
    public static extern DependencyProperty RollProperty { [MethodImpl] get; }

    /// <summary>Identifies the Roll dependency property.</summary>
    /// <returns>The Roll dependency property.</returns>
    public static extern DependencyProperty ScaleProperty { [MethodImpl] get; }
  }
}
