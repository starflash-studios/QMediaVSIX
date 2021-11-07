// Decompiled with JetBrains decompiler
// Type: Windows.Security.Cryptography.Certificates.ICertificateExtension
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Security.Cryptography.Certificates
{
  [Guid(2228160086, 43494, 17741, 142, 69, 46, 167, 196, 188, 213, 59)]
  [ExclusiveTo(typeof (CertificateExtension))]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  internal interface ICertificateExtension
  {
    string ObjectId { get; set; }

    bool IsCritical { get; set; }

    void EncodeValue(string value);

    byte[] Value { get; set; }
  }
}
