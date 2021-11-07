// Decompiled with JetBrains decompiler
// Type: Windows.Networking.Vpn.VpnPacketBuffer
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Networking.Vpn
{
  /// <summary>Used by the platform to manage a memory buffer. **VpnPacketBuffer** allows buffers to be chained together in a **IVpnPacketBufferList** object list to be sent or received in a specific order.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Threading(ThreadingModel.MTA)]
  [Activatable(typeof (IVpnPacketBufferFactory), 65536, "Windows.Foundation.UniversalApiContract")]
  public sealed class VpnPacketBuffer : IVpnPacketBuffer, IVpnPacketBuffer2, IVpnPacketBuffer3
  {
    /// <summary>Not used.</summary>
    /// <param name="parentBuffer">A pointer to the parent buffer in the chain.</param>
    /// <param name="offset">Offset value.</param>
    /// <param name="length">The size of the buffer.</param>
    [MethodImpl]
    public extern VpnPacketBuffer(VpnPacketBuffer parentBuffer, uint offset, uint length);

    /// <summary>Gets the memory buffer object, designed to contain packets of date to be sent or received as part of a **IVpnPacketBufferList**.</summary>
    /// <returns>The memory buffer object.</returns>
    public extern Buffer Buffer { [MethodImpl] get; }

    /// <summary>Gets the status of **VpnPacketBuffer**. The status property may be used to report errors when manipulating the **IVpnPacketBufferList.**</summary>
    /// <returns>An enum value indicating the status of a **VpnPacketBuffer** object.</returns>
    public extern VpnPacketBufferStatus Status { [MethodImpl] set; [MethodImpl] get; }

    /// <summary>Gets or sets a number specifying which transport object to use as specified in the VpnChannel:Start* methods. This allows the selection between the main and the optional transports.</summary>
    /// <returns>A value of 0 sets this packet to be sent over the main transport. A value of 1 sets this packet to be sent over the optional transport.</returns>
    public extern uint TransportAffinity { [MethodImpl] set; [MethodImpl] get; }

    /// <summary>Gets the app ID representing the app that caused this packet to flow. This is present only on the first packet of a flow. The presence of this property indicates it is the first packet.</summary>
    /// <returns>The app ID representing the app that caused this packet to flow.</returns>
    public extern VpnAppId AppId { [MethodImpl] get; }

    /// <summary>Gets or sets a transport context object, for example the name of a host or server.</summary>
    /// <returns>A transport context object, for example the name of a host or server.</returns>
    public extern object TransportContext { [MethodImpl] set; [MethodImpl] get; }
  }
}
