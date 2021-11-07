// Decompiled with JetBrains decompiler
// Type: Windows.Networking.Connectivity.IConnectionProfile2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Networking.Connectivity
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(3791933765, 19615, 16396, 145, 80, 126, 199, 214, 226, 136, 138)]
  [ExclusiveTo(typeof (ConnectionProfile))]
  internal interface IConnectionProfile2
  {
    bool IsWwanConnectionProfile { get; }

    bool IsWlanConnectionProfile { get; }

    WwanConnectionProfileDetails WwanConnectionProfileDetails { get; }

    WlanConnectionProfileDetails WlanConnectionProfileDetails { get; }

    IReference<Guid> ServiceProviderGuid { get; }

    IReference<byte> GetSignalBars();

    DomainConnectivityLevel GetDomainConnectivityLevel();

    [RemoteAsync]
    IAsyncOperation<IVectorView<NetworkUsage>> GetNetworkUsageAsync(
      global::Windows.Foundation.DateTime startTime,
      global::Windows.Foundation.DateTime endTime,
      DataUsageGranularity granularity,
      NetworkUsageStates states);

    [RemoteAsync]
    IAsyncOperation<IVectorView<ConnectivityInterval>> GetConnectivityIntervalsAsync(
      global::Windows.Foundation.DateTime startTime,
      global::Windows.Foundation.DateTime endTime,
      NetworkUsageStates states);
  }
}
