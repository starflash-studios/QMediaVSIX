// Decompiled with JetBrains decompiler
// Type: Windows.Security.Cryptography.Certificates.UserCertificateStore
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Security.Cryptography.Certificates
{
  /// <summary>Represents a user certificate store.</summary>
  [DualApiPartition(version = 167772162)]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  public sealed class UserCertificateStore : IUserCertificateStore
  {
    /// <summary>Requests to add a certificate to the store.</summary>
    /// <param name="certificate">The certificate to add.</param>
    /// <returns>When this method completes, it returns true if the certificate was successfully added; otherwise, it returns false.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<bool> RequestAddAsync(Certificate certificate);

    /// <summary>Requests to delete a certificate from the store.</summary>
    /// <param name="certificate">The certificate to delete.</param>
    /// <returns>When this method completes, it returns true if the certificate was successfully deleted; otherwise, it returns false.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<bool> RequestDeleteAsync(Certificate certificate);

    /// <summary>Gets the name of the store.</summary>
    /// <returns>The name of the store.</returns>
    public extern string Name { [MethodImpl] get; }
  }
}
