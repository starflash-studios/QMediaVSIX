// Decompiled with JetBrains decompiler
// Type: Windows.System.Diagnostics.DevicePortal.DevicePortalConnectionClosedReason
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.System.Diagnostics.DevicePortal
{
  /// <summary>Contains values that explain why a device portal connection was closed.</summary>
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  public enum DevicePortalConnectionClosedReason
  {
    /// <summary>The connection closed for an unknown reason.</summary>
    Unknown,
    /// <summary>Windows Devices Portal closed the connection because the resource limit was exceeded.</summary>
    ResourceLimitsExceeded,
    /// <summary>The connection closed because of an unrecognized app service message.</summary>
    ProtocolError,
    /// <summary>The app is missing the appropriate capability to use a device portal.</summary>
    NotAuthorized,
    /// <summary>The WTS active console user was missing.</summary>
    UserNotPresent,
    /// <summary>Windows Device Portal has shut down.</summary>
    ServiceTerminated,
  }
}
