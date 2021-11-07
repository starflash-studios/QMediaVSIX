// Decompiled with JetBrains decompiler
// Type: Windows.Globalization.PhoneNumberFormatting.IPhoneNumberFormatterStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Globalization.PhoneNumberFormatting
{
  [ExclusiveTo(typeof (PhoneNumberFormatter))]
  [Guid(1554446641, 34009, 16715, 171, 78, 160, 85, 44, 135, 134, 2)]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  internal interface IPhoneNumberFormatterStatics
  {
    void TryCreate(string regionCode, out PhoneNumberFormatter phoneNumber);

    int GetCountryCodeForRegion(string regionCode);

    string GetNationalDirectDialingPrefixForRegion(string regionCode, bool stripNonDigit);

    string WrapWithLeftToRightMarkers(string number);
  }
}
