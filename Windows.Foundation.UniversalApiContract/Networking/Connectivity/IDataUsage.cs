// Decompiled with JetBrains decompiler
// Type: Windows.Networking.Connectivity.IDataUsage
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Networking.Connectivity
{
  [ExclusiveTo(typeof (DataUsage))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Deprecated("IDataUsage may be altered or unavailable for releases after Windows 8.1. Instead, use INetworkUsage.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract")]
  [Guid(3242401235, 45382, 19769, 185, 89, 12, 105, 176, 150, 197, 18)]
  internal interface IDataUsage
  {
    ulong BytesSent { [Deprecated("IDataUsage may be altered or unavailable for releases after Windows 8.1. Instead, use INetworkUsage.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract")] get; }

    ulong BytesReceived { [Deprecated("IDataUsage may be altered or unavailable for releases after Windows 8.1. Instead, use INetworkUsage.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract")] get; }
  }
}
