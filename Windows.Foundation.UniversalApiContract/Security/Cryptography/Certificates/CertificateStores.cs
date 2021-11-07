// Decompiled with JetBrains decompiler
// Type: Windows.Security.Cryptography.Certificates.CertificateStores
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Security.Cryptography.Certificates
{
  /// <summary>Represents a collection of certificate stores.</summary>
  [Static(typeof (ICertificateStoresStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [Static(typeof (ICertificateStoresStatics2), 196608, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [DualApiPartition(version = 100859904)]
  public static class CertificateStores
  {
    /// <summary>Gets a user certificate store from the collection of certificate stores by name.</summary>
    /// <param name="storeName">The name of the user certificate store to return.</param>
    /// <returns>The user certificate store.</returns>
    [MethodImpl]
    public static extern UserCertificateStore GetUserStoreByName(
      string storeName);

    /// <summary>Get all certificates from the certificate stores.</summary>
    /// <returns>An asynchronous operation to retrieve the list of certificates.</returns>
    [RemoteAsync]
    [Overload("FindAllAsync")]
    [MethodImpl]
    public static extern IAsyncOperation<IVectorView<Certificate>> FindAllAsync();

    /// <summary>Get all certificates from the certificate stores that match the specified query parameters.</summary>
    /// <param name="query">The certificate values to search for.</param>
    /// <returns>An asynchronous operation to retrieve the list of certificates.</returns>
    [RemoteAsync]
    [Overload("FindAllWithQueryAsync")]
    [MethodImpl]
    public static extern IAsyncOperation<IVectorView<Certificate>> FindAllAsync(
      CertificateQuery query);

    /// <summary>Gets the certificate store of trusted root certificates for an app.</summary>
    /// <returns>The certificate store of trusted root certificates for an app.</returns>
    public static extern CertificateStore TrustedRootCertificationAuthorities { [MethodImpl] get; }

    /// <summary>Gets the certificate store of intermediate certification authorities for an app.</summary>
    /// <returns>The certificate store of intermediate certification authorities for an app.</returns>
    public static extern CertificateStore IntermediateCertificationAuthorities { [MethodImpl] get; }

    /// <summary>Gets a certificate store from the collection of certificate stores by name.</summary>
    /// <param name="storeName">The name of the certificate store to return. The *storeName* parameter value cannot be "MY".</param>
    /// <returns>The requested certificate store.</returns>
    [MethodImpl]
    public static extern CertificateStore GetStoreByName(string storeName);
  }
}
