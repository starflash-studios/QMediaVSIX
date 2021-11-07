// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Perception.KnownPerceptionFrameSourceProperties
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Perception
{
  /// <summary>Provides static properties that are applicable to all types of frame sources.</summary>
  /// <deprecated type="deprecate">KnownPerceptionFrameSourceProperties may be unavailable after Windows Creator Update.  Please refer to Windows.Media.Capture.Frames APIs on MSDN.</deprecated>
  [Static(typeof (IKnownPerceptionFrameSourcePropertiesStatics2), 131072, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Static(typeof (IKnownPerceptionFrameSourcePropertiesStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [DualApiPartition(version = 167772160)]
  [Threading(ThreadingModel.Both)]
  [Deprecated("KnownPerceptionFrameSourceProperties may be unavailable after Windows Creator Update.  Please refer to Windows.Media.Capture.Frames APIs on MSDN.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract")]
  public static class KnownPerceptionFrameSourceProperties
  {
    /// <summary>Gets a string value that identifies the device on the system.</summary>
    /// <returns>The identifier.</returns>
    public static extern string DeviceId { [Deprecated("KnownPerceptionFrameSourceProperties may be unavailable after Windows Creator Update.  Please refer to Windows.Media.Capture.Frames APIs on MSDN.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract"), MethodImpl] get; }

    /// <summary>Gets a string key used to look up a string property with the unique ID of the frame source.</summary>
    /// <returns>The unique ID of the frame source. This property is a String value.</returns>
    public static extern string Id { [Deprecated("KnownPerceptionFrameSourceProperties may be unavailable after Windows Creator Update.  Use Windows.Devices.Enumeration.DeviceInformation instead.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract"), MethodImpl] get; }

    /// <summary>Gets a string key used to look up a string array property containing the physical device IDs of the sensor this frame source represents.</summary>
    /// <returns>An array of strings with the physical device IDs of the sensor this frame source represents. This property is a StringArray value.</returns>
    public static extern string PhysicalDeviceIds { [Deprecated("KnownPerceptionFrameSourceProperties may be unavailable after Windows Creator Update.  Use Windows.Devices.Enumeration.DeviceInformation instead.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract"), MethodImpl] get; }

    /// <summary>Gets a string key used to look up a string property that is a string key indicating the kind of frame the source provides.</summary>
    /// <returns>A string key indicating the kind of frame the source provides. This property is a String value. The string key will indicate color, depth, or infrared as specified by Windows.Devices.Perception.KnownPerceptionFrameKindStatics.</returns>
    public static extern string FrameKind { [Deprecated("KnownPerceptionFrameSourceProperties may be unavailable after Windows Creator Update.  Use Windows.Devices.Enumeration.DeviceInformation instead.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract"), MethodImpl] get; }

    /// <summary>Gets a string key used to look up a string property with the device, model, version string for the physical sensor device this frame source represents.</summary>
    /// <returns>The device, model, version string for the physical sensor device this frame source represents. This property is a String value.</returns>
    public static extern string DeviceModelVersion { [Deprecated("KnownPerceptionFrameSourceProperties may be unavailable after Windows Creator Update.  Use Windows.Devices.Enumeration.DeviceInformation instead.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract"), MethodImpl] get; }

    /// <summary>Gets a string key used to look up an enumeration property indicating the physical location of the sensor on the Windows device.</summary>
    /// <returns>The physical location of the sensor on the Windows device. This is an enumeration value.</returns>
    public static extern string EnclosureLocation { [Deprecated("KnownPerceptionFrameSourceProperties may be unavailable after Windows Creator Update.  Use Windows.Devices.Enumeration.DeviceInformation instead.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract"), MethodImpl] get; }
  }
}
