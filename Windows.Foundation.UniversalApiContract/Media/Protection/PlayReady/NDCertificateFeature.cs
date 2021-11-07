// Decompiled with JetBrains decompiler
// Type: Windows.Media.Protection.PlayReady.NDCertificateFeature
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Protection.PlayReady
{
  /// <summary>Indicates the PlayReady-ND feature to which the certificate controls access.</summary>
  /// <deprecated type="deprecate">NDCertificateFeature is deprecated and might not work on all platforms. For more info, see MSDN.</deprecated>
  [Deprecated("NDCertificateFeature is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 196608, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum NDCertificateFeature
  {
    /// <summary>Entity implements transmitter functionality.</summary>
    Transmitter = 1,
    /// <summary>Entity implements receiver functionality.</summary>
    Receiver = 2,
    /// <summary>Entity shares receiver key across multiple devices.</summary>
    SharedCertificate = 3,
    /// <summary>Device implements SecureClock.</summary>
    SecureClock = 4,
    /// <summary>Device implements anti-rollback clock.</summary>
    AntiRollBackClock = 5,
    /// <summary>Entity supports certificate revocation lists.</summary>
    CRLS = 9,
    /// <summary>Entity supports PlayReady version 3.x features such as per-stream keys.</summary>
    PlayReady3Features = 13, // 0x0000000D
  }
}
