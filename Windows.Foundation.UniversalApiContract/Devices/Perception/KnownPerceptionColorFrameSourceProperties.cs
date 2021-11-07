// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Perception.KnownPerceptionColorFrameSourceProperties
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Perception
{
  /// <summary>Provides static properties of color frame sources.</summary>
  /// <deprecated type="deprecate">KnownPerceptionColorFrameSourceProperties may be unavailable after Windows Creator Update.  Please refer to Windows.Media.Capture.Frames APIs on MSDN.</deprecated>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [DualApiPartition(version = 167772160)]
  [Static(typeof (IKnownPerceptionColorFrameSourcePropertiesStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Deprecated("KnownPerceptionColorFrameSourceProperties may be unavailable after Windows Creator Update.  Please refer to Windows.Media.Capture.Frames APIs on MSDN.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  public static class KnownPerceptionColorFrameSourceProperties
  {
    /// <summary>Gets a string key used to retrieve a TimeSpan property indicating the current exposure duration of the camera.</summary>
    /// <returns>The current exposure duration of the camera. This property is a TimeSpan value.</returns>
    public static extern string Exposure { [Deprecated("KnownPerceptionColorFrameSourceProperties may be unavailable after Windows Creator Update.  Please refer to Windows.Media.Capture.Frames APIs on MSDN.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract"), MethodImpl] get; }

    /// <summary>Gets a string key used to retrieve a Boolean property indicating whether or not auto exposure is enabled.</summary>
    /// <returns>Indicates whether or not auto exposure is enabled. This property is a Boolean value.</returns>
    public static extern string AutoExposureEnabled { [Deprecated("KnownPerceptionColorFrameSourceProperties may be unavailable after Windows Creator Update.  Please refer to Windows.Media.Capture.Frames APIs on MSDN.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract"), MethodImpl] get; }

    /// <summary>Gets a string key used to retrieve a single-precision, floating-point property indicating the exposure compensation.</summary>
    /// <returns>The exposure compensation. This property is a Single value.</returns>
    public static extern string ExposureCompensation { [Deprecated("KnownPerceptionColorFrameSourceProperties may be unavailable after Windows Creator Update.  Please refer to Windows.Media.Capture.Frames APIs on MSDN.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract"), MethodImpl] get; }
  }
}
