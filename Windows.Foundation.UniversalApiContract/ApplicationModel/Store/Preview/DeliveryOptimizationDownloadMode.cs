// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Store.Preview.DeliveryOptimizationDownloadMode
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Store.Preview
{
  /// <summary>Defines values that represent the supported download mode types in the Delivery Optimization settings for the current device. The DownloadMode property returns one of these values.</summary>
  [ContractVersion(typeof (UniversalApiContract), 458752)]
  public enum DeliveryOptimizationDownloadMode
  {
    /// <summary>Delivery Optimization cloud services are disabled.</summary>
    Simple,
    /// <summary>Peer-to-peer caching is disabled but Delivery Optimization can still download content from Windows Update servers or WSUS servers.</summary>
    HttpOnly,
    /// <summary>Peer sharing for Delivery Optimization on the same network is enabled.</summary>
    Lan,
    /// <summary>Group peer sharing for Delivery Optimization is enabled. Peering occurs across internal subnets, between devices that belong to the same group, including devices in remote offices.</summary>
    Group,
    /// <summary>Internet peer sources for Delivery Optimization are enabled.</summary>
    Internet,
    /// <summary>Delivery Optimization is bypassed and BITS is used instead.</summary>
    Bypass,
  }
}
