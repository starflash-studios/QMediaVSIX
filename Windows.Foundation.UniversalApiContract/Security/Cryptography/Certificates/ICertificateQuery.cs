// Decompiled with JetBrains decompiler
// Type: Windows.Security.Cryptography.Certificates.ICertificateQuery
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Security.Cryptography.Certificates
{
  [ExclusiveTo(typeof (CertificateQuery))]
  [Guid(1527261745, 42792, 18710, 181, 238, 255, 203, 138, 207, 36, 23)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface ICertificateQuery
  {
    IVector<string> EnhancedKeyUsages { get; }

    string IssuerName { get; set; }

    string FriendlyName { get; set; }

    byte[] Thumbprint { get; set; }

    bool HardwareOnly { get; set; }
  }
}
