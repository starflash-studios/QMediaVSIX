// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Email.EmailCertificateValidationStatus
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Email
{
  /// <summary>Describes the result of an attempt to validate a certificate.</summary>
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  public enum EmailCertificateValidationStatus
  {
    /// <summary>Success. Certificate validated.</summary>
    Success,
    /// <summary>Validation failed. No matching certificate found.</summary>
    NoMatch,
    /// <summary>Validation failed. Invalid usage of certificate.</summary>
    InvalidUsage,
    /// <summary>Validation failed. Certificate is not valid.</summary>
    InvalidCertificate,
    /// <summary>Validation failed. Certificate revoked.</summary>
    Revoked,
    /// <summary>Validation failed. One or more certificates in the chain, other than the current certificate, have been revoked.</summary>
    ChainRevoked,
    /// <summary>Validation failed. Revocation server failure.</summary>
    RevocationServerFailure,
    /// <summary>Validation failed. Certificate expired.</summary>
    Expired,
    /// <summary>Validation failed. Certificate untrusted.</summary>
    Untrusted,
    /// <summary>Validation failed. Server failure.</summary>
    ServerError,
    /// <summary>Validation failed. Unknown failure.</summary>
    UnknownFailure,
  }
}
