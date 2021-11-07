// Decompiled with JetBrains decompiler
// Type: Windows.Networking.Connectivity.IPInformation
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Networking.Connectivity
{
  /// <summary>Represents the association between an IP address and an adapter on the network.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [DualApiPartition(version = 100794368)]
  public sealed class IPInformation : IIPInformation
  {
    /// <summary>Retrieves the network adapter associated with the IP address.</summary>
    /// <returns>The associated network adapter.</returns>
    public extern NetworkAdapter NetworkAdapter { [MethodImpl] get; }

    /// <summary>Retrieves the length of the prefix, or network part of the IP address.</summary>
    /// <returns>The length, in bits, of the prefix or network part.</returns>
    public extern IReference<byte> PrefixLength { [MethodImpl] get; }
  }
}
