// Decompiled with JetBrains decompiler
// Type: Windows.Networking.Vpn.VpnPacketBufferList
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Networking.Vpn
{
  /// <summary>Used to manage **VpnPacketBuffer** objects.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.MTA)]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class VpnPacketBufferList : IVpnPacketBufferList, IIterable<VpnPacketBuffer>
  {
    /// <summary>Add a new **IVpnPacketBuffer** object to the end of the **IVpnPacketBufferList**.</summary>
    /// <param name="nextVpnPacketBuffer">The new **IVpnPacketBuffer** object to add to the **IVpnPacketBufferList** object.</param>
    [MethodImpl]
    public extern void Append(VpnPacketBuffer nextVpnPacketBuffer);

    /// <summary>Add a new **IVpnPacketBuffer** object to the start of the **IVpnPacketBufferList**.</summary>
    /// <param name="nextVpnPacketBuffer">The new **IVpnPacketBuffer** object to add to the **IVpnPacketBufferList** object.</param>
    [MethodImpl]
    public extern void AddAtBegin(VpnPacketBuffer nextVpnPacketBuffer);

    /// <summary>Remove the **IVpnPacketBuffer** object at the end of the **IVpnPacketBufferList**.</summary>
    /// <returns>The **IVpnPacketBuffer** object which was at the end of the **IVpnPacketBufferList**.</returns>
    [MethodImpl]
    public extern VpnPacketBuffer RemoveAtEnd();

    /// <summary>Remove the **IVpnPacketBuffer** object at the start of the **IVpnPacketBufferList**.</summary>
    /// <returns>The **IVpnPacketBuffer** object which was at the start of the **IVpnPacketBufferList**.</returns>
    [MethodImpl]
    public extern VpnPacketBuffer RemoveAtBegin();

    /// <summary>Removes all the **IVpnPacketBuffer** objects from a **IVpnPacketBufferList**.</summary>
    [MethodImpl]
    public extern void Clear();

    /// <summary>Gets the status of **VpnPacketBuffer**. The status property may be used to report errors when manipulating the **IVpnPacketBufferList.**</summary>
    /// <returns>An enum value indicating the status of a **VpnPacketBuffer** object. The default value is 0, indicating there are no errors.</returns>
    public extern VpnPacketBufferStatus Status { [MethodImpl] set; [MethodImpl] get; }

    /// <summary>Gets the number of **IVpnPacketBuffer** objects in the **IVpnPacketBufferList** object.</summary>
    /// <returns>Number of **IVpnPacketBuffer** objects.</returns>
    public extern uint Size { [MethodImpl] get; }

    [MethodImpl]
    public extern IIterator<VpnPacketBuffer> First();
  }
}
