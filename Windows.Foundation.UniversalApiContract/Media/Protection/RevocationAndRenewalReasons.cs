// Decompiled with JetBrains decompiler
// Type: Windows.Media.Protection.RevocationAndRenewalReasons
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Protection
{
  /// <summary>Defines reasons for the revocation and renewal of a certificate for a media component.</summary>
  [Flags]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum RevocationAndRenewalReasons : uint
  {
    /// <summary>User-mode component.</summary>
    UserModeComponentLoad = 1,
    /// <summary>Kernel-mode component.</summary>
    KernelModeComponentLoad = 2,
    /// <summary>App component.</summary>
    AppComponent = 4,
    /// <summary>Could not load the global revocation list (GRL).</summary>
    GlobalRevocationListLoadFailed = 16, // 0x00000010
    /// <summary>The GRL signature is invalid.</summary>
    InvalidGlobalRevocationListSignature = 32, // 0x00000020
    /// <summary>The GRL was not found.</summary>
    GlobalRevocationListAbsent = 4096, // 0x00001000
    /// <summary>A trusted component was revoked.</summary>
    ComponentRevoked = 8192, // 0x00002000
    /// <summary>A certificate's extended key usage (EKU) object is invalid.</summary>
    InvalidComponentCertificateExtendedKeyUse = 16384, // 0x00004000
    /// <summary>A certificate in a trusted component's certificate chain was revoked.</summary>
    ComponentCertificateRevoked = 32768, // 0x00008000
    /// <summary>The root certificate is not valid.</summary>
    InvalidComponentCertificateRoot = 65536, // 0x00010000
    /// <summary>The high-security certificate for authenticating the protected environment (PE) was revoked.</summary>
    ComponentHighSecurityCertificateRevoked = 131072, // 0x00020000
    /// <summary>The low-security certificate for authenticating the PE was revoked.</summary>
    ComponentLowSecurityCertificateRevoked = 262144, // 0x00040000
    /// <summary>A boot driver could not be verified.</summary>
    BootDriverVerificationFailed = 1048576, // 0x00100000
    /// <summary>A component was signed by a test certificate.</summary>
    ComponentSignedWithTestCertificate = 16777216, // 0x01000000
    /// <summary>A certificate chain was not well-formed, or a boot driver is unsigned or is signed with an untrusted certificate.</summary>
    EncryptionFailure = 268435456, // 0x10000000
  }
}
