// Decompiled with JetBrains decompiler
// Type: Windows.Networking.Sockets.ServerStreamWebSocketInformation
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Networking.Sockets
{
  /// <summary>Provides socket information on a ServerStreamWebSocket object.</summary>
  [ContractVersion(typeof (UniversalApiContract), 393216)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  public sealed class ServerStreamWebSocketInformation : IServerStreamWebSocketInformation
  {
    /// <summary>Gets bandwidth information for network data transfer on a ServerStreamWebSocket object.</summary>
    /// <returns>Bandwidth information for network data transfer on a ServerStreamWebSocket object.</returns>
    public extern BandwidthStatistics BandwidthStatistics { [MethodImpl] get; }

    /// <summary>Gets the WebSocket sub-protocol negotiated with the server during WebSocket handshake on a ServerStreamWebSocket object.</summary>
    /// <returns>The sub-protocol negotiated with the server during WebSocket handshake.</returns>
    public extern string Protocol { [MethodImpl] get; }

    /// <summary>Gets the IP address associated with a ServerStreamWebSocket object.</summary>
    /// <returns>The IP address associated with a ServerStreamWebSocket object.</returns>
    public extern HostName LocalAddress { [MethodImpl] get; }
  }
}
