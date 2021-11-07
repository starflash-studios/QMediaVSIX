// Decompiled with JetBrains decompiler
// Type: Windows.Networking.Sockets.MessageWebSocketMessageReceivedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Networking.Sockets
{
  /// <summary>Provides data for a message received event on a MessageWebSocket.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [DualApiPartition(version = 100794368)]
  [GCPressure(amount = GCPressureAmount.Medium)]
  public sealed class MessageWebSocketMessageReceivedEventArgs : 
    IMessageWebSocketMessageReceivedEventArgs,
    IMessageWebSocketMessageReceivedEventArgs2
  {
    /// <summary>Gets the type of the message received by a MessageWebSocket object.</summary>
    /// <returns>The type of the message received.</returns>
    public extern SocketMessageType MessageType { [MethodImpl] get; }

    /// <summary>Gets a DataReader object to read incoming data received from the remote network destination on a MessageWebSocket.</summary>
    /// <returns>A DataReader object to read incoming data received from the remote network destination on a MessageWebSocket.</returns>
    [MethodImpl]
    public extern DataReader GetDataReader();

    /// <summary>Gets an IInputStream object (a message represented as a sequential stream of bytes) from the remote network destination on a MessageWebSocket object.</summary>
    /// <returns>A message represented as a sequential stream of bytes.</returns>
    [MethodImpl]
    public extern IInputStream GetDataStream();

    /// <summary>Allow clients to query if a MessageReceived callback indicates the received message is complete or just a partial message.</summary>
    /// <returns>TRUE if the message is complete. The default value is FALSE.</returns>
    public extern bool IsMessageComplete { [MethodImpl] get; }
  }
}
