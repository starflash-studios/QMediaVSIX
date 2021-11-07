// Decompiled with JetBrains decompiler
// Type: Windows.Security.Cryptography.Certificates.IUserCertificateStore
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Security.Cryptography.Certificates
{
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [Guid(3388677507, 30879, 19278, 145, 128, 4, 90, 117, 122, 172, 109)]
  [ExclusiveTo(typeof (UserCertificateStore))]
  internal interface IUserCertificateStore
  {
    [RemoteAsync]
    IAsyncOperation<bool> RequestAddAsync(Certificate certificate);

    [RemoteAsync]
    IAsyncOperation<bool> RequestDeleteAsync(Certificate certificate);

    string Name { get; }
  }
}
