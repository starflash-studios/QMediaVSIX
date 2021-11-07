// Decompiled with JetBrains decompiler
// Type: Windows.Networking.Connectivity.NetworkSecuritySettings
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Networking.Connectivity
{
  /// <summary>Represents the current network security settings.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [DualApiPartition(version = 100794368)]
  public sealed class NetworkSecuritySettings : INetworkSecuritySettings
  {
    /// <summary>Retrieves the type of authentication used by the network.</summary>
    /// <returns>The network authentication type.</returns>
    public extern NetworkAuthenticationType NetworkAuthenticationType { [MethodImpl] get; }

    /// <summary>Retrieves the type of encryption used by the network.</summary>
    /// <returns>The network encryption type.</returns>
    public extern NetworkEncryptionType NetworkEncryptionType { [MethodImpl] get; }
  }
}
