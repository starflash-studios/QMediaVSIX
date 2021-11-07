// Decompiled with JetBrains decompiler
// Type: Windows.Security.Cryptography.Certificates.ICertificateChain
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Security.Cryptography.Certificates
{
  [ExclusiveTo(typeof (CertificateChain))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(549409669, 13969, 17665, 166, 44, 253, 151, 39, 139, 49, 238)]
  internal interface ICertificateChain
  {
    [Overload("Validate")]
    ChainValidationResult Validate();

    [Overload("ValidateWithParameters")]
    ChainValidationResult Validate(ChainValidationParameters parameter);

    IVectorView<Certificate> GetCertificates(bool includeRoot);
  }
}
