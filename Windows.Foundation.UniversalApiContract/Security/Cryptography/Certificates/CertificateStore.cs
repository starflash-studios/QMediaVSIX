// Decompiled with JetBrains decompiler
// Type: Windows.Security.Cryptography.Certificates.CertificateStore
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Security.Cryptography.Certificates
{
  /// <summary>Represents a certificate store for an app.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [DualApiPartition(version = 100859904)]
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class CertificateStore : ICertificateStore, ICertificateStore2
  {
    /// <summary>Adds a certificate to the certificate store.</summary>
    /// <param name="certificate">The certificate to add to the certificate store.</param>
    [MethodImpl]
    public extern void Add(Certificate certificate);

    /// <summary>Deletes a certificate from the certificate store.</summary>
    /// <param name="certificate">The certificate to delete from the certificate store.</param>
    [MethodImpl]
    public extern void Delete(Certificate certificate);

    /// <summary>Gets the name of the certificate store.</summary>
    /// <returns>The name of the certificate store.</returns>
    public extern string Name { [MethodImpl] get; }
  }
}
