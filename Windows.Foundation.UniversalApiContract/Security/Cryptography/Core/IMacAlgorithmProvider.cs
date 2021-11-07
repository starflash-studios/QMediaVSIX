// Decompiled with JetBrains decompiler
// Type: Windows.Security.Cryptography.Core.IMacAlgorithmProvider
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Security.Cryptography.Core
{
  [Guid(1245693379, 7357, 16846, 160, 146, 170, 11, 197, 210, 210, 245)]
  [ExclusiveTo(typeof (MacAlgorithmProvider))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IMacAlgorithmProvider
  {
    string AlgorithmName { get; }

    uint MacLength { get; }

    CryptographicKey CreateKey(IBuffer keyMaterial);
  }
}
