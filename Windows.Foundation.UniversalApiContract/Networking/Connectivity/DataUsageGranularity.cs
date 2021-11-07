// Decompiled with JetBrains decompiler
// Type: Windows.Networking.Connectivity.DataUsageGranularity
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Networking.Connectivity
{
  /// <summary>Defines levels of granularity used when retrieving data usage statistics with GetNetworkUsageAsync.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum DataUsageGranularity
  {
    /// <summary>Provide data usage per minute.</summary>
    PerMinute,
    /// <summary>Provide data usage per hour.</summary>
    PerHour,
    /// <summary>Provide data usage per day.</summary>
    PerDay,
    /// <summary>Provide data usage overall.</summary>
    Total,
  }
}
