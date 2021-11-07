// Decompiled with JetBrains decompiler
// Type: Windows.Security.Cryptography.Certificates.ChainValidationResult
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Security.Cryptography.Certificates
{
  /// <summary>Describes the result of a certificate chain verification operation.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum ChainValidationResult
  {
    /// <summary>The certificate chain was verified.</summary>
    Success,
    /// <summary>A certificate in the chain is not trusted.</summary>
    Untrusted,
    /// <summary>A certificate in the chain has been revoked.</summary>
    Revoked,
    /// <summary>A certificate in the chain has expired.</summary>
    Expired,
    /// <summary>The certificate chain is missing one or more certificates.</summary>
    IncompleteChain,
    /// <summary>The signature of a certificate in the chain cannot be verified.</summary>
    InvalidSignature,
    /// <summary>A certificate in the chain is being used for a purpose other than one specified by its CA.</summary>
    WrongUsage,
    /// <summary>A certificate in the chain has a name that is not valid. The name is either not included in the permitted list or is explicitly excluded.</summary>
    InvalidName,
    /// <summary>A certificate in the chain has a policy that is not valid.</summary>
    InvalidCertificateAuthorityPolicy,
    /// <summary>The basic constraint extension of a certificate in the chain has not been observed.</summary>
    BasicConstraintsError,
    /// <summary>A certificate in the chain contains an unknown extension that is marked "critical".</summary>
    UnknownCriticalExtension,
    /// <summary>No installed or registered DLL was found to verify revocation.</summary>
    RevocationInformationMissing,
    /// <summary>Unable to connect to the revocation server.</summary>
    RevocationFailure,
    /// <summary>An unexpected error occurred while validating the certificate chain.</summary>
    OtherErrors,
  }
}
