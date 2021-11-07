// Decompiled with JetBrains decompiler
// Type: Windows.System.RemoteSystems.RemoteSystemConnectionRequest
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.System.RemoteSystems
{
  /// <summary>Represents an intent to communicate with a specific remote system (device).</summary>
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [Activatable(typeof (IRemoteSystemConnectionRequestFactory), 196608, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Static(typeof (IRemoteSystemConnectionRequestStatics2), 524288, "Windows.Foundation.UniversalApiContract")]
  [Static(typeof (IRemoteSystemConnectionRequestStatics), 458752, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  public sealed class RemoteSystemConnectionRequest : 
    IRemoteSystemConnectionRequest,
    IRemoteSystemConnectionRequest2,
    IRemoteSystemConnectionRequest3
  {
    /// <summary>Initializes an instance of the RemoteSystemConnectionRequest class.</summary>
    /// <param name="remoteSystem">The underlying remote system (device) for the resulting RemoteSystemConnectionRequest.</param>
    [MethodImpl]
    public extern RemoteSystemConnectionRequest(RemoteSystem remoteSystem);

    /// <summary>Represents the remote system (device) that the app intends to communicate with.</summary>
    /// <returns>The remote system to communicate with.</returns>
    public extern RemoteSystem RemoteSystem { [MethodImpl] get; }

    /// <summary>Represents the remote application that the app intends to communicate with.</summary>
    /// <returns>The remote application to communicate with.</returns>
    public extern RemoteSystemApp RemoteSystemApp { [MethodImpl] get; }

    /// <summary>Gets a token that persists connection info of a RemoteSystemConnectionRequest so that it can be connected back to later.</summary>
    /// <returns>A string of the ConnectionToken.</returns>
    public extern string ConnectionToken { [MethodImpl] get; }

    /// <summary>Returns a RemoteSystemConnectionRequest based on a ConnectionToken.</summary>
    /// <param name="connectionToken">The specific connection token for which the RemoteSystemConnectionRequest will be created with.</param>
    /// <returns>An instance of the RemoteSystemConnectionRequest class.</returns>
    [MethodImpl]
    public static extern RemoteSystemConnectionRequest CreateFromConnectionToken(
      string connectionToken);

    /// <summary>Returns a RemoteSystemConnectionRequest based on a ConnectionToken and a specific user.</summary>
    /// <param name="user">The specific User for which the RemoteSystemConnectionRequest will be created for.</param>
    /// <param name="connectionToken">The specific connection token for which the RemoteSystemConnectionRequest will be created with.</param>
    /// <returns>An instance of the RemoteSystemConnectionRequest class.</returns>
    [MethodImpl]
    public static extern RemoteSystemConnectionRequest CreateFromConnectionTokenForUser(
      User user,
      string connectionToken);

    /// <summary>Initializes a new instance of the RemoteSystemConnectionRequest class for a particular application on a remote system.</summary>
    /// <param name="remoteSystemApp">The underlying remote application to attempt to connect to.</param>
    /// <returns>An instance of the RemoteSystemConnectionRequest class.</returns>
    [MethodImpl]
    public static extern RemoteSystemConnectionRequest CreateForApp(
      RemoteSystemApp remoteSystemApp);
  }
}
