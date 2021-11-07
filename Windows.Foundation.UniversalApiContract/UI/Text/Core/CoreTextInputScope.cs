// Decompiled with JetBrains decompiler
// Type: Windows.UI.Text.Core.CoreTextInputScope
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Text.Core
{
  /// <summary>Defines constants that specify the set of input scope names. Input scope is used by the text input server and input processors to determine the layout of the Soft Input Panel (SIP), and what type of language model to use.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum CoreTextInputScope
  {
    /// <summary>No input scope is applied.</summary>
    Default = 0,
    /// <summary>Expected input is a URL.</summary>
    Url = 1,
    /// <summary>Expected input is characters used in describing a file path.</summary>
    FilePath = 2,
    /// <summary>Expected input is characters used in describing a file name.</summary>
    FileName = 3,
    /// <summary>Expected input is the account name portion of an email address.</summary>
    EmailUserName = 4,
    /// <summary>Expected input is an SMTP form email address (&lt;accountname&gt;&lt;host&gt;).</summary>
    EmailAddress = 5,
    /// <summary>Expected input is a log-in name and a domain (&lt;accountname&gt; or &lt;domain&gt;\&lt;accountname&gt;).</summary>
    UserName = 6,
    /// <summary>Expected input is a person’s full name, including prefix, given name, middle name, surname, and suffix.</summary>
    PersonalFullName = 7,
    /// <summary>Expected input is the prefix portion of a person’s full name. (For example, "Mr.")</summary>
    PersonalNamePrefix = 8,
    /// <summary>Expected input is the given (or first) name portion of a person’s full name.</summary>
    PersonalGivenName = 9,
    /// <summary>Expected input is the middle name portion of a person’s full name.</summary>
    PersonalMiddleName = 10, // 0x0000000A
    /// <summary>Expected input is the family (or last) name portion of a person’s full name.</summary>
    PersonalSurname = 11, // 0x0000000B
    /// <summary>Expected input is the suffix portion of a person’s full name. (For example, "Jr.")</summary>
    PersonalNameSuffix = 12, // 0x0000000C
    /// <summary>Expected input is a full postal address. (For example, "One Microsoft Way, Redmond, WA 98052, U.S.A.")</summary>
    Address = 13, // 0x0000000D
    /// <summary>Expected input is the postal code (or zip code) portion a full address. (For example, "98052".)</summary>
    AddressPostalCode = 14, // 0x0000000E
    /// <summary>Expected input is the street portion a full address. (For example, "Microsoft Way".)</summary>
    AddressStreet = 15, // 0x0000000F
    /// <summary>Expected input is the state or province portion a full address. (For example, "WA".)</summary>
    AddressStateOrProvince = 16, // 0x00000010
    /// <summary>Expected input is the city portion a full address. (For example, "Redmond".)</summary>
    AddressCity = 17, // 0x00000011
    /// <summary>Expected input is the country name portion a full address. (For example, "United States of America".)</summary>
    AddressCountryName = 18, // 0x00000012
    /// <summary>Expected input is the country abbreviation portion a full address. (For example, "U.S.A.")</summary>
    AddressCountryShortName = 19, // 0x00000013
    /// <summary>Expected input is an amount of currency and a currency symbol.</summary>
    CurrencyAmountAndSymbol = 20, // 0x00000014
    /// <summary>Expected input is an amount of currency.</summary>
    CurrencyAmount = 21, // 0x00000015
    /// <summary>Expected input is a calendar date.</summary>
    Date = 22, // 0x00000016
    /// <summary>Expected input is the numeric month portion of a calendar date.</summary>
    DateMonth = 23, // 0x00000017
    /// <summary>Expected input is the numeric day portion of a calendar date.</summary>
    DateDay = 24, // 0x00000018
    /// <summary>Expected input is the year portion of a calendar date.</summary>
    DateYear = 25, // 0x00000019
    /// <summary>Expected input is the alphabetic name of the month from a calendar date.</summary>
    DateMonthName = 26, // 0x0000001A
    /// <summary>Expected input is the alphabetic name of the day from a calendar date.</summary>
    DateDayName = 27, // 0x0000001B
    /// <summary>Expected input includes positive whole numbers, constrained to 0-9.</summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 327680)] Digits = 28, // 0x0000001C
    /// <summary>Expected input includes the digits 0-9, decimal separators, place separators, and negative sign. The exact characters used for  decimal separators, place separators, and negative sign, depend on the user’s regional settings.</summary>
    Number = 29, // 0x0000001D
    /// <summary>Expected input is a single ANSI character, codepage 1252.</summary>
    SingleCharacter = 30, // 0x0000001E
    /// <summary>Expected input is a password.</summary>
    Password = 31, // 0x0000001F
    /// <summary>Expected input is a full telephone number. (For example, "1(800)555-5555".)</summary>
    TelephoneNumber = 32, // 0x00000020
    /// <summary>Expected input is the country code portion of a full telephone number. (For example, "1".)</summary>
    TelephoneCountryCode = 33, // 0x00000021
    /// <summary>Expected input is the area code portion of a full telephone number. (For example, "(800)".)</summary>
    TelephoneAreaCode = 34, // 0x00000022
    /// <summary>Expected input is the local number portion of a full telephone number. (For example, "555-5555".)</summary>
    TelephoneLocalNumber = 35, // 0x00000023
    /// <summary>Expected input is a time value.</summary>
    Time = 36, // 0x00000024
    /// <summary>Expected input is the hour portion of a time value.</summary>
    TimeHour = 37, // 0x00000025
    /// <summary>Expected input is the minute or second portion of a time value.</summary>
    TimeMinuteOrSecond = 38, // 0x00000026
    /// <summary>Expected input is full-width number characters.</summary>
    NumberFullWidth = 39, // 0x00000027
    /// <summary>Expected input is half-width alphanumeric characters.</summary>
    AlphanumericHalfWidth = 40, // 0x00000028
    /// <summary>Expected input is full-width alphanumeric characters.</summary>
    AlphanumericFullWidth = 41, // 0x00000029
    /// <summary>Expected input is Chinese currency.</summary>
    CurrencyChinese = 42, // 0x0000002A
    /// <summary>Expected input is the Bopomofo Mandarin Chinese phonetic transcription system.</summary>
    Bopomofo = 43, // 0x0000002B
    /// <summary>Expected input is Hiragana characters.</summary>
    Hiragana = 44, // 0x0000002C
    /// <summary>Expected input is Katakana half-width characters.</summary>
    KatakanaHalfWidth = 45, // 0x0000002D
    /// <summary>Expected input is Katakana full-width characters.</summary>
    KatakanaFullWidth = 46, // 0x0000002E
    /// <summary>Expected input is Hanja characters.</summary>
    Hanja = 47, // 0x0000002F
    /// <summary>Expected input is Hangul half-width characters.</summary>
    HangulHalfWidth = 48, // 0x00000030
    /// <summary>Expected input is Hangul full-width characters.</summary>
    HangulFullWidth = 49, // 0x00000031
    /// <summary>Expected input is a search string.</summary>
    Search = 50, // 0x00000032
    /// <summary>Expected input is a mathematical formula.</summary>
    Formula = 51, // 0x00000033
    /// <summary>Expected input is a search string. Use for search boxes where incremental results are displayed as the user types.</summary>
    SearchIncremental = 52, // 0x00000034
    /// <summary>Expected input is Chinese half-width characters.</summary>
    ChineseHalfWidth = 53, // 0x00000035
    /// <summary>Expected input is Chinese full-width characters.</summary>
    ChineseFullWidth = 54, // 0x00000036
    /// <summary>Expected input is native script.</summary>
    NativeScript = 55, // 0x00000037
    /// <summary>Expected input is text; turns on typing intelligence.</summary>
    Text = 57, // 0x00000039
    /// <summary>Expected input is chat strings.</summary>
    Chat = 58, // 0x0000003A
    /// <summary>Expected input is a name or a telephone number.</summary>
    NameOrPhoneNumber = 59, // 0x0000003B
    /// <summary>Expected input is an email user name (\&lt;accountname&gt;) or full email address (\&lt;accountname&gt;\&lt;host&gt;).</summary>
    EmailUserNameOrAddress = 60, // 0x0000003C
    /// <summary>Expected input is private data. Advises input processors that the text should not be stored nor logged.</summary>
    Private = 61, // 0x0000003D
    /// <summary>Expected input is from the device's Maps layout; does not include typing intelligence.</summary>
    Maps = 62, // 0x0000003E
    /// <summary>Expected input is a numeric password, or PIN.</summary>
    PasswordNumeric = 63, // 0x0000003F
    /// <summary>Expected input is an numeric password, or PIN. Typically constrained to 5-6 digits.</summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 327680)] PinNumeric = 64, // 0x00000040
    /// <summary>Expected input is an alphanumeric password, or PIN. Typically constrained to 5-6 characters.</summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 327680)] PinAlphanumeric = 65, // 0x00000041
    /// <summary>Expected input is a mathematical formula. Advises input processors to show the number page.</summary>
    FormulaNumber = 67, // 0x00000043
    /// <summary>Expected input does not include emoji. Advises input processors to not display the emoji key.</summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 196608)] ChatWithoutEmoji = 68, // 0x00000044
  }
}
