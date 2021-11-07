// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Email.EmailRecipientResolutionStatus
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Email
{
  /// <summary>Describes the state of an attempt to resolve an email recipient.</summary>
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  public enum EmailRecipientResolutionStatus
  {
    /// <summary>Success. Email recipient resolved.</summary>
    Success,
    /// <summary>Resolution failed. Recipient cannot be resolved because no match found in distribution list.</summary>
    RecipientNotFound,
    /// <summary>Resolution failed. Multiple results returned. Refinement needed.</summary>
    AmbiguousRecipient,
    /// <summary>Resolution failed. No valid certificate present.</summary>
    NoCertificate,
    /// <summary>Resolution failed. The limit of allowed requests for the current certificate has been reached.</summary>
    CertificateRequestLimitReached,
    /// <summary>Resolution failed. The distribution list cannot be accessed.</summary>
    CannotResolveDistributionList,
    /// <summary>Resolution failed. There has been an error on the server.</summary>
    ServerError,
    /// <summary>Resolution failed for unknown reason.</summary>
    UnknownFailure,
  }
}
