// Decompiled with JetBrains decompiler
// Type: Windows.Media.Miracast.MiracastReceiverWiFiStatus
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Miracast
{
  /// <summary>Status information about the Miracast Receiver's Wi-Fi functionality.</summary>
  [ContractVersion(typeof (UniversalApiContract), 524288)]
  public enum MiracastReceiverWiFiStatus
  {
    /// <summary>It has not been determined if the Wi-Fi adapter supports Miracast.</summary>
    MiracastSupportUndetermined,
    /// <summary>Miracast is not supported. Possible cause is a missing or incompatible Wi-Fi adapter.</summary>
    MiracastNotSupported,
    /// <summary>Miracast is supported but the Wi-Fi adapter was not designed for Miracast, which can result in compatibility problems.</summary>
    MiracastSupportNotOptimized,
    /// <summary>Miracast is supported.</summary>
    MiracastSupported,
  }
}
