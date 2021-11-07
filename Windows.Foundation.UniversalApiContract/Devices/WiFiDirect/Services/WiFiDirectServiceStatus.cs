// Decompiled with JetBrains decompiler
// Type: Windows.Devices.WiFiDirect.Services.WiFiDirectServiceStatus
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.WiFiDirect.Services
{
  /// <summary>Values used to describe the service status.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum WiFiDirectServiceStatus
  {
    /// <summary>The service is available.</summary>
    Available,
    /// <summary>The service is not currently accepting connections.</summary>
    Busy,
    /// <summary>The service is returning service-defined custom status values. Get the status value from the WiFiDirectServiceAdvertiser.CustomServiceStatusCode property.</summary>
    Custom,
  }
}
