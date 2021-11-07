// Decompiled with JetBrains decompiler
// Type: Windows.Devices.SmartCards.SmartCardPinCharacterPolicyOption
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.SmartCards
{
  /// <summary>Specifies the rules for characters in a smart card personal identification number (PIN).</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum SmartCardPinCharacterPolicyOption
  {
    /// <summary>Any of the characters in the specified character class can be in the PIN.</summary>
    Allow,
    /// <summary>At least one of the characters in the specified character class must be in the PIN.</summary>
    RequireAtLeastOne,
    /// <summary>None of the characters in the specified character class can be in the PIN.</summary>
    Disallow,
  }
}
