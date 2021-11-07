// Decompiled with JetBrains decompiler
// Type: Windows.Security.Cryptography.Core.KeyDerivationAlgorithmNames
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Security.Cryptography.Core
{
  /// <summary>Contains static properties that enable you to retrieve algorithm names that can be used in the OpenAlgorithm method of the KeyDerivationAlgorithmProvider class.</summary>
  [Static(typeof (IKeyDerivationAlgorithmNamesStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [DualApiPartition(version = 100794368)]
  [Static(typeof (IKeyDerivationAlgorithmNamesStatics2), 65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public static class KeyDerivationAlgorithmNames
  {
    /// <summary>Retrieves a string that contains "CAPI_KDF_MD5".</summary>
    /// <returns>String that contains "CAPIKDF_MD5".</returns>
    public static extern string CapiKdfMd5 { [MethodImpl] get; }

    /// <summary>Retrieves a string that contains "CAPI_KDF_SHA1".</summary>
    /// <returns>String that contains "CAPIKDF_SHA1".</returns>
    public static extern string CapiKdfSha1 { [MethodImpl] get; }

    /// <summary>Retrieves a string that contains "CAPI_KDF_SHA256".</summary>
    /// <returns>String that contains "CAPIKDF_SHA256".</returns>
    public static extern string CapiKdfSha256 { [MethodImpl] get; }

    /// <summary>Retrieves a string that contains "CAPI_KDF_SHA384".</summary>
    /// <returns>String that contains "CAPIKDF_SHA384".</returns>
    public static extern string CapiKdfSha384 { [MethodImpl] get; }

    /// <summary>Retrieves a string that contains "CAPI_KDF_SHA512".</summary>
    /// <returns>String that contains "CAPIKDF_SHA512".</returns>
    public static extern string CapiKdfSha512 { [MethodImpl] get; }

    /// <summary>Retrieves a string that contains "PBKDF2_MD5".</summary>
    /// <returns>String that contains "PBKDF2_MD5".</returns>
    public static extern string Pbkdf2Md5 { [MethodImpl] get; }

    /// <summary>Retrieves a string that contains "PBKDF2_SHA1".</summary>
    /// <returns>String that contains "PBKDF2_SHA1".</returns>
    public static extern string Pbkdf2Sha1 { [MethodImpl] get; }

    /// <summary>Retrieves a string that contains "PBKDF2_SHA256".</summary>
    /// <returns>String that contains "PBKDF2_SHA256".</returns>
    public static extern string Pbkdf2Sha256 { [MethodImpl] get; }

    /// <summary>Retrieves a string that contains "PBKDF2_SHA384".</summary>
    /// <returns>String that contains "PBKDF2_SHA384".</returns>
    public static extern string Pbkdf2Sha384 { [MethodImpl] get; }

    /// <summary>Retrieves a string that contains "PBKDF2_SHA512".</summary>
    /// <returns>String that contains "PBKDF2_SHA512".</returns>
    public static extern string Pbkdf2Sha512 { [MethodImpl] get; }

    /// <summary>Retrieves a string that contains "SP800_108_CTR_HMAC_MD5".</summary>
    /// <returns>String that contains "SP800_108_CTR_HMAC_MD5".</returns>
    public static extern string Sp800108CtrHmacMd5 { [MethodImpl] get; }

    /// <summary>Retrieves a string that contains "SP800_108_CTR_HMAC_SHA1".</summary>
    /// <returns>String that contains "SP800_108_CTR_HMAC_SHA1".</returns>
    public static extern string Sp800108CtrHmacSha1 { [MethodImpl] get; }

    /// <summary>Retrieves a string that contains "SP800_108_CTR_HMAC_SHA256".</summary>
    /// <returns>String that contains "SP800_108_CTR_HMAC_SHA256".</returns>
    public static extern string Sp800108CtrHmacSha256 { [MethodImpl] get; }

    /// <summary>Retrieves a string that contains "SP800_108_CTR_HMAC_SHA384".</summary>
    /// <returns>String that contains "SP800_108_CTR_HMAC_SHA384".</returns>
    public static extern string Sp800108CtrHmacSha384 { [MethodImpl] get; }

    /// <summary>Retrieves a string that contains "SP800_108_CTR_HMAC_SHA512".</summary>
    /// <returns>String that contains "SP800_108_CTR_HMAC_SHA512".</returns>
    public static extern string Sp800108CtrHmacSha512 { [MethodImpl] get; }

    /// <summary>Retrieves a string that contains "SP800_56A_CONCAT_MD5".</summary>
    /// <returns>String that contains "SP800_56A_CONCAT_MD5".</returns>
    public static extern string Sp80056aConcatMd5 { [MethodImpl] get; }

    /// <summary>Retrieves a string that contains "SP800_56A_CONCAT_SHA1".</summary>
    /// <returns>String that contains "SP800_56A_CONCAT_SHA1".</returns>
    public static extern string Sp80056aConcatSha1 { [MethodImpl] get; }

    /// <summary>Retrieves a string that contains "SP800_108_CTR_HMAC_SHA256".</summary>
    /// <returns>String that contains "SP800_108_CTR_HMAC_SHA256".</returns>
    public static extern string Sp80056aConcatSha256 { [MethodImpl] get; }

    /// <summary>Retrieves a string that contains "SP800_108_CTR_HMAC_SHA384".</summary>
    /// <returns>String that contains "SP800_108_CTR_HMAC_SHA384".</returns>
    public static extern string Sp80056aConcatSha384 { [MethodImpl] get; }

    /// <summary>Retrieves a string that contains "SP800_56A_CONCAT_SHA512".</summary>
    /// <returns>String that contains "SP800_56A_CONCAT_SHA512".</returns>
    public static extern string Sp80056aConcatSha512 { [MethodImpl] get; }
  }
}
