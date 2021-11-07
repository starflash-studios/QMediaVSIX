// Decompiled with JetBrains decompiler
// Type: Windows.System.RemoteSystems.RemoteSystemSessionInfo
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.System.RemoteSystems
{
  /// <summary>Contains identifying information about a remote session.</summary>
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class RemoteSystemSessionInfo : IRemoteSystemSessionInfo
  {
    /// <summary>Gets the public-facing name for the remote session, given by the controller of the session.</summary>
    /// <returns>The display name for the session.</returns>
    public extern string DisplayName { [MethodImpl] get; }

    /// <summary>Gets the machine name of the device that is the controller of the remote session.</summary>
    /// <returns>The machine name of the controller device.</returns>
    public extern string ControllerDisplayName { [MethodImpl] get; }

    /// <summary>Issues a request from the calling device to join the given remote session.</summary>
    /// <returns>An asynchronous operation with the result of this join request. This also returns a value if the connection to the device controlling the session is lost.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<RemoteSystemSessionJoinResult> JoinAsync();
  }
}
