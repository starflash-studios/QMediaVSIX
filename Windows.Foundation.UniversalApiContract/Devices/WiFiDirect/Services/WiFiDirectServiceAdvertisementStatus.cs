// Decompiled with JetBrains decompiler
// Type: Windows.Devices.WiFiDirect.Services.WiFiDirectServiceAdvertisementStatus
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.WiFiDirect.Services
{
  /// <summary>Values used for WiFiDirectServiceAdvertiser.AdvertisementStatus.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum WiFiDirectServiceAdvertisementStatus
  {
    /// <summary>Advertiser has been created.</summary>
    Created,
    /// <summary>Advertiser has been started.</summary>
    Started,
    /// <summary>Advertiser has been stopped.</summary>
    Stopped,
    /// <summary>Advertiser has been aborted. The advertiser object's ServiceError property has a specific error code describing the reason.</summary>
    Aborted,
  }
}
