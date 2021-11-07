// Decompiled with JetBrains decompiler
// Type: Windows.Globalization.PhoneNumberFormatting.IPhoneNumberInfo
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Globalization.PhoneNumberFormatting
{
  [Guid(477947101, 51380, 20131, 154, 239, 179, 66, 226, 197, 180, 23)]
  [ExclusiveTo(typeof (PhoneNumberInfo))]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  internal interface IPhoneNumberInfo
  {
    int CountryCode { get; }

    string PhoneNumber { get; }

    int GetLengthOfGeographicalAreaCode();

    string GetNationalSignificantNumber();

    int GetLengthOfNationalDestinationCode();

    PredictedPhoneNumberKind PredictNumberKind();

    string GetGeographicRegionCode();

    PhoneNumberMatchResult CheckNumberMatch(PhoneNumberInfo otherNumber);
  }
}
