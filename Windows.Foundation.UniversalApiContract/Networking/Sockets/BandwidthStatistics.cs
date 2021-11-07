// Decompiled with JetBrains decompiler
// Type: Windows.Networking.Sockets.BandwidthStatistics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Networking.Sockets
{
  /// <summary>Represents bandwidth information for network data transfer using a StreamSocket, StreamWebSocket, or MessageWebSocket object.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public struct BandwidthStatistics
  {
    /// <summary>The computed outbound bandwidth estimate in bits per second.</summary>
    public ulong OutboundBitsPerSecond;
    /// <summary>The computed inbound bandwidth estimate in bits per second.</summary>
    public ulong InboundBitsPerSecond;
    /// <summary>A measure of the instability of the outbound bandwidth estimate in bits per second.</summary>
    public ulong OutboundBitsPerSecondInstability;
    /// <summary>A measure of the instability of the inbound bandwidth estimate in bits per second.</summary>
    public ulong InboundBitsPerSecondInstability;
    /// <summary>A Boolean value that indicates whether the computed outbound bandwidth estimate for the network path has peaked.</summary>
    public bool OutboundBandwidthPeaked;
    /// <summary>A Boolean value that indicates whether the computed inbound bandwidth estimate for the network has peaked.</summary>
    public bool InboundBandwidthPeaked;
  }
}
