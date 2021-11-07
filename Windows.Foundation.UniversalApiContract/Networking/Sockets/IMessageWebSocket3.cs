// Decompiled with JetBrains decompiler
// Type: Windows.Networking.Sockets.IMessageWebSocket3
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Networking.Sockets
{
  [Guid(1507450619, 29103, 17225, 132, 135, 145, 31, 207, 104, 21, 151)]
  [ExclusiveTo(typeof (MessageWebSocket))]
  [ContractVersion(typeof (UniversalApiContract), 393216)]
  internal interface IMessageWebSocket3
  {
    [RemoteAsync]
    IAsyncOperationWithProgress<uint, uint> SendNonfinalFrameAsync(
      IBuffer data);

    [RemoteAsync]
    IAsyncOperationWithProgress<uint, uint> SendFinalFrameAsync(
      IBuffer data);
  }
}
