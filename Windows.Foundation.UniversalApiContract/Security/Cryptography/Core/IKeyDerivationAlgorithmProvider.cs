// Decompiled with JetBrains decompiler
// Type: Windows.Security.Cryptography.Core.IKeyDerivationAlgorithmProvider
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Security.Cryptography.Core
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (KeyDerivationAlgorithmProvider))]
  [Guid(3791366203, 18033, 17335, 145, 88, 118, 58, 170, 152, 182, 191)]
  internal interface IKeyDerivationAlgorithmProvider
  {
    string AlgorithmName { get; }

    CryptographicKey CreateKey(IBuffer keyMaterial);
  }
}
