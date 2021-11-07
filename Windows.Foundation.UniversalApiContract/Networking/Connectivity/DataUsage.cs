// Decompiled with JetBrains decompiler
// Type: Windows.Networking.Connectivity.DataUsage
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Networking.Connectivity
{
  /// <summary>Represents data usage information returned by the ConnectionProfile.GetLocalUsage method.</summary>
  /// <deprecated type="deprecate">DataUsage may be altered or unavailable for releases after Windows 8.1. Instead, use NetworkUsage.</deprecated>
  [DualApiPartition(version = 100794368)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Deprecated("DataUsage may be altered or unavailable for releases after Windows 8.1. Instead, use NetworkUsage.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract")]
  public sealed class DataUsage : IDataUsage
  {
    /// <summary>Gets a value indicating the number of bytes sent by the connection over a specific period of time.</summary>
    /// <returns>The number of bytes sent.</returns>
    public extern ulong BytesSent { [Deprecated("IDataUsage may be altered or unavailable for releases after Windows 8.1. Instead, use INetworkUsage.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract"), MethodImpl] get; }

    /// <summary>Gets a value indicating the number of bytes received by a connection over a specific period of time.</summary>
    /// <returns>The number of bytes received.</returns>
    public extern ulong BytesReceived { [Deprecated("IDataUsage may be altered or unavailable for releases after Windows 8.1. Instead, use INetworkUsage.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract"), MethodImpl] get; }
  }
}
