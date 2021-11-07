// Decompiled with JetBrains decompiler
// Type: Windows.Networking.Connectivity.NetworkAdapter
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System;
using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Networking.Connectivity
{
  /// <summary>Represents a network adapter.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [DualApiPartition(version = 100794368)]
  public sealed class NetworkAdapter : INetworkAdapter
  {
    /// <summary>Gets a value indicating the maximum outbound speed in bits per second.</summary>
    /// <returns>The maximum outbound transfer rate in bits per second.</returns>
    public extern ulong OutboundMaxBitsPerSecond { [MethodImpl] get; }

    /// <summary>Gets a value indicating the maximum inbound data transfer rate in bits per second.</summary>
    /// <returns>The maximum inbound transfer rate in bits per second.</returns>
    public extern ulong InboundMaxBitsPerSecond { [MethodImpl] get; }

    /// <summary>Gets a value indicating the network interface type as defined by the Internet Assigned Names Authority (IANA) for the NetworkAdapter.</summary>
    /// <returns>The interface type as defined by the Internet Assigned Names Authority (IANA).</returns>
    public extern uint IanaInterfaceType { [MethodImpl] get; }

    /// <summary>Gets the NetworkItem object that represents the connected network.</summary>
    /// <returns>The connected network.</returns>
    public extern NetworkItem NetworkItem { [MethodImpl] get; }

    /// <summary>Gets the network adapter ID.</summary>
    /// <returns>The network adapter ID.</returns>
    public extern Guid NetworkAdapterId { [MethodImpl] get; }

    /// <summary>Gets the connection profile currently associated with the network adapter.</summary>
    /// <returns>The connection profile associated with this network adapter.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<ConnectionProfile> GetConnectedProfileAsync();
  }
}
