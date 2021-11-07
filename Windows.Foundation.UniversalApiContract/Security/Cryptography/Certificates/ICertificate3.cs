// Decompiled with JetBrains decompiler
// Type: Windows.Security.Cryptography.Certificates.ICertificate3
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Security.Cryptography.Certificates
{
  [ExclusiveTo(typeof (Certificate))]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [Guid(3193022822, 44639, 18002, 172, 231, 198, 215, 231, 114, 76, 243)]
  internal interface ICertificate3
  {
    bool IsPerUser { get; }

    string StoreName { get; }

    string KeyStorageProviderName { get; }
  }
}
