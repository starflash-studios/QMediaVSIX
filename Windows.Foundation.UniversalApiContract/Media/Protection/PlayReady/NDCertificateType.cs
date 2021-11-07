// Decompiled with JetBrains decompiler
// Type: Windows.Media.Protection.PlayReady.NDCertificateType
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Protection.PlayReady
{
  /// <summary>Indicates the type and purpose of a PlayReady-ND transmitter license.</summary>
  /// <deprecated type="deprecate">NDCertificateType is deprecated and might not work on all platforms. For more info, see MSDN.</deprecated>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Deprecated("NDCertificateType is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 196608, "Windows.Foundation.UniversalApiContract")]
  public enum NDCertificateType
  {
    /// <summary>An unknown certificate type. Apps should never use this value.</summary>
    Unknown,
    /// <summary>A leaf level certificate used by the PC client.</summary>
    PC,
    /// <summary>A leaf level certificate used by a device.</summary>
    Device,
    /// <summary>A leaf level certificate used by a PC or a device when a member of a domain.</summary>
    Domain,
    /// <summary>Can be an issuer of certificates for either an issuer or a leaf certificate.</summary>
    Issuer,
    /// <summary>A leaf level certificate used to sign CRLs issued by Microsoft.</summary>
    CrlSigner,
    /// <summary>A leaf level certificate used by services such as Secure Clock. Reserved for future use.</summary>
    Service,
    /// <summary>A leaf level certificate for a Silverlight client.</summary>
    Silverlight,
    /// <summary>A leaf level certificate for a PlayReady client.</summary>
    Application,
    /// <summary>A leaf level certificate used by digital rights management clients to encrypt metering data sent to a PlayReady SDK server.</summary>
    Metering,
    /// <summary>A leaf level certificate used by the cryptography server to sign the key file.</summary>
    KeyFileSigner,
    /// <summary>A leaf level certificate used by the PlayReady server.</summary>
    Server,
    /// <summary>A certificate used by a license signer.</summary>
    LicenseSigner,
  }
}
