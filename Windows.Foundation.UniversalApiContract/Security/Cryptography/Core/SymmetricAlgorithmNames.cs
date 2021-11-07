// Decompiled with JetBrains decompiler
// Type: Windows.Security.Cryptography.Core.SymmetricAlgorithmNames
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Security.Cryptography.Core
{
  /// <summary>Contains static properties that enable you to retrieve algorithm names that can be used in the OpenAlgorithm method of the SymmetricKeyAlgorithmProvider class.</summary>
  [Static(typeof (ISymmetricAlgorithmNamesStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [DualApiPartition(version = 100794368)]
  public static class SymmetricAlgorithmNames
  {
    /// <summary>Retrieves a string that contains "DES_CBC".</summary>
    /// <returns>String that contains "DES_CBC".</returns>
    public static extern string DesCbc { [MethodImpl] get; }

    /// <summary>Retrieves a string that contains "DES_ECB".</summary>
    /// <returns>String that contains "DES_ECB".</returns>
    public static extern string DesEcb { [MethodImpl] get; }

    /// <summary>Retrieves a string that contains "3DES_CBC".</summary>
    /// <returns>String that contains "3DES_CBC".</returns>
    public static extern string TripleDesCbc { [MethodImpl] get; }

    /// <summary>Retrieves a string that contains "3DES_ECB".</summary>
    /// <returns>String that contains "3DES_ECB".</returns>
    public static extern string TripleDesEcb { [MethodImpl] get; }

    /// <summary>Retrieves a string that contains "RC2_CBC".</summary>
    /// <returns>String that contains "RC2_CBC".</returns>
    public static extern string Rc2Cbc { [MethodImpl] get; }

    /// <summary>Retrieves a string that contains "RC2_ECB".</summary>
    /// <returns>String that contains "RC2_ECB".</returns>
    public static extern string Rc2Ecb { [MethodImpl] get; }

    /// <summary>Retrieves a string that contains "AES_CBC".</summary>
    /// <returns>String that contains "AES_CBC".</returns>
    public static extern string AesCbc { [MethodImpl] get; }

    /// <summary>Retrieves a string that contains "AES_ECB".</summary>
    /// <returns>String that contains "AES_ECB".</returns>
    public static extern string AesEcb { [MethodImpl] get; }

    /// <summary>Retrieves a string that contains "AES_CCM".</summary>
    /// <returns>String that contains "AES_CCM".</returns>
    public static extern string AesGcm { [MethodImpl] get; }

    /// <summary>Retrieves a string that contains "AES_CCM".</summary>
    /// <returns>String that contains "AES_CCM".</returns>
    public static extern string AesCcm { [MethodImpl] get; }

    /// <summary>Retrieves a string that contains "AES_CBC_PKCS7".</summary>
    /// <returns>String that contains "AES_CBC_PKCS7".</returns>
    public static extern string AesCbcPkcs7 { [MethodImpl] get; }

    /// <summary>Retrieves a string that contains "AES_ECB_PKCS7".</summary>
    /// <returns>String that contains "AES_ECB_PKCS7".</returns>
    public static extern string AesEcbPkcs7 { [MethodImpl] get; }

    /// <summary>Retrieves a string that contains "DES_CBC_PKCS7".</summary>
    /// <returns>String that contains "DES_CBC_PKCS7".</returns>
    public static extern string DesCbcPkcs7 { [MethodImpl] get; }

    /// <summary>Retrieves a string that contains "DES_ECB_PKCS7".</summary>
    /// <returns>String that contains "DES_ECB_PKCS7".</returns>
    public static extern string DesEcbPkcs7 { [MethodImpl] get; }

    /// <summary>Retrieves a string that contains "3DES_CBC_PKCS7".</summary>
    /// <returns>String that contains "3DES_CBC_PKCS7".</returns>
    public static extern string TripleDesCbcPkcs7 { [MethodImpl] get; }

    /// <summary>Retrieves a string that contains "3DES_ECB_PKCS7".</summary>
    /// <returns>String that contains "3DES_ECB_PKCS7".</returns>
    public static extern string TripleDesEcbPkcs7 { [MethodImpl] get; }

    /// <summary>Retrieves a string that contains "RC2_CBC_PKCS7".</summary>
    /// <returns>String that contains "RC2_CBC_PKCS7".</returns>
    public static extern string Rc2CbcPkcs7 { [MethodImpl] get; }

    /// <summary>Retrieves a string that contains "RC2_ECB_PKCS7".</summary>
    /// <returns>String that contains "RC2_ECB_PKCS7".</returns>
    public static extern string Rc2EcbPkcs7 { [MethodImpl] get; }

    /// <summary>Retrieves a string that contains "RC4".</summary>
    /// <returns>String that contains "RC4".</returns>
    public static extern string Rc4 { [MethodImpl] get; }
  }
}
