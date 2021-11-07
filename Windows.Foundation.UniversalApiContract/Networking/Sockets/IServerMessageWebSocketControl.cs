// Decompiled with JetBrains decompiler
// Type: Windows.Networking.Sockets.IServerMessageWebSocketControl
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Networking.Sockets
{
  [ExclusiveTo(typeof (ServerMessageWebSocketControl))]
  [Guid(1774383185, 7199, 22650, 69, 25, 33, 129, 97, 1, 146, 183)]
  [ContractVersion(typeof (UniversalApiContract), 393216)]
  internal interface IServerMessageWebSocketControl
  {
    SocketMessageType MessageType { get; set; }
  }
}
