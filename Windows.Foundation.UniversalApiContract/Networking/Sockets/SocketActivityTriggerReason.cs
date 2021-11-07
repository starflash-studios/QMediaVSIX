// Decompiled with JetBrains decompiler
// Type: Windows.Networking.Sockets.SocketActivityTriggerReason
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Networking.Sockets
{
  /// <summary>The reason why a SocketActivityTrigger occurred.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum SocketActivityTriggerReason
  {
    /// <summary>No reason why a  occurred is available.</summary>
    None,
    /// <summary>A packet was received by the socket brokering service for a StreamSocket or DatagramSocket.</summary>
    SocketActivity,
    /// <summary>A connection was accepted by the socket brokering service for a StreamSocketListener.</summary>
    ConnectionAccepted,
    /// <summary>The keep-alive timer expired on a StreamSocket.</summary>
    KeepAliveTimerExpired,
    /// <summary>A StreamSocket was closed.</summary>
    SocketClosed,
  }
}
