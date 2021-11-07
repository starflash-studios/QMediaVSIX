// Decompiled with JetBrains decompiler
// Type: Windows.Devices.WiFi.WiFiConnectionMethod
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.WiFi
{
  /// <summary>Describes the kinds of connection methods.</summary>
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  public enum WiFiConnectionMethod
  {
    /// <summary>Default.</summary>
    Default,
    /// <summary>WPS pin.</summary>
    WpsPin,
    /// <summary>WPS protected setup.</summary>
    WpsPushButton,
  }
}
