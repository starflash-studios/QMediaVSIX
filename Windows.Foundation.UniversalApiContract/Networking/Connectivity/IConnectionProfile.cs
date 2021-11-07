// Decompiled with JetBrains decompiler
// Type: Windows.Networking.Connectivity.IConnectionProfile
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Networking.Connectivity
{
  [Guid(1908020284, 22926, 18896, 132, 235, 143, 235, 174, 220, 193, 149)]
  [ExclusiveTo(typeof (ConnectionProfile))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IConnectionProfile
  {
    string ProfileName { get; }

    NetworkConnectivityLevel GetNetworkConnectivityLevel();

    IVectorView<string> GetNetworkNames();

    ConnectionCost GetConnectionCost();

    DataPlanStatus GetDataPlanStatus();

    NetworkAdapter NetworkAdapter { get; }

    [Overload("GetLocalUsage")]
    [Deprecated("GetLocalUsage may be altered or unavailable for releases after Windows 8.1. Instead, use GetNetworkUsageAsync.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract")]
    DataUsage GetLocalUsage(DateTime StartTime, DateTime EndTime);

    [Overload("GetLocalUsagePerRoamingStates")]
    [Deprecated("GetLocalUsage may be altered or unavailable for releases after Windows 8.1. Instead, use GetNetworkUsageAsync.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract")]
    DataUsage GetLocalUsage(DateTime StartTime, DateTime EndTime, RoamingStates States);

    NetworkSecuritySettings NetworkSecuritySettings { get; }
  }
}
