// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Perception.KnownPerceptionVideoProfileProperties
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Perception
{
  /// <summary>Provides static properties of a video profile.</summary>
  /// <deprecated type="deprecate">KnownPerceptionVideoProfileProperties may be unavailable after Windows Creator Update.  Please refer to Windows.Media.Capture.Frames APIs on MSDN.</deprecated>
  [MarshalingBehavior(MarshalingType.Agile)]
  [Deprecated("KnownPerceptionVideoProfileProperties may be unavailable after Windows Creator Update.  Please refer to Windows.Media.Capture.Frames APIs on MSDN.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Static(typeof (IKnownPerceptionVideoProfilePropertiesStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  [DualApiPartition(version = 167772160)]
  public static class KnownPerceptionVideoProfileProperties
  {
    /// <summary>Gets a string key used to retrieve an enumeration property indicating the bitmap pixel format.</summary>
    /// <returns>The bitmap pixel format. This property is an enumeration value.</returns>
    public static extern string BitmapPixelFormat { [Deprecated("KnownPerceptionVideoProfileProperties may be unavailable after Windows Creator Update.  Please refer to Windows.Media.Capture.Frames APIs on MSDN.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract"), MethodImpl] get; }

    /// <summary>Gets a string key used to retrieve an enumeration property indicating the bitmap alpha mode.</summary>
    /// <returns>The bitmap alpha mode. This property is an enumeration value.</returns>
    public static extern string BitmapAlphaMode { [Deprecated("KnownPerceptionVideoProfileProperties may be unavailable after Windows Creator Update.  Please refer to Windows.Media.Capture.Frames APIs on MSDN.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract"), MethodImpl] get; }

    /// <summary>Gets a string key used to retrieve a 32-bit unsigned integer property indicating the frame width, in pixels.</summary>
    /// <returns>The frame width, in pixels. This property is a UInt32 value.</returns>
    public static extern string Width { [Deprecated("KnownPerceptionVideoProfileProperties may be unavailable after Windows Creator Update.  Please refer to Windows.Media.Capture.Frames APIs on MSDN.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract"), MethodImpl] get; }

    /// <summary>Gets a string key used to retrieve a 32-bit unsigned integer property indicating the frame height, in pixels.</summary>
    /// <returns>The frame height, in pixels. This property is a UInt32 value.</returns>
    public static extern string Height { [Deprecated("KnownPerceptionVideoProfileProperties may be unavailable after Windows Creator Update.  Please refer to Windows.Media.Capture.Frames APIs on MSDN.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract"), MethodImpl] get; }

    /// <summary>Gets a string key used to retrieve a TimeSpan property indicating the time duration of each frame.</summary>
    /// <returns>The time duration of each frame. This property is a TimeSpan value.</returns>
    public static extern string FrameDuration { [Deprecated("KnownPerceptionVideoProfileProperties may be unavailable after Windows Creator Update.  Please refer to Windows.Media.Capture.Frames APIs on MSDN.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract"), MethodImpl] get; }
  }
}
