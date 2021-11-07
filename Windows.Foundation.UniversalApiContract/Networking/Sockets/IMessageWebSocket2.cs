// Decompiled with JetBrains decompiler
// Type: Windows.Networking.Sockets.IMessageWebSocket2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Networking.Sockets
{
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [Guid(3201355495, 63944, 17418, 154, 213, 115, 114, 129, 217, 116, 46)]
  [ExclusiveTo(typeof (MessageWebSocket))]
  internal interface IMessageWebSocket2 : IMessageWebSocket, IWebSocket, IClosable
  {
    event TypedEventHandler<MessageWebSocket, WebSocketServerCustomValidationRequestedEventArgs> ServerCustomValidationRequested;
  }
}
