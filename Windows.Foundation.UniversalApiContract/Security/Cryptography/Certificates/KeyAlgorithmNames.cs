// Decompiled with JetBrains decompiler
// Type: Windows.Security.Cryptography.Certificates.KeyAlgorithmNames
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Security.Cryptography.Certificates
{
  /// <summary>Defines several commonly used public key algorithm names. You can use this class in the KeyAlgorithmName property on the CertificateRequestProperties class.</summary>
  [Threading(ThreadingModel.Both)]
  [DualApiPartition(version = 100794368)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Static(typeof (IKeyAlgorithmNamesStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [Static(typeof (IKeyAlgorithmNamesStatics2), 65536, "Windows.Foundation.UniversalApiContract")]
  public static class KeyAlgorithmNames
  {
    /// <summary>Returns "ECDSA" as the key algorithm name.</summary>
    /// <returns>The key algorithm name.</returns>
    public static extern string Ecdsa { [MethodImpl] get; }

    /// <summary>Returns "ECDH" as the key algorithm name.</summary>
    /// <returns>The key algorithm name.</returns>
    public static extern string Ecdh { [MethodImpl] get; }

    /// <summary>Returns "RSA" as the key algorithm name.</summary>
    /// <returns>The key algorithm name.</returns>
    public static extern string Rsa { [MethodImpl] get; }

    /// <summary>Returns "DSA" as the key algorithm name.</summary>
    /// <returns>The key algorithm name.</returns>
    public static extern string Dsa { [MethodImpl] get; }

    /// <summary>Returns "ECDH256" as the key algorithm name.</summary>
    /// <returns>The key algorithm name.</returns>
    public static extern string Ecdh256 { [MethodImpl] get; }

    /// <summary>Returns "ECDH384" as the key algorithm name.</summary>
    /// <returns>The key algorithm name.</returns>
    public static extern string Ecdh384 { [MethodImpl] get; }

    /// <summary>Returns "ECDH521" as the key algorithm name.</summary>
    /// <returns>The key algorithm name.</returns>
    public static extern string Ecdh521 { [MethodImpl] get; }

    /// <summary>Returns "ECDSA256" as the key algorithm name.</summary>
    /// <returns>The key algorithm name.</returns>
    public static extern string Ecdsa256 { [MethodImpl] get; }

    /// <summary>Returns "ECDSA384" as the key algorithm name.</summary>
    /// <returns>The key algorithm name.</returns>
    public static extern string Ecdsa384 { [MethodImpl] get; }

    /// <summary>Returns "ECDSA521" as the key algorithm name.</summary>
    /// <returns>The key algorithm name.</returns>
    public static extern string Ecdsa521 { [MethodImpl] get; }
  }
}
