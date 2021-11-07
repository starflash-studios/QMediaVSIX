// Decompiled with JetBrains decompiler
// Type: Windows.Security.Cryptography.Core.IKeyDerivationParametersStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Security.Cryptography.Core
{
  [Guid(3935707070, 62335, 16710, 157, 254, 164, 86, 241, 115, 95, 75)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (KeyDerivationParameters))]
  internal interface IKeyDerivationParametersStatics
  {
    KeyDerivationParameters BuildForPbkdf2(
      IBuffer pbkdf2Salt,
      uint iterationCount);

    KeyDerivationParameters BuildForSP800108(IBuffer label, IBuffer context);

    KeyDerivationParameters BuildForSP80056a(
      IBuffer algorithmId,
      IBuffer partyUInfo,
      IBuffer partyVInfo,
      IBuffer suppPubInfo,
      IBuffer suppPrivInfo);
  }
}
