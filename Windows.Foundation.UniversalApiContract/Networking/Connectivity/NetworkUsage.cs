// Decompiled with JetBrains decompiler
// Type: Windows.Networking.Connectivity.NetworkUsage
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Networking.Connectivity
{
  /// <summary>Represents network usage statistics returned by the ConnectionProfile.GetNetworkUsageAsync method.</summary>
  [DualApiPartition(version = 100859904)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class NetworkUsage : INetworkUsage
  {
    /// <summary>Indicates the number of bytes sent by a connection over a specific period of time.</summary>
    /// <returns>The number of bytes sent.</returns>
    public extern ulong BytesSent { [MethodImpl] get; }

    /// <summary>Indicates the number of bytes received by the connection of a specific period of time.</summary>
    /// <returns>The number of bytes received.</returns>
    public extern ulong BytesReceived { [MethodImpl] get; }

    /// <summary>Indicates the duration of connectivity.</summary>
    /// <returns>The period of time that represents the duration of connectivity.</returns>
    public extern TimeSpan ConnectionDuration { [MethodImpl] get; }
  }
}
