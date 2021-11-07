// Decompiled with JetBrains decompiler
// Type: Windows.Networking.Sockets.WebSocketClosedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Networking.Sockets
{
  /// <summary>Provides data for a closed event on a MessageWebSocket, StreamWebSocket, or IWebSocket object.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [DualApiPartition(version = 100794368)]
  public sealed class WebSocketClosedEventArgs : IWebSocketClosedEventArgs
  {
    /// <summary>Gets information about the reason that a WebSocket object was closed.</summary>
    /// <returns>Status code indicating the reason for closure.</returns>
    public extern ushort Code { [MethodImpl] get; }

    /// <summary>Gets additional details about the reason that a WebSocket object was closed.</summary>
    /// <returns>Detailed information about the closure.</returns>
    public extern string Reason { [MethodImpl] get; }
  }
}
