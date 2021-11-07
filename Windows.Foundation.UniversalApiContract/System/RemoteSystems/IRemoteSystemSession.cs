// Decompiled with JetBrains decompiler
// Type: Windows.System.RemoteSystems.IRemoteSystemSession
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.System.RemoteSystems
{
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [Guid(1766287873, 39642, 18703, 149, 73, 211, 28, 177, 76, 158, 149)]
  [ExclusiveTo(typeof (RemoteSystemSession))]
  internal interface IRemoteSystemSession
  {
    string Id { get; }

    string DisplayName { get; }

    string ControllerDisplayName { get; }

    event TypedEventHandler<RemoteSystemSession, RemoteSystemSessionDisconnectedEventArgs> Disconnected;

    RemoteSystemSessionParticipantWatcher CreateParticipantWatcher();

    [RemoteAsync]
    IAsyncOperation<bool> SendInvitationAsync(RemoteSystem invitee);
  }
}
