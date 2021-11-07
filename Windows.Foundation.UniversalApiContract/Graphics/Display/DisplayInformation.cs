// Decompiled with JetBrains decompiler
// Type: Windows.Graphics.Display.DisplayInformation
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Graphics.Display
{
  /// <summary>Monitors and controls display-related information for an application view. The class provides events to allow clients to monitor for changes in the application view affecting which display(s) the view resides on, as well as changes in displays that can affect the application view.</summary>
  [Static(typeof (IDisplayInformationStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class DisplayInformation : 
    IDisplayInformation,
    IDisplayInformation2,
    IDisplayInformation3,
    IDisplayInformation4,
    IDisplayInformation5
  {
    /// <summary>Gets the current orientation of a rectangular monitor.</summary>
    /// <returns>The current orientation of a rectangular monitor.</returns>
    public extern DisplayOrientations CurrentOrientation { [MethodImpl] get; }

    /// <summary>Gets the native orientation of the display monitor, which is typically the orientation where the buttons on the device match the orientation of the monitor.</summary>
    /// <returns>The native orientation of the display monitor.</returns>
    public extern DisplayOrientations NativeOrientation { [MethodImpl] get; }

    /// <summary>Occurs when either the CurrentOrientation or NativeOrientation property changes because of a mode change or a monitor change.</summary>
    public extern event TypedEventHandler<DisplayInformation, object> OrientationChanged;

    /// <summary>Gets the scale factor of the immersive environment.</summary>
    /// <returns>The scale factor of the immersive environment.</returns>
    public extern ResolutionScale ResolutionScale { [MethodImpl] get; }

    /// <summary>Gets the pixels per logical inch of the current environment.</summary>
    /// <returns>The pixels per logical inch of the current environment.</returns>
    public extern float LogicalDpi { [MethodImpl] get; }

    /// <summary>Gets the raw dots per inch (DPI) along the x axis of the display monitor.</summary>
    /// <returns>The raw dots per inch (DPI) along the x axis of the display monitor.</returns>
    public extern float RawDpiX { [MethodImpl] get; }

    /// <summary>Gets the raw dots per inch (DPI) along the y axis of the display monitor.</summary>
    /// <returns>The raw dots per inch (DPI) along the y axis of the display monitor.</returns>
    public extern float RawDpiY { [MethodImpl] get; }

    /// <summary>Occurs when the LogicalDpi property changes because the pixels per inch (PPI) of the display changes.</summary>
    public extern event TypedEventHandler<DisplayInformation, object> DpiChanged;

    /// <summary>Gets a value that indicates whether the device supports stereoscopic 3D.</summary>
    /// <returns>**TRUE** if the device is capable of stereoscopic 3D and stereoscopic 3D is currently enabled; **FALSE** otherwise.</returns>
    public extern bool StereoEnabled { [MethodImpl] get; }

    /// <summary>Occurs when the StereoEnabled property changes because support for stereoscopic 3D changes.</summary>
    public extern event TypedEventHandler<DisplayInformation, object> StereoEnabledChanged;

    /// <summary>Asynchronously gets the default International Color Consortium (ICC) color profile that is associated with the physical display.</summary>
    /// <returns>Object that manages the asynchronous retrieval of the color profile.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<IRandomAccessStream> GetColorProfileAsync();

    /// <summary>Occurs when the physical display's color profile changes.</summary>
    public extern event TypedEventHandler<DisplayInformation, object> ColorProfileChanged;

    /// <summary>Gets a value representing the number of raw (physical) pixels for each view (layout) pixel.</summary>
    /// <returns>A value representing the number of raw (physical) pixels for each view (layout) pixel.</returns>
    public extern double RawPixelsPerViewPixel { [MethodImpl] get; }

    /// <summary>Diagonal size of the display in inches.</summary>
    /// <returns>Returns the diagonal size of the display in inches. May return null when display size information is not available or undetermined (when connected to a projector, or displays are duplicated).</returns>
    public extern IReference<double> DiagonalSizeInInches { [MethodImpl] get; }

    /// <summary>Returns the current width resolution of the logical monitor.</summary>
    /// <returns>Returns the current resolution of the logical monitor containing the application’s view. When the application’s view is moved to another logical monitor, this property will reflect the new logical monitor’s resolution.</returns>
    public extern uint ScreenWidthInRawPixels { [MethodImpl] get; }

    /// <summary>Returns the current height resolution of the logical monitor.</summary>
    /// <returns>Returns the current resolution of the logical monitor containing the application’s view. When the application’s view is moved to another logical monitor, this property will reflect the new logical monitor’s resolution.</returns>
    public extern uint ScreenHeightInRawPixels { [MethodImpl] get; }

    /// <summary>Retrieves the Advanced Color information.</summary>
    /// <returns>The Advanced Color information.</returns>
    [MethodImpl]
    public extern AdvancedColorInfo GetAdvancedColorInfo();

    /// <summary>Raised when the advanced color information is changed.</summary>
    public extern event TypedEventHandler<DisplayInformation, object> AdvancedColorInfoChanged;

    /// <summary>Gets the  DisplayInformation instance associated with the current thread's CoreApplicationView. This DisplayInformation instance is tied to the view and cannot be used from other threads.</summary>
    /// <returns>A DisplayInformation object that provides display-related information for the current thread's view.</returns>
    [MethodImpl]
    public static extern DisplayInformation GetForCurrentView();

    /// <summary>Gets and sets the preferred orientation of the app.</summary>
    /// <returns>The orientation of a rectangular monitor.</returns>
    public static extern DisplayOrientations AutoRotationPreferences { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Occurs when the display requires redrawing.</summary>
    public static extern event TypedEventHandler<DisplayInformation, object> DisplayContentsInvalidated;
  }
}
