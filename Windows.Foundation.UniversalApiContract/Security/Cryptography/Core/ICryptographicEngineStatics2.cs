// Decompiled with JetBrains decompiler
// Type: Windows.Security.Cryptography.Core.ICryptographicEngineStatics2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Security.Cryptography.Core
{
  [ExclusiveTo(typeof (CryptographicEngine))]
  [Guid(1733904638, 57247, 16785, 146, 199, 108, 230, 245, 132, 32, 224)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface ICryptographicEngineStatics2
  {
    IBuffer SignHashedData(CryptographicKey key, IBuffer data);

    bool VerifySignatureWithHashInput(CryptographicKey key, IBuffer data, IBuffer signature);

    [RemoteAsync]
    IAsyncOperation<IBuffer> DecryptAsync(
      CryptographicKey key,
      IBuffer data,
      IBuffer iv);

    [RemoteAsync]
    IAsyncOperation<IBuffer> SignAsync(CryptographicKey key, IBuffer data);

    [RemoteAsync]
    IAsyncOperation<IBuffer> SignHashedDataAsync(
      CryptographicKey key,
      IBuffer data);
  }
}
