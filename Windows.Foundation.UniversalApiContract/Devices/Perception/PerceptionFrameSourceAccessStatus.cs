// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Perception.PerceptionFrameSourceAccessStatus
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Perception
{
  /// <summary>Indicates the access status an app is allowed for a particular type of frame source.</summary>
  /// <deprecated type="deprecate">PerceptionFrameSourceAccessStatus may be unavailable after Windows Creator Update.  Please refer to Windows.Media.Capture.Frames APIs on MSDN.</deprecated>
  [Deprecated("PerceptionFrameSourceAccessStatus may be unavailable after Windows Creator Update.  Please refer to Windows.Media.Capture.Frames APIs on MSDN.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum PerceptionFrameSourceAccessStatus
  {
    /// <summary>Access status is not specified.</summary>
    Unspecified,
    /// <summary>The app is allowed to access the type of perception frame source it requested.</summary>
    Allowed,
    /// <summary>The app is not allowed to access the type of perception frame source it requested because the user denied the app access to camera devices.</summary>
    DeniedByUser,
    /// <summary>The app is not allowed to access the type of perception frame source it requested because system access to camera devices is denied. This usually occurs when the user denies all apps access to camera devices in the system privacy settings.</summary>
    DeniedBySystem,
  }
}
