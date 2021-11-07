// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Perception.KnownPerceptionInfraredFrameSourceProperties
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Perception
{
  /// <summary>Provides static properties of infrared frame sources.</summary>
  /// <deprecated type="deprecate">KnownPerceptionInfraredFrameSourceProperties may be unavailable after Windows Creator Update.  Please refer to Windows.Media.Capture.Frames APIs on MSDN.</deprecated>
  [DualApiPartition(version = 167772160)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  [Deprecated("KnownPerceptionInfraredFrameSourceProperties may be unavailable after Windows Creator Update.  Please refer to Windows.Media.Capture.Frames APIs on MSDN.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract")]
  [Static(typeof (IKnownPerceptionInfraredFrameSourcePropertiesStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  public static class KnownPerceptionInfraredFrameSourceProperties
  {
    /// <summary>Gets a string key used to retrieve a TimeSpan property indicating the current exposure duration of the camera.</summary>
    /// <returns>The current exposure duration of the camera. This property is a TimeSpan value.</returns>
    public static extern string Exposure { [Deprecated("KnownPerceptionInfraredFrameSourceProperties.Exposure may be unavailable after Windows Creator Update.  Use Windows.Media.Devices.ExposureControl instead.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract"), MethodImpl] get; }

    /// <summary>Gets a string key used to retrieve a Boolean property indicating whether or not auto exposure is enabled.</summary>
    /// <returns>Indicates whether or not auto exposure is enabled. This property is a Boolean value.</returns>
    public static extern string AutoExposureEnabled { [Deprecated("KnownPerceptionInfraredFrameSourceProperties.AutoExposureEnabled may be unavailable after Windows Creator Update.  Use Windows.Media.Devices.ExposureControl.Auto instead.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract"), MethodImpl] get; }

    /// <summary>Gets a string key used to retrieve a single-precision, floating-point property indicating the amount of exposure compensation.</summary>
    /// <returns>Indicates the amount of exposure compensation. This property is a Single value.</returns>
    public static extern string ExposureCompensation { [Deprecated("KnownPerceptionInfraredFrameSourceProperties.ExposureCompensation may be unavailable after Windows Creator Update.  Use Windows.Media.Devices.ExposureCompensationControl instead.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract"), MethodImpl] get; }

    /// <summary>Gets a string key used to retrieve a Boolean property indicating whether or not active IR illumination is enabled.</summary>
    /// <returns>Indicates whether or not active IR illumination is enabled. This property is a Boolean value.</returns>
    public static extern string ActiveIlluminationEnabled { [Deprecated("KnownPerceptionInfraredFrameSourceProperties.ActiveIlluminationEnabled may be unavailable after Windows Creator Update.  Please refer to Windows.Media.Capture.Frames APIs on MSDN.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract"), MethodImpl] get; }

    /// <summary>Gets a string key used to retrieve a Boolean property indicating whether or not ambient IR light subtraction is enabled.</summary>
    /// <returns>Indicates whether or not ambient IR light subtraction is enabled. This property is a Boolean value.</returns>
    public static extern string AmbientSubtractionEnabled { [Deprecated("KnownPerceptionInfraredFrameSourceProperties.AmbientSubtractionEnabled may be unavailable after Windows Creator Update.  Please refer to Windows.Media.Capture.Frames APIs on MSDN.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract"), MethodImpl] get; }

    /// <summary>Gets a string key used to retrieve a Boolean property indicating whether or not the structured light pattern is enabled.</summary>
    /// <returns>Indicates whether or not the structured light pattern is enabled. This property is a Boolean value.</returns>
    public static extern string StructureLightPatternEnabled { [Deprecated("KnownPerceptionInfraredFrameSourceProperties.StructureLightPatternEnabled may be unavailable after Windows Creator Update.  Please refer to Windows.Media.Capture.Frames APIs on MSDN.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract"), MethodImpl] get; }

    /// <summary>Gets a string key used to retrieve a Boolean property indicating whether or not interleaved illumination is enabled.</summary>
    /// <returns>Indicates whether or not interleaved illumination is enabled. This property is a Boolean value.</returns>
    public static extern string InterleavedIlluminationEnabled { [Deprecated("KnownPerceptionInfraredFrameSourceProperties.InterleavedIlluminationEnabled may be unavailable after Windows Creator Update.  Please refer to Windows.Media.Capture.Frames APIs on MSDN.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract"), MethodImpl] get; }
  }
}
