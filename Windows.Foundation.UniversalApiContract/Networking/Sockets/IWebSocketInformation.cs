// Decompiled with JetBrains decompiler
// Type: Windows.Networking.Sockets.IWebSocketInformation
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Networking.Sockets
{
  /// <summary>Provides socket information on an IWebSocket object.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(1577181974, 51498, 18341, 178, 95, 7, 132, 118, 57, 209, 129)]
  public interface IWebSocketInformation
  {
    /// <summary>Gets the IP address associated with an IWebSocket object.</summary>
    /// <returns>The IP address associated with an IWebSocket object.</returns>
    HostName LocalAddress { get; }

    /// <summary>Gets bandwidth information for network data transfer on an IWebSocket object.</summary>
    /// <returns>Bandwidth information for network data transfer on an IWebSocket object.</returns>
    BandwidthStatistics BandwidthStatistics { get; }

    /// <summary>Gets the WebSocket sub-protocol negotiated with the server during WebSocket handshake on a IWebSocket object.</summary>
    /// <returns>The sub-protocol negotiated with the server during WebSocket handshake.</returns>
    string Protocol { get; }
  }
}
