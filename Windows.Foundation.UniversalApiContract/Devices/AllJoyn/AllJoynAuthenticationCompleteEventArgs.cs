// Decompiled with JetBrains decompiler
// Type: Windows.Devices.AllJoyn.AllJoynAuthenticationCompleteEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.AllJoyn
{
  /// <summary>Contains information about a successful or unsuccessful completion of an authentication operation.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Deprecated("AllJoynAuthenticationCompleteEventArgs has been deprecated.  For more info, see MSDN.", DeprecationType.Deprecate, 786432, "Windows.Foundation.UniversalApiContract")]
  [DualApiPartition(version = 167772160)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class AllJoynAuthenticationCompleteEventArgs : 
    IAllJoynAuthenticationCompleteEventArgs
  {
    /// <summary>The mechanism used during authentication.</summary>
    /// <returns>The authentication mechanism.</returns>
    public extern AllJoynAuthenticationMechanism AuthenticationMechanism { [Deprecated("AllJoynAuthenticationCompleteEventArgs has been deprecated.  For more info, see MSDN.", DeprecationType.Deprecate, 786432, "Windows.Foundation.UniversalApiContract"), MethodImpl] get; }

    /// <summary>The unique bus name of the Consumer being authenticated. On the initiating side this will be the unique bus name of the remote app being authenticated. On the accepting side this will be the unique bus name for the remote app.</summary>
    /// <returns>The unique bus name.</returns>
    public extern string PeerUniqueName { [Deprecated("AllJoynAuthenticationCompleteEventArgs has been deprecated.  For more info, see MSDN.", DeprecationType.Deprecate, 786432, "Windows.Foundation.UniversalApiContract"), MethodImpl] get; }

    /// <summary>Indicates if the remote app was authenticated.</summary>
    /// <returns>True if the authentication was successful; otherwise, false.</returns>
    public extern bool Succeeded { [Deprecated("AllJoynAuthenticationCompleteEventArgs has been deprecated.  For more info, see MSDN.", DeprecationType.Deprecate, 786432, "Windows.Foundation.UniversalApiContract"), MethodImpl] get; }
  }
}
