// Decompiled with JetBrains decompiler
// Type: Windows.Globalization.PhoneNumberFormatting.IPhoneNumberInfoStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Globalization.PhoneNumberFormatting
{
  [ExclusiveTo(typeof (PhoneNumberInfo))]
  [Guid(1530875754, 34473, 16617, 134, 73, 109, 97, 22, 25, 40, 212)]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  internal interface IPhoneNumberInfoStatics
  {
    [Overload("TryParse")]
    PhoneNumberParseResult TryParse(
      string input,
      out PhoneNumberInfo phoneNumber);

    [Overload("TryParseWithRegion")]
    PhoneNumberParseResult TryParse(
      string input,
      string regionCode,
      out PhoneNumberInfo phoneNumber);
  }
}
