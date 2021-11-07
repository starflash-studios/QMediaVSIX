// Decompiled with JetBrains decompiler
// Type: Windows.Networking.Sockets.IMessageWebSocketMessageReceivedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Networking.Sockets
{
  [ExclusiveTo(typeof (MessageWebSocketMessageReceivedEventArgs))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(1200366252, 19531, 17133, 158, 215, 30, 249, 249, 79, 163, 213)]
  internal interface IMessageWebSocketMessageReceivedEventArgs
  {
    SocketMessageType MessageType { get; }

    DataReader GetDataReader();

    IInputStream GetDataStream();
  }
}
