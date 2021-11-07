// Decompiled with JetBrains decompiler
// Type: Windows.Services.Maps.PlaceInfo
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Devices.Geolocation;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Popups;

namespace Windows.Services.Maps
{
  /// <summary>Displays a map location and information that describes that location in a light-dismissible window which closes automatically when the user clicks outside of the window.</summary>
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  [Static(typeof (IPlaceInfoStatics2), 393216, "Windows.Foundation.UniversalApiContract")]
  [Static(typeof (IPlaceInfoStatics), 327680, "Windows.Foundation.UniversalApiContract")]
  public sealed class PlaceInfo : IPlaceInfo
  {
    /// <summary>Shows in a pop-up window, the map location and related information that is described in the PlaceInfo.</summary>
    /// <param name="selection">The Rect is the rectangular area of user selection (for example, pressing a button), around which the operating system displays the light-dismissible window, not within that rectangular area. For example, if an app uses a button to show the place, pass the Rect of the button so the light-dismissible window displays around the button, not overlapping it.</param>
    [Overload("Show")]
    [MethodImpl]
    public extern void Show(Rect selection);

    /// <summary>Shows in a light-dismissible window, the map location and related information that is described in the PlaceInfo.</summary>
    /// <param name="selection">The Rect is the rectangular area of user selection (for example, pressing a button), around which the operating system displays the light-dismissible window, not within that rectangular area. For example, if an app uses a button to show the place, pass the Rect of the button so the light-dismissible window displays around the button, not overlapping it.</param>
    /// <param name="preferredPlacement">The preferred placement of the light-dismissible window relative to the rectangle.</param>
    [Overload("ShowWithPreferredPlacement")]
    [MethodImpl]
    public extern void Show(Rect selection, Placement preferredPlacement);

    /// <summary>Gets the identifier associated with the PlaceInfo.</summary>
    /// <returns>Gets the identifier associated with the PlaceInfo.</returns>
    public extern string Identifier { [MethodImpl] get; }

    /// <summary>Gets the display name associated with the PlaceInfo.</summary>
    /// <returns>The display name associated with the PlaceInfo.</returns>
    public extern string DisplayName { [MethodImpl] get; }

    /// <summary>Gets the address associated with the PlaceInfo.</summary>
    /// <returns>The address associated with the PlaceInfo.</returns>
    public extern string DisplayAddress { [MethodImpl] get; }

    /// <summary>Gets the geographical shape associated with the PlaceInfo.</summary>
    /// <returns>The geographical shape associated with the PlaceInfo.</returns>
    public extern IGeoshape Geoshape { [MethodImpl] get; }

    /// <summary>Creates a PlaceInfo instance by using an address.</summary>
    /// <param name="displayAddress">The address of the location that you want to appear in the placecard.</param>
    /// <returns>
    /// </returns>
    [Overload("CreateFromAddress")]
    [MethodImpl]
    public static extern PlaceInfo CreateFromAddress(string displayAddress);

    /// <summary>Creates a PlaceInfo instance by using an address and a display name.</summary>
    /// <param name="displayAddress">The address of the location that you want to appear in the placecard.</param>
    /// <param name="displayName">The name that you want to appear as a label in the placecard.</param>
    /// <returns>
    /// </returns>
    [Overload("CreateFromAddressWithName")]
    [MethodImpl]
    public static extern PlaceInfo CreateFromAddress(
      string displayAddress,
      string displayName);

    /// <summary>Creates a PlaceInfo instance.</summary>
    /// <param name="referencePoint">The geographic map location that you want to show in a light-dismissible window.</param>
    /// <returns>A PlaceInfo instance that describes the location.</returns>
    [Overload("Create")]
    [MethodImpl]
    public static extern PlaceInfo Create(Geopoint referencePoint);

    /// <summary>Creates a PlaceInfo instance.</summary>
    /// <param name="referencePoint">The geographic map location that you want to show in a light-dismissible window.</param>
    /// <param name="options">The optional information that describes this location. This information will appear in the light-dismissible window.</param>
    /// <returns>A PlaceInfo instance that describes the location.</returns>
    [Overload("CreateWithGeopointAndOptions")]
    [MethodImpl]
    public static extern PlaceInfo Create(
      Geopoint referencePoint,
      PlaceInfoCreateOptions options);

    /// <summary>Creates a PlaceInfo instance.</summary>
    /// <param name="identifier">The identifier of the location.</param>
    /// <returns>A PlaceInfo instance that describes the location.</returns>
    [Overload("CreateFromIdentifier")]
    [MethodImpl]
    public static extern PlaceInfo CreateFromIdentifier(string identifier);

    /// <summary>Creates a PlaceInfo instance.</summary>
    /// <param name="identifier">The identifier of the location.</param>
    /// <param name="defaultPoint">The geographic map location that you want to show in a light-dismissible window.</param>
    /// <param name="options">The optional information that describes this location. This information will appear in the light-dismissible window.</param>
    /// <returns>A PlaceInfo instance that describes the location.</returns>
    [Overload("CreateFromIdentifierWithOptions")]
    [MethodImpl]
    public static extern PlaceInfo CreateFromIdentifier(
      string identifier,
      Geopoint defaultPoint,
      PlaceInfoCreateOptions options);

    /// <summary>Creates a PlaceInfo instance.</summary>
    /// <param name="location">The geographic map location that you want to show in a light-dismissible window.</param>
    /// <returns>A PlaceInfo instance that describes the location.</returns>
    [MethodImpl]
    public static extern PlaceInfo CreateFromMapLocation(MapLocation location);

    /// <summary>Gets a value that indicates whether your app can show a light-dismissible window that contains a map location and related information given the current context.</summary>
    /// <returns>**true** if your app can show a light-dismissible window that contains a map location and related information given the current context; otherwise, **false**.</returns>
    public static extern bool IsShowSupported { [MethodImpl] get; }
  }
}
