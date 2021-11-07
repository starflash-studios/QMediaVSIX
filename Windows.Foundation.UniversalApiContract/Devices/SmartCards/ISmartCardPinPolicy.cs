// Decompiled with JetBrains decompiler
// Type: Windows.Devices.SmartCards.ISmartCardPinPolicy
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.SmartCards
{
  [Guid(406643076, 19894, 18497, 172, 158, 42, 193, 243, 155, 115, 4)]
  [ExclusiveTo(typeof (SmartCardPinPolicy))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface ISmartCardPinPolicy
  {
    uint MinLength { get; set; }

    uint MaxLength { get; set; }

    SmartCardPinCharacterPolicyOption UppercaseLetters { get; set; }

    SmartCardPinCharacterPolicyOption LowercaseLetters { get; set; }

    SmartCardPinCharacterPolicyOption Digits { get; set; }

    SmartCardPinCharacterPolicyOption SpecialCharacters { get; set; }
  }
}
