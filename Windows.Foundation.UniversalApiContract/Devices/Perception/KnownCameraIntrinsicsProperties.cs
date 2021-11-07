// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Perception.KnownCameraIntrinsicsProperties
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Perception
{
  /// <summary>Provides static methods for retrieving intrinsic properties of a camera.</summary>
  /// <deprecated type="deprecate">KnownCameraIntrinsicsProperties may be unavailable after Windows Creator Update.  Please refer to Windows.Media.Capture.Frames APIs on MSDN.</deprecated>
  [Deprecated("KnownCameraIntrinsicsProperties may be unavailable after Windows Creator Update.  Please refer to Windows.Media.Capture.Frames APIs on MSDN.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract")]
  [DualApiPartition(version = 167772160)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Threading(ThreadingModel.Both)]
  [Static(typeof (IKnownCameraIntrinsicsPropertiesStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  public static class KnownCameraIntrinsicsProperties
  {
    /// <summary>Gets a string key used to retrieve an array of single-precision, floating-point property values indicating the focal length of the camera.</summary>
    /// <returns>Indicates the focal length of the camera. This property is a SingleArray value that should be interpreted as a vector.</returns>
    public static extern string FocalLength { [Deprecated("KnownCameraIntrinsicsProperties may be unavailable after Windows Creator Update.  Please refer to Windows.Media.Capture.Frames APIs on MSDN.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract"), MethodImpl] get; }

    /// <summary>Gets a string key used to retrieve an array of single-precision, floating-point property values indicating the principal point, relative to the camera.</summary>
    /// <returns>Indicates the principal point, relative to the camera. This property is a SingleArray value that should be interpreted as a vector.</returns>
    public static extern string PrincipalPoint { [Deprecated("KnownCameraIntrinsicsProperties may be unavailable after Windows Creator Update.  Please refer to Windows.Media.Capture.Frames APIs on MSDN.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract"), MethodImpl] get; }

    /// <summary>Gets a string key used to retrieve an array of single-precision, floating-point property values indicating the radial distortion of the camera.</summary>
    /// <returns>Indicates the radial distortion of the camera. This property is a SingleArray value that should be interpreted as a vector.</returns>
    public static extern string RadialDistortion { [Deprecated("KnownCameraIntrinsicsProperties may be unavailable after Windows Creator Update.  Please refer to Windows.Media.Capture.Frames APIs on MSDN.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract"), MethodImpl] get; }

    /// <summary>Gets a string key used to retrieve an array of single-precision, floating-point property values indicating the tangential distortion of the camera.</summary>
    /// <returns>Indicates the tangential distortion of the camera. This property is a SingleArray value that should be interpreted as a vector.</returns>
    public static extern string TangentialDistortion { [Deprecated("KnownCameraIntrinsicsProperties may be unavailable after Windows Creator Update.  Please refer to Windows.Media.Capture.Frames APIs on MSDN.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract"), MethodImpl] get; }
  }
}
