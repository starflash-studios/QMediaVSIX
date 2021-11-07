// Decompiled with JetBrains decompiler
// Type: Windows.Security.Cryptography.Certificates.ICertificateStoresStatics2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Security.Cryptography.Certificates
{
  [Guid(4203744121, 41172, 19340, 188, 85, 192, 163, 126, 177, 65, 237)]
  [ExclusiveTo(typeof (CertificateStores))]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  internal interface ICertificateStoresStatics2
  {
    UserCertificateStore GetUserStoreByName(string storeName);
  }
}
