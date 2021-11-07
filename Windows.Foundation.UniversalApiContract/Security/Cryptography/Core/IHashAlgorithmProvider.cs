// Decompiled with JetBrains decompiler
// Type: Windows.Security.Cryptography.Core.IHashAlgorithmProvider
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Security.Cryptography.Core
{
  [ExclusiveTo(typeof (HashAlgorithmProvider))]
  [Guid(3197841536, 45763, 16939, 188, 225, 236, 144, 239, 181, 215, 181)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IHashAlgorithmProvider
  {
    string AlgorithmName { get; }

    uint HashLength { get; }

    IBuffer HashData(IBuffer data);

    CryptographicHash CreateHash();
  }
}
