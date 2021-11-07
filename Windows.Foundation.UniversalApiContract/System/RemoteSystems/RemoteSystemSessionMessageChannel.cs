// Decompiled with JetBrains decompiler
// Type: Windows.System.RemoteSystems.RemoteSystemSessionMessageChannel
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.System.RemoteSystems
{
  /// <summary>Handles a dedicated data transfer channel within a remote session. This class owns the functionality for both sending and receiving.</summary>
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [Threading(ThreadingModel.Both)]
  [Activatable(typeof (IRemoteSystemSessionMessageChannelFactory), 262144, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class RemoteSystemSessionMessageChannel : IRemoteSystemSessionMessageChannel
  {
    /// <summary>Initializes an instance of RemoteSystemSessionMessageChannel to manage messaging for a given remote session</summary>
    /// <param name="session">The RemoteSystemSession to which this messaging channel will correspond.</param>
    /// <param name="channelName">The user-defined name of the messaging channel. It should be simple and descriptive, such as "Bob's 3D App session."</param>
    [MethodImpl]
    public extern RemoteSystemSessionMessageChannel(RemoteSystemSession session, string channelName);

    /// <summary>Initializes an instance of RemoteSystemSessionMessageChannel to manage messaging for a given remote session, specifying the reliability type of the channel.</summary>
    /// <param name="session">The RemoteSystemSession to which this messaging channel will correspond.</param>
    /// <param name="channelName">The user-defined name of the messaging channel. It should be simple and descriptive, such as "Bob's 3D App messaging channel."</param>
    /// <param name="reliability">A RemoteSystemSessionMessageChannelReliability value describing the reliability type of this channel.</param>
    [MethodImpl]
    public extern RemoteSystemSessionMessageChannel(
      RemoteSystemSession session,
      string channelName,
      RemoteSystemSessionMessageChannelReliability reliability);

    /// <summary>Gets the remote session to which this messaging channel corresponds.</summary>
    /// <returns>A RemoteSystemSession object representing the remote session.</returns>
    public extern RemoteSystemSession Session { [MethodImpl] get; }

    /// <summary>Sends a message to all other participants in this remote session messaging channel.</summary>
    /// <param name="messageData">A ValueSet object containing the data to be sent to all participants in the channel.</param>
    /// <returns>An asynchronous operation containing a boolean value: **true** if the send operation was a success, otherwise **false**.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<bool> BroadcastValueSetAsync(ValueSet messageData);

    /// <summary>Sends a message to a participant in this remote session messaging channel.</summary>
    /// <param name="messageData">A ValueSet object containing the data to be sent to the specified participant.</param>
    /// <param name="participant">A RemoteSystemSessionParticipant object corresponding to the participant to which the message should be sent.</param>
    /// <returns>An asynchronous operation containing a boolean value: **true** if the send operation was a success, otherwise **false**.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<bool> SendValueSetAsync(
      ValueSet messageData,
      RemoteSystemSessionParticipant participant);

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<bool> SendValueSetToParticipantsAsync(
      ValueSet messageData,
      IIterable<RemoteSystemSessionParticipant> participants);

    /// <summary>Raised when a message (in the form of a key-value pair) is received by the channel. The contents of the message are contained by the RemoteSystemSessionValueSetReceivedEventArgs object that is passed in.</summary>
    public extern event TypedEventHandler<RemoteSystemSessionMessageChannel, RemoteSystemSessionValueSetReceivedEventArgs> ValueSetReceived;
  }
}
