// Decompiled with JetBrains decompiler
// Type: Windows.Media.PlayTo.PlayToConnectionError
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.PlayTo
{
  /// <summary>Describes an error on a Play To connection.</summary>
  /// <deprecated type="deprecate">PlayToConnectionError may be altered or unavailable for releases after Windows 10. Instead, use CastingConnectionErrorStatus.</deprecated>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Deprecated("PlayToConnectionError may be altered or unavailable for releases after Windows 10. Instead, use CastingConnectionErrorStatus.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract")]
  public enum PlayToConnectionError
  {
    /// <summary>No error occurred.</summary>
    None,
    /// <summary>The Play To target device has not responded for at least 5 seconds.</summary>
    DeviceNotResponding,
    /// <summary>The Play To target device has encountered an error.</summary>
    DeviceError,
    /// <summary>The Play To target device is locked.</summary>
    DeviceLocked,
    /// <summary>The Play To target device failed to play the protected content.</summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] ProtectedPlaybackFailed,
  }
}
