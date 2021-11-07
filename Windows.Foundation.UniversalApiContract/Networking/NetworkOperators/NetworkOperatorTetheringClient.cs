// Decompiled with JetBrains decompiler
// Type: Windows.Networking.NetworkOperators.NetworkOperatorTetheringClient
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Networking.NetworkOperators
{
  /// <summary>Contains details about a tethering client.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [DualApiPartition(version = 167772160)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class NetworkOperatorTetheringClient : INetworkOperatorTetheringClient
  {
    /// <summary>Gets the MAC address of this tethering client.</summary>
    /// <returns>MAC address.</returns>
    public extern string MacAddress { [MethodImpl] get; }

    /// <summary>Gets a list of hostnames used by this tethering client.</summary>
    /// <returns>List of hostnames.</returns>
    public extern IVectorView<HostName> HostNames { [MethodImpl] get; }
  }
}
