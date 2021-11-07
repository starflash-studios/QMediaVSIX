// Decompiled with JetBrains decompiler
// Type: Windows.Security.Cryptography.Core.ICryptographicKey
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Security.Cryptography.Core
{
  [Guid(3978967920, 36475, 16393, 132, 1, 255, 209, 166, 46, 235, 39)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (CryptographicKey))]
  internal interface ICryptographicKey
  {
    uint KeySize { get; }

    [Overload("ExportDefaultPrivateKeyBlobType")]
    IBuffer Export();

    [Overload("ExportPrivateKeyWithBlobType")]
    IBuffer Export(CryptographicPrivateKeyBlobType BlobType);

    [Overload("ExportDefaultPublicKeyBlobType")]
    IBuffer ExportPublicKey();

    [Overload("ExportPublicKeyWithBlobType")]
    IBuffer ExportPublicKey(CryptographicPublicKeyBlobType BlobType);
  }
}
