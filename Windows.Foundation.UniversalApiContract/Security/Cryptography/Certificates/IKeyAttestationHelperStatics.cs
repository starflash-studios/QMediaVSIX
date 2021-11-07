// Decompiled with JetBrains decompiler
// Type: Windows.Security.Cryptography.Certificates.IKeyAttestationHelperStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Security.Cryptography.Certificates
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (KeyAttestationHelper))]
  [Guid(373875270, 63044, 17190, 136, 190, 58, 241, 2, 211, 14, 12)]
  internal interface IKeyAttestationHelperStatics
  {
    [Overload("DecryptTpmAttestationCredentialAsync")]
    [RemoteAsync]
    IAsyncOperation<string> DecryptTpmAttestationCredentialAsync(string credential);

    string GetTpmAttestationCredentialId(string credential);
  }
}
