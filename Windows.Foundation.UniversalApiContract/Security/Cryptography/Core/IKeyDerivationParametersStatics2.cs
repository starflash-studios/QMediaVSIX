// Decompiled with JetBrains decompiler
// Type: Windows.Security.Cryptography.Core.IKeyDerivationParametersStatics2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Security.Cryptography.Core
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (KeyDerivationParameters))]
  [Guid(2776120789, 22755, 20219, 178, 131, 161, 101, 49, 38, 225, 190)]
  internal interface IKeyDerivationParametersStatics2
  {
    KeyDerivationParameters BuildForCapi1Kdf(
      Capi1KdfTargetAlgorithm capi1KdfTargetAlgorithm);
  }
}
