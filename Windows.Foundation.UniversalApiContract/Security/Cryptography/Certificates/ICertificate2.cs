// Decompiled with JetBrains decompiler
// Type: Windows.Security.Cryptography.Certificates.ICertificate2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Security.Cryptography.Certificates
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (Certificate))]
  [Guid(397948748, 35365, 19862, 164, 146, 143, 194, 154, 196, 253, 166)]
  internal interface ICertificate2
  {
    bool IsSecurityDeviceBound { get; }

    CertificateKeyUsages KeyUsages { get; }

    string KeyAlgorithmName { get; }

    string SignatureAlgorithmName { get; }

    string SignatureHashAlgorithmName { get; }

    SubjectAlternativeNameInfo SubjectAlternativeName { get; }
  }
}
