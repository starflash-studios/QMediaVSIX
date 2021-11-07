// Decompiled with JetBrains decompiler
// Type: Windows.Security.Cryptography.Certificates.SignatureValidationResult
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Security.Cryptography.Certificates
{
  /// <summary>Describes the result of a signature verification operation.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum SignatureValidationResult
  {
    /// <summary>The signature was verified.</summary>
    Success,
    /// <summary>An invalid argument was encountered while verifying the signature.</summary>
    InvalidParameter,
    /// <summary>A severe error occurred such as missing key provider information or an incorrect algorithm id.</summary>
    BadMessage,
    /// <summary>The signature was not verified.</summary>
    InvalidSignature,
    /// <summary>Additional errors were encountered.</summary>
    OtherErrors,
  }
}
