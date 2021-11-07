// Decompiled with JetBrains decompiler
// Type: Windows.Networking.NetworkOperators.TetheringWiFiBand
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Networking.NetworkOperators
{
  /// <summary>Defines constants that specify a wireless frequency band for a WiFi adapter.</summary>
  [ContractVersion(typeof (UniversalApiContract), 655360)]
  public enum TetheringWiFiBand
  {
    /// <summary>Specifies that the WiFi adapter is free to choose any band per internal logic.</summary>
    Auto,
    /// <summary>Specifies that the WiFi adapter uses only the 2.4 GHz band.</summary>
    TwoPointFourGigahertz,
    /// <summary>Specifies that the WiFi adapter uses only the 5 GHz band.</summary>
    FiveGigahertz,
  }
}
