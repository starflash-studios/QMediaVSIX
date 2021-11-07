// Decompiled with JetBrains decompiler
// Type: Windows.Networking.Connectivity.LanIdentifier
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System;
using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Networking.Connectivity
{
  /// <summary>Represents physical identification data for a specific NetworkAdapter object. For a code example showing how to retrieve data represented by a LanIdentifier object, see [How to retrieve network adapter and locality information (XAML)](https://docs.microsoft.com/previous-versions/windows/apps/hh465168(v=win.10)).</summary>
  [DualApiPartition(version = 100794368)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class LanIdentifier : ILanIdentifier
  {
    /// <summary>Gets a LanIdentifierData object containing locality identification information for the network adapter's connection.</summary>
    /// <returns>Location information for the network adapter providing connectivity for the connection.</returns>
    public extern LanIdentifierData InfrastructureId { [MethodImpl] get; }

    /// <summary>Gets a LanIdentifierData object containing the port ID from the Link Layer Discovery Protocol (LLDP) locality information for an Ethernet type network adapter.</summary>
    /// <returns>The port ID information for the network adapter.</returns>
    public extern LanIdentifierData PortId { [MethodImpl] get; }

    /// <summary>Gets the adapter GUID that identifies the network adapter to associate with the locality information.</summary>
    /// <returns>The adapter ID for the network adapter associated with the LanIdentifier information.</returns>
    public extern Guid NetworkAdapterId { [MethodImpl] get; }
  }
}
