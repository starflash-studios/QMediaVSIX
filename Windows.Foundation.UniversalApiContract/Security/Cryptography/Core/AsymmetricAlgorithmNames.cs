// Decompiled with JetBrains decompiler
// Type: Windows.Security.Cryptography.Core.AsymmetricAlgorithmNames
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Security.Cryptography.Core
{
  /// <summary>Contains static properties that enable you to retrieve algorithm names that can be used in the OpenAlgorithm method of the AsymmetricKeyAlgorithmProvider class.</summary>
  [Static(typeof (IAsymmetricAlgorithmNamesStatics2), 65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Static(typeof (IAsymmetricAlgorithmNamesStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [DualApiPartition(version = 100794368)]
  public static class AsymmetricAlgorithmNames
  {
    /// <summary>Retrieves a string that contains "ECDSA_SHA256".</summary>
    /// <returns>String that contains "ECDSA_SHA256".</returns>
    public static extern string EcdsaSha256 { [MethodImpl] get; }

    /// <summary>Retrieves a string that contains "ECDSA_SHA384".</summary>
    /// <returns>String that contains "ECDSA_SHA384".</returns>
    public static extern string EcdsaSha384 { [MethodImpl] get; }

    /// <summary>Retrieves a string that contains "ECDSA_SHA512".</summary>
    /// <returns>String that contains "ECDSA_SHA512".</returns>
    public static extern string EcdsaSha512 { [MethodImpl] get; }

    /// <summary>Retrieves a string that contains "RSA_PKCS1".</summary>
    /// <returns>String that contains "RSA_PKCS1".</returns>
    public static extern string RsaPkcs1 { [MethodImpl] get; }

    /// <summary>Retrieves a string that contains "RSA_OAEP_SHA1".</summary>
    /// <returns>String that contains "RSA_OAEP_SHA1".</returns>
    public static extern string RsaOaepSha1 { [MethodImpl] get; }

    /// <summary>Retrieves a string that contains "RSA_OAEP_SHA256".</summary>
    /// <returns>String that contains "RSA_OAEP_SHA256".</returns>
    public static extern string RsaOaepSha256 { [MethodImpl] get; }

    /// <summary>Retrieves a string that contains "RSA_OAEP_SHA384".</summary>
    /// <returns>String that contains "RSA_OAEP_SHA384".</returns>
    public static extern string RsaOaepSha384 { [MethodImpl] get; }

    /// <summary>Retrieves a string that contains "RSA_OAEP_SHA512".</summary>
    /// <returns>String that contains "RSA_OAEP_SHA512".</returns>
    public static extern string RsaOaepSha512 { [MethodImpl] get; }

    /// <summary>Retrieves a string that contains "ECDSA_P256_SHA256".</summary>
    /// <returns>String that contains "ECDSA_P256_SHA256".</returns>
    public static extern string EcdsaP256Sha256 { [MethodImpl] get; }

    /// <summary>Retrieves a string that contains "ECDSA_P384_SHA384".</summary>
    /// <returns>String that contains "ECDSA_P384_SHA384".</returns>
    public static extern string EcdsaP384Sha384 { [MethodImpl] get; }

    /// <summary>Retrieves a string that contains "ECDSA_P521_SHA512".</summary>
    /// <returns>String that contains "ECDSA_P521_SHA512".</returns>
    public static extern string EcdsaP521Sha512 { [MethodImpl] get; }

    /// <summary>Retrieves a string that contains "DSA_SHA1".</summary>
    /// <returns>String that contains "DSA_SHA1".</returns>
    public static extern string DsaSha1 { [MethodImpl] get; }

    /// <summary>Retrieves a string that contains "DSA_SHA256".</summary>
    /// <returns>String that contains "DSA_SHA256".</returns>
    public static extern string DsaSha256 { [MethodImpl] get; }

    /// <summary>Retrieves a string that contains "RSASIGN_PKCS1_SHA1".</summary>
    /// <returns>String that contains "RSASIGN_PKCS1_SHA1".</returns>
    public static extern string RsaSignPkcs1Sha1 { [MethodImpl] get; }

    /// <summary>Retrieves a string that contains "RSASIGN_PKCS1_SHA256".</summary>
    /// <returns>String that contains "RSASIGN_PKCS1_SHA256".</returns>
    public static extern string RsaSignPkcs1Sha256 { [MethodImpl] get; }

    /// <summary>Retrieves a string that contains "RSASIGN_PKCS1_SHA384".</summary>
    /// <returns>String that contains "RSASIGN_PKCS1_SHA384".</returns>
    public static extern string RsaSignPkcs1Sha384 { [MethodImpl] get; }

    /// <summary>Retrieves a string that contains "RSASIGN_PSS_SHA512".</summary>
    /// <returns>String that contains "RSASIGN_PSS_SHA512".</returns>
    public static extern string RsaSignPkcs1Sha512 { [MethodImpl] get; }

    /// <summary>Retrieves a string that contains "RSASIGN_PSS_SHA1".</summary>
    /// <returns>String that contains "RSASIGN_PSS_SHA1".</returns>
    public static extern string RsaSignPssSha1 { [MethodImpl] get; }

    /// <summary>Retrieves a string that contains "RSASIGN_PSS_SHA256".</summary>
    /// <returns>String that contains "RSASIGN_PSS_SHA256".</returns>
    public static extern string RsaSignPssSha256 { [MethodImpl] get; }

    /// <summary>Retrieves a string that contains "RSASIGN_PSS_SHA384".</summary>
    /// <returns>String that contains "RSASIGN_PSS_SHA384".</returns>
    public static extern string RsaSignPssSha384 { [MethodImpl] get; }

    /// <summary>Retrieves a string that contains "RSASIGN_PSS_SHA512".</summary>
    /// <returns>String that contains "RSASIGN_PSS_SHA512".</returns>
    public static extern string RsaSignPssSha512 { [MethodImpl] get; }
  }
}
