// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Email.EmailMailboxSmimeEncryptionAlgorithm
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Email
{
  /// <summary>Defines the encryption algorithm used for an email.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum EmailMailboxSmimeEncryptionAlgorithm
  {
    /// <summary>The encryption algorithm requirements are not specified.</summary>
    Any,
    /// <summary>Use the Triple Data Encryption Algorithm symmetric-key block cipher algorithm.</summary>
    TripleDes,
    /// <summary>Use the Data Encryption Standard symmetric key block cipher algorithm.</summary>
    Des,
    /// <summary>Use the RC2 128-bit block cipher encryption algorithm.</summary>
    RC2128Bit,
    /// <summary>Use the RC2 64-bit block cipher encryption algorithm.</summary>
    RC264Bit,
    /// <summary>Use the RC2 40-bit block cipher encryption algorithm.</summary>
    RC240Bit,
  }
}
