// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.Maps.StreetsideExperience
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls.Maps
{
  /// <summary>Represents a custom map experience that provides a street-level view of a geographic location.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [WebHostHidden]
  [Threading(ThreadingModel.Both)]
  [Activatable(typeof (IStreetsideExperienceFactory), 65536, "Windows.Foundation.UniversalApiContract")]
  public sealed class StreetsideExperience : MapCustomExperience, IStreetsideExperience
  {
    /// <summary>Creates a StreetsideExperience based on the specified panoramic view.</summary>
    /// <param name="panorama">The panoramic view to appear in the StreetsideExperience.</param>
    [MethodImpl]
    public extern StreetsideExperience(StreetsidePanorama panorama);

    /// <summary>Creates a StreetsideExperience based on the specified panoramic view and camera position.</summary>
    /// <param name="panorama">The panoramic view to appear in the StreetsideExperience.</param>
    /// <param name="headingInDegrees">The directional heading of the map's camera in degrees, where 0 or 360 = North, 90 = East, 180 = South, and 270 = West. The default *headingInDegrees* value is 0.</param>
    /// <param name="pitchInDegrees">The pitch of the map's camera in degrees, where 90 is looking out at the horizon (maximum) and 0 is looking straight down (minimum). The default *pitchInDegrees* value is 90.</param>
    /// <param name="fieldOfViewInDegrees">The horizontal angle of view that appears in the map's camera, in degrees. The default *fieldOfViewInDegrees* value is 75.</param>
    [MethodImpl]
    public extern StreetsideExperience(
      StreetsidePanorama panorama,
      double headingInDegrees,
      double pitchInDegrees,
      double fieldOfViewInDegrees);

    /// <summary>Gets or sets a value that indicates if address text is visible in the StreetsideExperience.</summary>
    /// <returns>**true** if address text is visible in the StreetsideExperience; otherwise, **false**.</returns>
    public extern bool AddressTextVisible { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a value that indicates if the cursor is visible in the StreetsideExperience.</summary>
    /// <returns>**true** if the cursor is visible in the StreetsideExperience; otherwise, **false**.</returns>
    public extern bool CursorVisible { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a value that indicates if the overview map is visible in the StreetsideExperience.</summary>
    /// <returns>**true** if the overview map is visible in the StreetsideExperience; otherwise, **false**.</returns>
    public extern bool OverviewMapVisible { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a value that indicates if street labels are visible in the StreetsideExperience.</summary>
    /// <returns>**true** if street labels are visible in the StreetsideExperience; otherwise, **false**.</returns>
    public extern bool StreetLabelsVisible { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a value that indicates if the exit button is visible in the StreetsideExperience.</summary>
    /// <returns>**true** if the exit button is visible in the StreetsideExperience; otherwise, **false**.</returns>
    public extern bool ExitButtonVisible { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a value that indicates if zoom buttons are visible in the StreetsideExperience.</summary>
    /// <returns>**true** if zoom buttons are visible in the StreetsideExperience; otherwise, **false**.</returns>
    public extern bool ZoomButtonsVisible { [MethodImpl] get; [MethodImpl] set; }
  }
}
