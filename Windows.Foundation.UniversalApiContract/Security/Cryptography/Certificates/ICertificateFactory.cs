// Decompiled with JetBrains decompiler
// Type: Windows.Security.Cryptography.Certificates.ICertificateFactory
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Security.Cryptography.Certificates
{
  [ExclusiveTo(typeof (Certificate))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(397681180, 19375, 17570, 150, 8, 4, 251, 98, 177, 105, 66)]
  internal interface ICertificateFactory
  {
    Certificate CreateCertificate(IBuffer certBlob);
  }
}
