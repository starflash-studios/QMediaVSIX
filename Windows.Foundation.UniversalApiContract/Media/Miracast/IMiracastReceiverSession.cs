// Decompiled with JetBrains decompiler
// Type: Windows.Media.Miracast.IMiracastReceiverSession
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Miracast
{
  [ExclusiveTo(typeof (MiracastReceiverSession))]
  [ContractVersion(typeof (UniversalApiContract), 524288)]
  [Guid(489409972, 61323, 21001, 191, 201, 195, 33, 22, 80, 72, 3)]
  internal interface IMiracastReceiverSession
  {
    event TypedEventHandler<MiracastReceiverSession, MiracastReceiverConnectionCreatedEventArgs> ConnectionCreated;

    event TypedEventHandler<MiracastReceiverSession, MiracastReceiverMediaSourceCreatedEventArgs> MediaSourceCreated;

    event TypedEventHandler<MiracastReceiverSession, MiracastReceiverDisconnectedEventArgs> Disconnected;

    bool AllowConnectionTakeover { get; set; }

    int MaxSimultaneousConnections { get; set; }

    MiracastReceiverSessionStartResult Start();

    [RemoteAsync]
    IAsyncOperation<MiracastReceiverSessionStartResult> StartAsync();
  }
}
