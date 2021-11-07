// Decompiled with JetBrains decompiler
// Type: Windows.Security.Cryptography.Core.PersistedKeyProvider
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Security.Cryptography.Certificates;

namespace Windows.Security.Cryptography.Core
{
  /// <summary>Retrieves a persisted key from a Certificate object.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Threading(ThreadingModel.Both)]
  [Static(typeof (IPersistedKeyProviderStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [DualApiPartition(version = 100794368)]
  public static class PersistedKeyProvider
  {
    /// <summary>Opens the persisted private key from the specified Certificate object.</summary>
    /// <param name="certificate">The certificate that is associated with the private key.</param>
    /// <param name="hashAlgorithmName">The hash algorithm for signature operations. For encryption, the hash algorithm is ignored.</param>
    /// <param name="padding">The padding mode for asymmetric algorithm signature or encryption operations.</param>
    /// <returns>An asynchronous operation for retrieving a private key from the supplied Certificate object.</returns>
    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<CryptographicKey> OpenKeyPairFromCertificateAsync(
      Certificate certificate,
      string hashAlgorithmName,
      CryptographicPadding padding);

    /// <summary>Opens the persisted public key from the specified Certificate object.</summary>
    /// <param name="certificate">The certificate that contains the public key.</param>
    /// <param name="hashAlgorithmName">The has algorithm for signature operations.</param>
    /// <param name="padding">The padding mode for asymmetric algorithm signature or encryption operations.</param>
    /// <returns>The public key retrieved from the supplied Certificate object.</returns>
    [MethodImpl]
    public static extern CryptographicKey OpenPublicKeyFromCertificate(
      Certificate certificate,
      string hashAlgorithmName,
      CryptographicPadding padding);
  }
}
