// Decompiled with JetBrains decompiler
// Type: Windows.Devices.WiFiDirect.WiFiDirectAdvertisementListenStateDiscoverability
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.WiFiDirect
{
  /// <summary>Specifies whether the Wi-Fi Direct device is listening and discoverable.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum WiFiDirectAdvertisementListenStateDiscoverability
  {
    /// <summary>The device is not discoverable.</summary>
    None,
    /// <summary>The device is highly discoverable so long as the app is in the foreground.</summary>
    Normal,
    /// <summary>The device is discoverable when the app is in the foreground or in the background.</summary>
    Intensive,
  }
}
