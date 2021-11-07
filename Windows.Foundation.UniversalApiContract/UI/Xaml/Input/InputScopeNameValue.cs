// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Input.InputScopeNameValue
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Input
{
  /// <summary>Specifies a particular named input mode (InputScopeName ) used to populate an InputScope.</summary>
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum InputScopeNameValue
  {
    /// <summary>No input scope is applied.</summary>
    Default = 0,
    /// <summary>Indicates a Uniform Resource Identifier (URI). This can include URL, File, or File Transfer Protocol (FTP) formats.</summary>
    Url = 1,
    /// <summary>Input scope is intended for working with a Simple Mail Transport Protocol (SMTP) form e-mail address (accountnamehost).</summary>
    EmailSmtpAddress = 5,
    /// <summary>Input scope is intended for working with a complete personal name.</summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] PersonalFullName = 7,
    /// <summary>Input scope is intended for working with amount and symbol of currency.</summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] CurrencyAmountAndSymbol = 20, // 0x00000014
    /// <summary>Input scope is intended for working with a currency amount (no currency symbol).</summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] CurrencyAmount = 21, // 0x00000015
    /// <summary>Input scope is intended for working with a numeric month of the year.</summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] DateMonthNumber = 23, // 0x00000017
    /// <summary>Input scope is intended for working with a numeric day of the month.</summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] DateDayNumber = 24, // 0x00000018
    /// <summary>Input scope is intended for working with a numeric year.</summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] DateYear = 25, // 0x00000019
    /// <summary>Input scope is intended for working with a collection of numbers.</summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] Digits = 28, // 0x0000001C
    /// <summary>Input scope is intended for working with digits 0-9.</summary>
    Number = 29, // 0x0000001D
    /// <summary>Input scope is intended for working with an alphanumeric password, including other symbols, such as punctuation and mathematical symbols.</summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] Password = 31, // 0x0000001F
    /// <summary>Input scope is intended for working with telephone numbers.</summary>
    TelephoneNumber = 32, // 0x00000020
    /// <summary>Input scope is intended for working with a numeric telephone country code.</summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] TelephoneCountryCode = 33, // 0x00000021
    /// <summary>Input scope is intended for working with a numeric telephone area code.</summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] TelephoneAreaCode = 34, // 0x00000022
    /// <summary>Input scope is intended for working with a local telephone number.</summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] TelephoneLocalNumber = 35, // 0x00000023
    /// <summary>Input scope is intended for working with a numeric hour of the day.</summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] TimeHour = 37, // 0x00000025
    /// <summary>Input scope is intended for working with a numeric minute of the hour, or second of the minute.</summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] TimeMinutesOrSeconds = 38, // 0x00000026
    /// <summary>Input scope is intended for full-width number characters.</summary>
    NumberFullWidth = 39, // 0x00000027
    /// <summary>Input scope is intended for alphanumeric half-width characters.</summary>
    AlphanumericHalfWidth = 40, // 0x00000028
    /// <summary>Input scope is intended for alphanumeric full-width characters.</summary>
    AlphanumericFullWidth = 41, // 0x00000029
    /// <summary>Input scope is intended for Hiragana characters.</summary>
    Hiragana = 44, // 0x0000002C
    /// <summary>Input scope is intended for Katakana half-width characters.</summary>
    KatakanaHalfWidth = 45, // 0x0000002D
    /// <summary>Input scope is intended for Katakana full-width characters.</summary>
    KatakanaFullWidth = 46, // 0x0000002E
    /// <summary>Input scope is intended for Hanja characters.</summary>
    Hanja = 47, // 0x0000002F
    /// <summary>Input scope is intended for Hangul half-width characters.</summary>
    HangulHalfWidth = 48, // 0x00000030
    /// <summary>Input scope is intended for Hangul full-width characters.</summary>
    HangulFullWidth = 49, // 0x00000031
    /// <summary>Input scope is intended for search strings.</summary>
    Search = 50, // 0x00000032
    /// <summary>Input scope is intended for spreadsheet formula strings.</summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] Formula = 51, // 0x00000033
    /// <summary>Input scope is intended for search boxes where incremental results are displayed as the user types.</summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] SearchIncremental = 52, // 0x00000034
    /// <summary>Input scope is intended for Chinese half-width characters.</summary>
    ChineseHalfWidth = 53, // 0x00000035
    /// <summary>Input scope is intended for Chinese full-width characters.</summary>
    ChineseFullWidth = 54, // 0x00000036
    /// <summary>Input scope is intended for native script.</summary>
    NativeScript = 55, // 0x00000037
    /// <summary>Input scope is intended for working with text.</summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] Text = 57, // 0x00000039
    /// <summary>Input scope is intended for chat strings.</summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] Chat = 58, // 0x0000003A
    /// <summary>Input scope is intended for working with a name or telephone number.</summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] NameOrPhoneNumber = 59, // 0x0000003B
    /// <summary>Input scope is intended for working with an email, name, or address.</summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] EmailNameOrAddress = 60, // 0x0000003C
    [ContractVersion("Windows.Foundation.UniversalApiContract", 720896)] Private = 61, // 0x0000003D
    /// <summary>Input scope is intended for working with a map location.</summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] Maps = 62, // 0x0000003E
    /// <summary>Expected input is a numeric password, or PIN.</summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] NumericPassword = 63, // 0x0000003F
    /// <summary>Expected input is a numeric PIN.</summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] NumericPin = 64, // 0x00000040
    /// <summary>Expected input is an alphanumeric PIN.</summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] AlphanumericPin = 65, // 0x00000041
    /// <summary>Expected input is a mathematical formula. Advises input processors to show the number page.</summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] FormulaNumber = 67, // 0x00000043
    /// <summary>Expected input does not include emoji. Advises input processors to not show the emoji key.</summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 196608)] ChatWithoutEmoji = 68, // 0x00000044
  }
}
