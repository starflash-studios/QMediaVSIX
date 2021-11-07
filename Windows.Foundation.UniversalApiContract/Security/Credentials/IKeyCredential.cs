// Decompiled with JetBrains decompiler
// Type: Windows.Security.Credentials.IKeyCredential
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Security.Cryptography.Core;
using Windows.Storage.Streams;

namespace Windows.Security.Credentials
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (KeyCredential))]
  [Guid(2508582797, 17787, 18503, 177, 26, 250, 150, 11, 189, 177, 56)]
  internal interface IKeyCredential
  {
    string Name { get; }

    [Overload("RetrievePublicKeyWithDefaultBlobType")]
    IBuffer RetrievePublicKey();

    [Overload("RetrievePublicKeyWithBlobType")]
    IBuffer RetrievePublicKey(CryptographicPublicKeyBlobType blobType);

    IAsyncOperation<KeyCredentialOperationResult> RequestSignAsync(
      IBuffer data);

    IAsyncOperation<KeyCredentialAttestationResult> GetAttestationAsync();
  }
}
