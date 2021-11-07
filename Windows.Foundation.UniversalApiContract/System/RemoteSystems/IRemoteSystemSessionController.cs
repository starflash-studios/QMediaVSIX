// Decompiled with JetBrains decompiler
// Type: Windows.System.RemoteSystems.IRemoteSystemSessionController
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.System.RemoteSystems
{
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [ExclusiveTo(typeof (RemoteSystemSessionController))]
  [Guid(3834326482, 26656, 18535, 180, 37, 216, 156, 10, 62, 247, 186)]
  internal interface IRemoteSystemSessionController
  {
    event TypedEventHandler<RemoteSystemSessionController, RemoteSystemSessionJoinRequestedEventArgs> JoinRequested;

    [RemoteAsync]
    IAsyncOperation<bool> RemoveParticipantAsync(
      RemoteSystemSessionParticipant pParticipant);

    [RemoteAsync]
    IAsyncOperation<RemoteSystemSessionCreationResult> CreateSessionAsync();
  }
}
