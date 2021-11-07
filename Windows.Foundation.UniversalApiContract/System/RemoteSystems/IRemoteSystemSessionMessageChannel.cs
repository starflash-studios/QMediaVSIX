// Decompiled with JetBrains decompiler
// Type: Windows.System.RemoteSystems.IRemoteSystemSessionMessageChannel
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.System.RemoteSystems
{
  [Guid(2502218026, 29657, 19472, 183, 81, 194, 103, 132, 67, 113, 39)]
  [ExclusiveTo(typeof (RemoteSystemSessionMessageChannel))]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  internal interface IRemoteSystemSessionMessageChannel
  {
    RemoteSystemSession Session { get; }

    [RemoteAsync]
    IAsyncOperation<bool> BroadcastValueSetAsync(ValueSet messageData);

    [RemoteAsync]
    IAsyncOperation<bool> SendValueSetAsync(
      ValueSet messageData,
      RemoteSystemSessionParticipant participant);

    [RemoteAsync]
    IAsyncOperation<bool> SendValueSetToParticipantsAsync(
      ValueSet messageData,
      IIterable<RemoteSystemSessionParticipant> participants);

    event TypedEventHandler<RemoteSystemSessionMessageChannel, RemoteSystemSessionValueSetReceivedEventArgs> ValueSetReceived;
  }
}
