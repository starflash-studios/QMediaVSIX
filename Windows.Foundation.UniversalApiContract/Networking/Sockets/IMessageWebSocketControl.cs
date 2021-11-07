// Decompiled with JetBrains decompiler
// Type: Windows.Networking.Sockets.IMessageWebSocketControl
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Networking.Sockets
{
  [ExclusiveTo(typeof (MessageWebSocketControl))]
  [Guid(2165848202, 50729, 20234, 128, 251, 129, 252, 5, 83, 136, 98)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IMessageWebSocketControl : IWebSocketControl
  {
    uint MaxMessageSize { get; set; }

    SocketMessageType MessageType { get; set; }
  }
}
