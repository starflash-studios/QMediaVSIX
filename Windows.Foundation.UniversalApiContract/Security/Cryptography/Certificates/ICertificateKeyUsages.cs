// Decompiled with JetBrains decompiler
// Type: Windows.Security.Cryptography.Certificates.ICertificateKeyUsages
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Security.Cryptography.Certificates
{
  [ExclusiveTo(typeof (CertificateKeyUsages))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(1791369327, 57807, 18538, 180, 133, 166, 156, 131, 228, 111, 209)]
  internal interface ICertificateKeyUsages
  {
    bool EncipherOnly { get; set; }

    bool CrlSign { get; set; }

    bool KeyCertificateSign { get; set; }

    bool KeyAgreement { get; set; }

    bool DataEncipherment { get; set; }

    bool KeyEncipherment { get; set; }

    bool NonRepudiation { get; set; }

    bool DigitalSignature { get; set; }
  }
}
