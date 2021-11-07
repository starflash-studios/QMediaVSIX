// Decompiled with JetBrains decompiler
// Type: Windows.Security.Cryptography.Core.IKeyDerivationAlgorithmProviderStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Security.Cryptography.Core
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(170002810, 2588, 17467, 148, 24, 185, 73, 138, 235, 22, 3)]
  [ExclusiveTo(typeof (KeyDerivationAlgorithmProvider))]
  internal interface IKeyDerivationAlgorithmProviderStatics
  {
    KeyDerivationAlgorithmProvider OpenAlgorithm(string algorithm);
  }
}
