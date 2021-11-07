// Decompiled with JetBrains decompiler
// Type: Windows.Networking.Sockets.DatagramSocketControl
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Networking.Sockets
{
  /// <summary>Provides socket control data on a DatagramSocket object.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [DualApiPartition(version = 100794368)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class DatagramSocketControl : 
    IDatagramSocketControl,
    IDatagramSocketControl2,
    IDatagramSocketControl3
  {
    /// <summary>Gets or sets the quality of service on a DatagramSocket object.</summary>
    /// <returns>The quality of service on a DatagramSocket object. The default is **normal**.</returns>
    public extern SocketQualityOfService QualityOfService { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the hop limit on an outbound packet sent to a unicast IP address by the DatagramSocket object.</summary>
    /// <returns>The hop limit on an outbound packet sent by the DatagramSocket object. The default is 128.</returns>
    public extern byte OutboundUnicastHopLimit { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the size, in bytes, of the buffer used for receiving data on the DatagramSocket object.</summary>
    /// <returns>The size, in bytes, of the buffer used for receiving data on the DatagramSocket object.</returns>
    public extern uint InboundBufferSizeInBytes { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a Boolean value that specifies whether the DatagramSocket allows IP datagrams for UDP to be fragmented.</summary>
    /// <returns>Whether the DatagramSocket allows datagrams to be fragmented.</returns>
    public extern bool DontFragment { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a Boolean value that specifies whether the DatagramSocket is able to coexist with other Win32 or WinRT multicast sockets bound to the same address/port.</summary>
    /// <returns>Setting this property to **true** enables the DatagramSocket instance to share its local port with any Win32 sockets that are bound using **SO_REUSEADDR/SO_REUSE_MULTICASTPORT**, and with any other **DatagramSocket** instances that have **MulticastOnly** set to true.</returns>
    public extern bool MulticastOnly { [MethodImpl] get; [MethodImpl] set; }
  }
}
