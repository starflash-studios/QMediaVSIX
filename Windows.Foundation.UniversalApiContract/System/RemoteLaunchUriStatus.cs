// Decompiled with JetBrains decompiler
// Type: Windows.System.RemoteLaunchUriStatus
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.System
{
  /// <summary>Specifies the result of activating an application for a URI on a remote device.</summary>
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  public enum RemoteLaunchUriStatus
  {
    /// <summary>The URI could not be successfully launched on the remote system.</summary>
    Unknown,
    /// <summary>The URI was successfully launched on the remote system.</summary>
    Success,
    /// <summary>The app is not installed on the remote system.</summary>
    AppUnavailable,
    /// <summary>The application you are trying to activate on the remote system does not support this URI.</summary>
    ProtocolUnavailable,
    /// <summary>The remote system could not be reached.</summary>
    RemoteSystemUnavailable,
    /// <summary>The amount of data you tried to send to the remote system exceeded the limit.</summary>
    ValueSetTooLarge,
    /// <summary>The user is not authorized to launch an app on the remote system.</summary>
    DeniedByLocalSystem,
    /// <summary>The user is not signed in on the target device or may be blocked by group policy.</summary>
    DeniedByRemoteSystem,
  }
}
