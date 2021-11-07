// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Email.EmailMailboxSmimeSigningAlgorithm
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Email
{
  /// <summary>Defines the algorithm used to sign an email.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum EmailMailboxSmimeSigningAlgorithm
  {
    /// <summary>No specific algorithm is required.</summary>
    Any,
    /// <summary>Use Secure Hash Algorithm 1 (160-bit).</summary>
    Sha1,
    /// <summary>Use Message Digest algorithm 5 (128-bit).</summary>
    MD5,
  }
}
