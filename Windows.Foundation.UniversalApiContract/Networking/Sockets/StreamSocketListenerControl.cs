// Decompiled with JetBrains decompiler
// Type: Windows.Networking.Sockets.StreamSocketListenerControl
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Networking.Sockets
{
  /// <summary>Provides socket control data on a StreamSocketListener object.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [DualApiPartition(version = 100794368)]
  public sealed class StreamSocketListenerControl : 
    IStreamSocketListenerControl,
    IStreamSocketListenerControl2
  {
    /// <summary>The quality of service to be set on a StreamSocket object created when a connection is received by the StreamSocketListener object.</summary>
    /// <returns>The quality of service set on a StreamSocket object created when a connection is received by the StreamSocketListener object.</returns>
    public extern SocketQualityOfService QualityOfService { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>A value that indicates whether the Nagle algorithm is used on a StreamSocket object created when a connection is received by the StreamSocketListener object.</summary>
    /// <returns>A value that indicates whether the Nagle algorithm is used on the TCP connection of a StreamSocket object created.</returns>
    public extern bool NoDelay { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>A value that indicates whether keep-alive packets should be sent on a StreamSocket object created when a connection is received by the StreamSocketListener object.</summary>
    /// <returns>Whether keep-alive packets are sent on the StreamSocket object created.</returns>
    public extern bool KeepAlive { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>The size, in bytes, of the send buffer to be used for sending data on a StreamSocket object created when a connection is received by the StreamSocketListener object.</summary>
    /// <returns>The size, in bytes, of the send buffer to be used for sending data on the StreamSocket object created.</returns>
    public extern uint OutboundBufferSizeInBytes { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>The hop limit on an outbound packet sent to a unicast IP address by the StreamSocket object created when a connection is received by the StreamSocketListener object.</summary>
    /// <returns>The hop limit on an outbound packet sent by the StreamSocket object created. The default is 128.</returns>
    public extern byte OutboundUnicastHopLimit { [MethodImpl] get; [MethodImpl] set; }
  }
}
