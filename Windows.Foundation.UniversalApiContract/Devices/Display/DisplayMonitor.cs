// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Display.DisplayMonitor
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Graphics;

namespace Windows.Devices.Display
{
  /// <summary>Provides information about a display monitor device connected to the system.</summary>
  [ContractVersion(typeof (UniversalApiContract), 393216)]
  [Static(typeof (IDisplayMonitorStatics), 393216, "Windows.Foundation.UniversalApiContract")]
  [DualApiPartition(version = 167772165)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  public sealed class DisplayMonitor : IDisplayMonitor, IDisplayMonitor2
  {
    /// <summary>Gets the device identifier.</summary>
    /// <returns>The device identifier if known, otherwise `null`.</returns>
    public extern string DeviceId { [MethodImpl] get; }

    /// <summary>Gets a friendly name for the device suitable for display to a user.</summary>
    /// <returns>A friendly name for the device suitable for display to a user if known, otherwise `null`.</returns>
    public extern string DisplayName { [MethodImpl] get; }

    /// <summary>Gets a value representing the abstract method in which the display is connected (not specific to a physical protocol).</summary>
    /// <returns>A value representing the abstract method in which the display is connected.</returns>
    public extern DisplayMonitorConnectionKind ConnectionKind { [MethodImpl] get; }

    /// <summary>Gets a value representing the physical connector standard used to connect the display.</summary>
    /// <returns>A value representing the physical connector standard used to connect the display.</returns>
    public extern DisplayMonitorPhysicalConnectorKind PhysicalConnector { [MethodImpl] get; }

    /// <summary>Gets the device identifier of the display adapter to which the monitor is connected. Note that the display adapter may not be the most suitable device for rendering.</summary>
    /// <returns>The device identifier for the display adapter to which the monitor is connected if known, otherwise `null`.</returns>
    public extern string DisplayAdapterDeviceId { [MethodImpl] get; }

    /// <summary>Gets the locally unique identifier (LUID) of the display adapter to which the monitor is connected. Note that the display adapter to which the monitor is connected may not be the most suitable one for rendering.</summary>
    /// <returns>A DisplayAdapterId containing the numeric locally unique ID (LUID) of the display adapter to which the monitor is connected if known, otherwise `null`.</returns>
    public extern DisplayAdapterId DisplayAdapterId { [MethodImpl] get; }

    /// <summary>Gets an opaque ID used by the display adapter to identify which connector the monitor is attached to. This target ID can be used with DisplayConfig APIs.</summary>
    /// <returns>An opaque ID used by the display adapter to identify which connector the monitor is attached to.</returns>
    public extern uint DisplayAdapterTargetId { [MethodImpl] get; }

    /// <summary>Gets a value representing the use to which the display is being put.</summary>
    /// <returns>A value representing the use to which the display is being put.</returns>
    public extern DisplayMonitorUsageKind UsageKind { [MethodImpl] get; }

    /// <summary>Gets the monitor's native resolution in raw pixels.</summary>
    /// <returns>The monitor's native resolution in raw pixels.</returns>
    public extern SizeInt32 NativeResolutionInRawPixels { [MethodImpl] get; }

    /// <summary>Gets the monitor's physical diagonal size in inches.</summary>
    /// <returns>The monitor's physical diagonal size in inches if known, otherwise `null`.</returns>
    public extern IReference<Size> PhysicalSizeInInches { [MethodImpl] get; }

    /// <summary>Gets the physical horizontal DPI of the monitor (based on the monitor’s native resolution and physical size).</summary>
    /// <returns>The physical horizontal DPI of the monitor (based on the monitor’s native resolution and physical size).</returns>
    public extern float RawDpiX { [MethodImpl] get; }

    /// <summary>Gets the physical vertical DPI of the monitor (based on the monitor’s native resolution and physical size).</summary>
    /// <returns>The physical vertical DPI of the monitor (based on the monitor’s native resolution and physical size).</returns>
    public extern float RawDpiY { [MethodImpl] get; }

    /// <summary>Gets the chromaticity red primary point (calculated from the monitor's Extended Display Identification Data, or EDID, and any driver overrides).</summary>
    /// <returns>The chromaticity red primary point (calculated from the monitor's Extended Display Identification Data, or EDID, and any driver overrides) if known, otherwise `null`.</returns>
    public extern Point RedPrimary { [MethodImpl] get; }

    /// <summary>Gets the chromaticity green primary point (calculated from the monitor's Extended Display Identification Data, or EDID, and any driver overrides).</summary>
    /// <returns>The chromaticity green primary point (calculated from the monitor's Extended Display Identification Data, or EDID, and any driver overrides) if known, otherwise `null`.</returns>
    public extern Point GreenPrimary { [MethodImpl] get; }

    /// <summary>Gets the chromaticity blue primary point (calculated from the monitor's Extended Display Identification Data, or EDID, and any driver overrides).</summary>
    /// <returns>The chromaticity blue primary point (calculated from the monitor's Extended Display Identification Data, or EDID, and any driver overrides) if known, otherwise `null`.</returns>
    public extern Point BluePrimary { [MethodImpl] get; }

    /// <summary>Gets the chromaticity white point (calculated from the monitor's Extended Display Identification Data, or EDID, and any driver overrides).</summary>
    /// <returns>The chromaticity white point (calculated from the monitor's Extended Display Identification Data, or EDID, and any driver overrides) if known, otherwise `null`.</returns>
    public extern Point WhitePoint { [MethodImpl] get; }

    /// <summary>Gets the monitor's maximum luminance in nits.</summary>
    /// <returns>The monitor's maximum luminance in nits.</returns>
    public extern float MaxLuminanceInNits { [MethodImpl] get; }

    /// <summary>Gets the monitor's minimum luminance in nits.</summary>
    /// <returns>The monitor's minimum luminance in nits.</returns>
    public extern float MinLuminanceInNits { [MethodImpl] get; }

    /// <summary>Gets the monitor's maximum average full-frame luminance in nits.</summary>
    /// <returns>The monitor's maximum average full-frame luminance in nits.</returns>
    public extern float MaxAverageFullFrameLuminanceInNits { [MethodImpl] get; }

    /// <summary>Retrieves a hardware descriptor of the kind specified.</summary>
    /// <param name="descriptorKind">The kind of descriptor to retrieve.</param>
    /// <returns>A byte array containing a hardware descriptor of the kind specified.</returns>
    [MethodImpl]
    public extern byte[] GetDescriptor(DisplayMonitorDescriptorKind descriptorKind);

    /// <summary>Gets a value that indicates whether the monitor's metadata has specified that it treats high dynamic range (HDR) as a special *Dolby Vision* mode. This API is intended to be used by the Dolby audio decoder running within media to play specially certified content.</summary>
    /// <returns>`true` if the monitor's metadata has specified that it treats high dynamic range (HDR) as a special *Dolby Vision* mode, otherwise `false`.</returns>
    public extern bool IsDolbyVisionSupportedInHdrMode { [MethodImpl] get; }

    /// <summary>Returns an Advanced Query Syntax (AQS) device interface selector string for the purpose of retrieving device *interfaces* (rather than devices).</summary>
    /// <returns>An Advanced Query Syntax (AQS) device interface selector string.</returns>
    [MethodImpl]
    public static extern string GetDeviceSelector();

    /// <summary>Asynchronously creates a DisplayMonitor object for the specified device identifier (a string containing a PnP device instance path). See the code example below.</summary>
    /// <param name="deviceId">The monitor device identifier. See DeviceInformation.Id.</param>
    /// <returns>An asynchronous create operation.</returns>
    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<DisplayMonitor> FromIdAsync(
      string deviceId);

    /// <summary>Asynchronously creates a DisplayMonitor object for the specified monitor interface identifier (a string containing a PnP device interface path). See the code example below.</summary>
    /// <param name="deviceInterfaceId">The monitor interface identifier</param>
    /// <returns>An asynchronous create operation.</returns>
    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<DisplayMonitor> FromInterfaceIdAsync(
      string deviceInterfaceId);
  }
}
