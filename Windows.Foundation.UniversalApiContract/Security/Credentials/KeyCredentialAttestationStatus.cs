// Decompiled with JetBrains decompiler
// Type: Windows.Security.Credentials.KeyCredentialAttestationStatus
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Security.Credentials
{
  /// <summary>Represents key credential attestation statuses.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum KeyCredentialAttestationStatus
  {
    /// <summary>The operation was successful.</summary>
    Success,
    /// <summary>The operation encountered an unknown error.</summary>
    UnknownError,
    /// <summary>The operation was not supported.</summary>
    NotSupported,
    /// <summary>The operation temporarily failed.</summary>
    TemporaryFailure,
  }
}
