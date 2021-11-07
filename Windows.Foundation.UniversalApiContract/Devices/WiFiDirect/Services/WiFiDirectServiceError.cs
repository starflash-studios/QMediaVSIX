// Decompiled with JetBrains decompiler
// Type: Windows.Devices.WiFiDirect.Services.WiFiDirectServiceError
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.WiFiDirect.Services
{
  /// <summary>Values used for the WiFiDirectServiceAdvertiser.ServiceError property.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum WiFiDirectServiceError
  {
    /// <summary>No error.</summary>
    Success,
    /// <summary>The Wi-Fi Direct radio is not available.</summary>
    RadioNotAvailable,
    /// <summary>A required resource is in use.</summary>
    ResourceInUse,
    /// <summary>The Wi-Fi adapter does not support Wi-Fi Direct.</summary>
    UnsupportedHardware,
    /// <summary>No Wi-Fi adapter is found.</summary>
    NoHardware,
  }
}
