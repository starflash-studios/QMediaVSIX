// Decompiled with JetBrains decompiler
// Type: Windows.System.RemoteSystems.RemoteSystemSessionController
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.System.RemoteSystems
{
  /// <summary>Handles the creation and management of a new remote session for other devices to join.</summary>
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Activatable(typeof (IRemoteSystemSessionControllerFactory), 262144, "Windows.Foundation.UniversalApiContract")]
  public sealed class RemoteSystemSessionController : IRemoteSystemSessionController
  {
    /// <summary>Initializes a RemoteSystemSessionController with a custom display name.</summary>
    /// <param name="displayName">The public-facing name for this remote session. It should be simple and descriptive.</param>
    [MethodImpl]
    public extern RemoteSystemSessionController(string displayName);

    /// <summary>Initializes a RemoteSystemSessionController with a custom display name and specified options.</summary>
    /// <param name="displayName">The public-facing name for this remote session. It should be simple and descriptive.</param>
    /// <param name="options">The RemoteSystemSessionOptions object specifying additional options for this remote session.</param>
    [MethodImpl]
    public extern RemoteSystemSessionController(
      string displayName,
      RemoteSystemSessionOptions options);

    /// <summary>Raised whenever another device has discovered and requested access to the remote session managed by this RemoteSystemSessionController.</summary>
    public extern event TypedEventHandler<RemoteSystemSessionController, RemoteSystemSessionJoinRequestedEventArgs> JoinRequested;

    /// <summary>Removes a participant from the remote session.</summary>
    /// <param name="pParticipant">A RemoteSystemSessionParticipant object corresponding to the participant being removed.</param>
    /// <returns>An asynchronous operation containing a boolean value: **true** if the removal operation was a success, otherwise **false**.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<bool> RemoveParticipantAsync(
      RemoteSystemSessionParticipant pParticipant);

    /// <summary>Asynchronously attempts to create a remote session.</summary>
    /// <returns>An asynchronous operation with a RemoteSystemSessionCreationResult object describing the result.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<RemoteSystemSessionCreationResult> CreateSessionAsync();
  }
}
