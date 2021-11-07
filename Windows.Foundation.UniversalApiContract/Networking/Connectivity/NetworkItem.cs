// Decompiled with JetBrains decompiler
// Type: Windows.Networking.Connectivity.NetworkItem
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System;
using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Networking.Connectivity
{
  /// <summary>Represents a connected network.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [DualApiPartition(version = 100794368)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class NetworkItem : INetworkItem
  {
    /// <summary>Gets the network ID.</summary>
    /// <returns>The network ID.</returns>
    public extern Guid NetworkId { [MethodImpl] get; }

    /// <summary>Gets a NetworkTypes value indicating the network type for a NetworkItem.</summary>
    /// <returns>The type of a network.</returns>
    [MethodImpl]
    public extern NetworkTypes GetNetworkTypes();
  }
}
