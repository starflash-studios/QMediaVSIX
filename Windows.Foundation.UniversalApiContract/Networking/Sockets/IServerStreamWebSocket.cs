// Decompiled with JetBrains decompiler
// Type: Windows.Networking.Sockets.IServerStreamWebSocket
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Networking.Sockets
{
  [ContractVersion(typeof (UniversalApiContract), 393216)]
  [ExclusiveTo(typeof (ServerStreamWebSocket))]
  [Guid(753753023, 29942, 21988, 121, 223, 145, 50, 104, 13, 254, 232)]
  internal interface IServerStreamWebSocket : IClosable
  {
    ServerStreamWebSocketInformation Information { get; }

    IInputStream InputStream { get; }

    IOutputStream OutputStream { get; }

    event TypedEventHandler<ServerStreamWebSocket, WebSocketClosedEventArgs> Closed;

    [Overload("CloseWithStatus")]
    void Close(ushort code, string reason);
  }
}
