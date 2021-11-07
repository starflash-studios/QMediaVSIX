// Decompiled with JetBrains decompiler
// Type: Windows.System.RemoteSystems.RemoteSystemSession
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.System.RemoteSystems
{
  /// <summary>Represents and handles a remote session that can be shared between two or more connected devices. See Remarks for information on this feature.</summary>
  [Static(typeof (IRemoteSystemSessionStatics), 262144, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  public sealed class RemoteSystemSession : IRemoteSystemSession, IClosable
  {
    /// <summary>Gets the unique identifier for this remote session.</summary>
    /// <returns>An id string unique to this session.</returns>
    public extern string Id { [MethodImpl] get; }

    /// <summary>Gets the public-facing name for this remote session, given by the controller of the session.</summary>
    /// <returns>The display name for this session.</returns>
    public extern string DisplayName { [MethodImpl] get; }

    /// <summary>Gets the machine name of the device that is the controller of this remote session.</summary>
    /// <returns>The machine name of the controller device.</returns>
    public extern string ControllerDisplayName { [MethodImpl] get; }

    /// <summary>Raised when this device has been disconnected from this remote session.</summary>
    public extern event TypedEventHandler<RemoteSystemSession, RemoteSystemSessionDisconnectedEventArgs> Disconnected;

    /// <summary>Initializes a RemoteSystemSessionParticipantWatcher to monitor the participants of this remote session.</summary>
    /// <returns>A RemoteSystemSessionParticipantWatcher for this session.</returns>
    [MethodImpl]
    public extern RemoteSystemSessionParticipantWatcher CreateParticipantWatcher();

    /// <summary>Invites a given remote device to join this remote session.</summary>
    /// <param name="invitee">The RemoteSystem object representing the system to which this invitation is being sent.</param>
    /// <returns>An asynchronous operation with a boolean value: **true** if the invitation was sent successfully, otherwise **false**.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<bool> SendInvitationAsync(RemoteSystem invitee);

    [MethodImpl]
    public extern void Close();

    /// <summary>Initializes and returns a RemoteSystemSessionWatcher object to monitor the presence of remote sessions.</summary>
    /// <returns>A watcher object to be used in discovering remote sessions.</returns>
    [MethodImpl]
    public static extern RemoteSystemSessionWatcher CreateWatcher();
  }
}
