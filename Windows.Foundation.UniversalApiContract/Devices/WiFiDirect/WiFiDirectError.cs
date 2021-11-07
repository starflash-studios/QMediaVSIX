// Decompiled with JetBrains decompiler
// Type: Windows.Devices.WiFiDirect.WiFiDirectError
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.WiFiDirect
{
  /// <summary>Specifies some common Wi-Fi Direct error cases.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum WiFiDirectError
  {
    /// <summary>The operation was successfully completed or serviced.</summary>
    Success,
    /// <summary>The Wi-Fi Direct radio was not available. This error occurs when the Wi-Fi Direct radio has been turned off.</summary>
    RadioNotAvailable,
    /// <summary>The operation cannot be serviced because the necessary resources are currently in use.</summary>
    ResourceInUse,
  }
}
