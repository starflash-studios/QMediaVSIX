// Decompiled with JetBrains decompiler
// Type: Windows.Networking.Sockets.ServerMessageWebSocketControl
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Networking.Sockets
{
  /// <summary>Provides socket control data on a ServerMessageWebSocket.</summary>
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 393216)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class ServerMessageWebSocketControl : IServerMessageWebSocketControl
  {
    /// <summary>Gets and sets the WebSocket message type to be configured on a ServerMessageWebSocket object for write operations.</summary>
    /// <returns>The WebSocket message type. The default is binary.</returns>
    public extern SocketMessageType MessageType { [MethodImpl] get; [MethodImpl] set; }
  }
}
