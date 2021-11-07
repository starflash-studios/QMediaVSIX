// Decompiled with JetBrains decompiler
// Type: Windows.Security.Cryptography.Certificates.ICmsSignerInfo
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Security.Cryptography.Certificates
{
  [Guid(1355817179, 7471, 19482, 181, 197, 208, 24, 143, 249, 31, 71)]
  [ExclusiveTo(typeof (CmsSignerInfo))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface ICmsSignerInfo
  {
    Certificate Certificate { get; set; }

    string HashAlgorithmName { get; set; }

    CmsTimestampInfo TimestampInfo { get; }
  }
}
