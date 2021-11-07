// Decompiled with JetBrains decompiler
// Type: Windows.Globalization.PhoneNumberFormatting.IPhoneNumberFormatter
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Globalization.PhoneNumberFormatting
{
  [ExclusiveTo(typeof (PhoneNumberFormatter))]
  [Guid(358003870, 47828, 19274, 144, 13, 68, 7, 173, 183, 201, 129)]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  internal interface IPhoneNumberFormatter
  {
    [Overload("Format")]
    string Format(PhoneNumberInfo number);

    [Overload("FormatWithOutputFormat")]
    string Format(PhoneNumberInfo number, PhoneNumberFormat numberFormat);

    string FormatPartialString(string number);

    string FormatString(string number);

    string FormatStringWithLeftToRightMarkers(string number);
  }
}
