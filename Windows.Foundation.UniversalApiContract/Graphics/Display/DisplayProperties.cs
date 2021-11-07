// Decompiled with JetBrains decompiler
// Type: Windows.Graphics.Display.DisplayProperties
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Graphics.Display
{
  /// <summary> Provides various properties that are related to the physical display. For most of these properties, the class provides events to allow clients to monitor for changes in the properties.</summary>
  /// <deprecated type="deprecate">DisplayProperties may be altered or unavailable for releases after Windows Phone 8.1. Instead, use DisplayInformation.</deprecated>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Static(typeof (IDisplayPropertiesStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [Muse(Version = 100859904)]
  [Deprecated("DisplayProperties may be altered or unavailable for releases after Windows Phone 8.1. Instead, use DisplayInformation.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract")]
  public static class DisplayProperties
  {
    /// <summary> Gets the current orientation of a rectangular monitor.</summary>
    /// <returns>The current orientation of a rectangular monitor.</returns>
    public static extern DisplayOrientations CurrentOrientation { [Deprecated("DisplayProperties may be altered or unavailable for releases after Windows Phone 8.1. Instead, use DisplayInformation.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract"), MethodImpl] get; }

    /// <summary> Gets the native orientation of the display monitor, which is typically the orientation where the buttons on the device match the orientation of the monitor.</summary>
    /// <returns>The native orientation of the display monitor.</returns>
    public static extern DisplayOrientations NativeOrientation { [Deprecated("DisplayProperties may be altered or unavailable for releases after Windows Phone 8.1. Instead, use DisplayInformation.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract"), MethodImpl] get; }

    /// <summary> Gets and sets the preferred orientation of the app.</summary>
    /// <returns>The orientation of a rectangular monitor.</returns>
    public static extern DisplayOrientations AutoRotationPreferences { [Deprecated("DisplayProperties may be altered or unavailable for releases after Windows Phone 8.1. Instead, use DisplayInformation.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract"), MethodImpl] get; [Deprecated("DisplayProperties may be altered or unavailable for releases after Windows Phone 8.1. Instead, use DisplayInformation.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract"), MethodImpl] set; }

    /// <summary> Occurs when either the CurrentOrientation or NativeOrientation property changes because of a mode change or a monitor change.</summary>
    public static extern event DisplayPropertiesEventHandler OrientationChanged;

    /// <summary> Gets the scale factor of the immersive environment.</summary>
    /// <returns>The scale factor of the immersive environment.</returns>
    public static extern ResolutionScale ResolutionScale { [Deprecated("DisplayProperties may be altered or unavailable for releases after Windows Phone 8.1. Instead, use DisplayInformation.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract"), MethodImpl] get; }

    /// <summary> Gets the pixels per logical inch of the current environment.</summary>
    /// <returns>The pixels per logical inch of the current environment.</returns>
    public static extern float LogicalDpi { [Deprecated("DisplayProperties may be altered or unavailable for releases after Windows Phone 8.1. Instead, use DisplayInformation.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract"), MethodImpl] get; }

    /// <summary> Occurs when the LogicalDpi property changes because the pixels per inch (PPI) of the display changes.</summary>
    public static extern event DisplayPropertiesEventHandler LogicalDpiChanged;

    /// <summary> Gets a value that indicates whether the device supports stereoscopic 3D.</summary>
    /// <returns>**TRUE** if the device is capable of stereoscopic 3D and stereoscopic 3D is currently enabled; **FALSE** otherwise.</returns>
    public static extern bool StereoEnabled { [Deprecated("DisplayProperties may be altered or unavailable for releases after Windows Phone 8.1. Instead, use DisplayInformation.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract"), MethodImpl] get; }

    /// <summary> Occurs when the StereoEnabled property changes because support for stereoscopic 3D changes.</summary>
    public static extern event DisplayPropertiesEventHandler StereoEnabledChanged;

    /// <summary> Asynchronously gets the default International Color Consortium (ICC) color profile that is associated with the physical display.</summary>
    /// <deprecated type="deprecate">DisplayProperties may be altered or unavailable for releases after Windows Phone 8.1. Instead, use DisplayInformation.</deprecated>
    /// <returns>Object that manages the asynchronous retrieval of the color profile.</returns>
    [RemoteAsync]
    [Deprecated("DisplayProperties may be altered or unavailable for releases after Windows Phone 8.1. Instead, use DisplayInformation.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract")]
    [MethodImpl]
    public static extern IAsyncOperation<IRandomAccessStream> GetColorProfileAsync();

    /// <summary> Occurs when the physical display's color profile changes.</summary>
    public static extern event DisplayPropertiesEventHandler ColorProfileChanged;

    /// <summary>Occurs when the display requires redrawing.</summary>
    public static extern event DisplayPropertiesEventHandler DisplayContentsInvalidated;
  }
}
