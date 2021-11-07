// Decompiled with JetBrains decompiler
// Type: Windows.Devices.WiFi.WiFiWpsKind
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.WiFi
{
  /// <summary>Describes the kinds of WPS connection methods.</summary>
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  public enum WiFiWpsKind
  {
    /// <summary>Unknown.</summary>
    Unknown,
    /// <summary>WPS pin.</summary>
    Pin,
    /// <summary>WPS push button.</summary>
    PushButton,
    /// <summary>Near field communication.</summary>
    Nfc,
    /// <summary>Not used.</summary>
    Ethernet,
    /// <summary>Not used.</summary>
    Usb,
  }
}
