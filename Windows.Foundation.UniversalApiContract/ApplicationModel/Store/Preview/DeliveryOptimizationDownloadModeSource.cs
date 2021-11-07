// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Store.Preview.DeliveryOptimizationDownloadModeSource
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Store.Preview
{
  /// <summary>Defines values that represent the supported download mode sources in the Delivery Optimization settings for the current device. The DownloadModeSource property returns one of these values.</summary>
  [ContractVersion(typeof (UniversalApiContract), 458752)]
  public enum DeliveryOptimizationDownloadModeSource
  {
    /// <summary>The download mode is based on default values.</summary>
    Default,
    /// <summary>The download mode is configured by policy (Group Policy or an MDM solution).</summary>
    Policy,
  }
}
