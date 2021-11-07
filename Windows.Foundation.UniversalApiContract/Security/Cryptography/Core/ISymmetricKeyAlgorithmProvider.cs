// Decompiled with JetBrains decompiler
// Type: Windows.Security.Cryptography.Core.ISymmetricKeyAlgorithmProvider
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Security.Cryptography.Core
{
  [ExclusiveTo(typeof (SymmetricKeyAlgorithmProvider))]
  [Guid(1031686707, 15312, 18690, 138, 200, 71, 13, 80, 210, 19, 118)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface ISymmetricKeyAlgorithmProvider
  {
    string AlgorithmName { get; }

    uint BlockLength { get; }

    CryptographicKey CreateSymmetricKey(IBuffer keyMaterial);
  }
}
