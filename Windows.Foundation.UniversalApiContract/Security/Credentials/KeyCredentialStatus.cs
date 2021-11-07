// Decompiled with JetBrains decompiler
// Type: Windows.Security.Credentials.KeyCredentialStatus
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Security.Credentials
{
  /// <summary>Represents the status of a key credential request.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum KeyCredentialStatus
  {
    /// <summary>The operation was successful.</summary>
    Success,
    /// <summary>An unknown error occurred.</summary>
    UnknownError,
    /// <summary>The credential could not be found.</summary>
    NotFound,
    /// <summary>The request was cancelled by the user.</summary>
    UserCanceled,
    /// <summary>The user prefers to enter a password.</summary>
    UserPrefersPassword,
    /// <summary>The credential already exists.</summary>
    CredentialAlreadyExists,
    /// <summary>The security device was locked.</summary>
    SecurityDeviceLocked,
  }
}
