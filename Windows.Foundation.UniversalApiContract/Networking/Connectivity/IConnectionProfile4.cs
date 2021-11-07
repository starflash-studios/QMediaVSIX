// Decompiled with JetBrains decompiler
// Type: Windows.Networking.Connectivity.IConnectionProfile4
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Networking.Connectivity
{
  [ExclusiveTo(typeof (ConnectionProfile))]
  [Guid(2049786573, 33248, 19174, 171, 237, 171, 156, 161, 62, 183, 20)]
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  internal interface IConnectionProfile4
  {
    [RemoteAsync]
    IAsyncOperation<IVectorView<ProviderNetworkUsage>> GetProviderNetworkUsageAsync(
      DateTime startTime,
      DateTime endTime,
      NetworkUsageStates states);
  }
}
