// Decompiled with JetBrains decompiler
// Type: Windows.Security.Cryptography.Core.IHashAlgorithmProviderStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Security.Cryptography.Core
{
  [Guid(2678888257, 23748, 17206, 174, 56, 98, 18, 183, 90, 145, 90)]
  [ExclusiveTo(typeof (HashAlgorithmProvider))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IHashAlgorithmProviderStatics
  {
    HashAlgorithmProvider OpenAlgorithm(string algorithm);
  }
}
