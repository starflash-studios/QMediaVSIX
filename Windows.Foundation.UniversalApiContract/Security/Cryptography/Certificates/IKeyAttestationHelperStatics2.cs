// Decompiled with JetBrains decompiler
// Type: Windows.Security.Cryptography.Certificates.IKeyAttestationHelperStatics2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Security.Cryptography.Certificates
{
  [ExclusiveTo(typeof (KeyAttestationHelper))]
  [Guid(2623081260, 42694, 19038, 158, 100, 232, 93, 82, 121, 223, 151)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IKeyAttestationHelperStatics2
  {
    [RemoteAsync]
    [Overload("DecryptTpmAttestationCredentialWithContainerNameAsync")]
    IAsyncOperation<string> DecryptTpmAttestationCredentialAsync(
      string credential,
      string containerName);
  }
}
