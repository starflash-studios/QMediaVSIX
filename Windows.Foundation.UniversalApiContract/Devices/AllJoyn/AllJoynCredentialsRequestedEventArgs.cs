// Decompiled with JetBrains decompiler
// Type: Windows.Devices.AllJoyn.AllJoynCredentialsRequestedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.AllJoyn
{
  /// <summary>Contains information about a request for credentials in order to authenticate to a peer.</summary>
  [DualApiPartition(version = 167772160)]
  [Deprecated("AllJoynCredentialsRequestedEventArgs has been deprecated.  For more info, see MSDN.", DeprecationType.Deprecate, 786432, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class AllJoynCredentialsRequestedEventArgs : IAllJoynCredentialsRequestedEventArgs
  {
    /// <summary>The number of times the credential request has been tried.</summary>
    /// <returns>The number of retries.</returns>
    public extern ushort AttemptCount { [Deprecated("AllJoynCredentialsRequestedEventArgs has been deprecated.  For more info, see MSDN.", DeprecationType.Deprecate, 786432, "Windows.Foundation.UniversalApiContract"), MethodImpl] get; }

    /// <summary>The authentication credentials to be filled in by the app.</summary>
    /// <returns>Object containing certificate and logon credentials.</returns>
    public extern AllJoynCredentials Credentials { [Deprecated("AllJoynCredentialsRequestedEventArgs has been deprecated.  For more info, see MSDN.", DeprecationType.Deprecate, 786432, "Windows.Foundation.UniversalApiContract"), MethodImpl] get; }

    /// <summary>The unique bus name of the remote app that provided the requested credentials.</summary>
    /// <returns>The unique bus name.</returns>
    public extern string PeerUniqueName { [Deprecated("AllJoynCredentialsRequestedEventArgs has been deprecated.  For more info, see MSDN.", DeprecationType.Deprecate, 786432, "Windows.Foundation.UniversalApiContract"), MethodImpl] get; }

    /// <summary>A user name value used by mechanisms that accept a user name/password pair.</summary>
    /// <returns>The user name.</returns>
    public extern string RequestedUserName { [Deprecated("AllJoynCredentialsRequestedEventArgs has been deprecated.  For more info, see MSDN.", DeprecationType.Deprecate, 786432, "Windows.Foundation.UniversalApiContract"), MethodImpl] get; }

    /// <summary>Allows JavaScript UWP app to handle the verification of provided of credentials asynchronously.</summary>
    /// <returns>The credential request deferral.</returns>
    [Deprecated("AllJoynCredentialsRequestedEventArgs has been deprecated.  For more info, see MSDN.", DeprecationType.Deprecate, 786432, "Windows.Foundation.UniversalApiContract")]
    [MethodImpl]
    public extern Deferral GetDeferral();
  }
}
