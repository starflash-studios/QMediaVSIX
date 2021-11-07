// Decompiled with JetBrains decompiler
// Type: Windows.Globalization.PhoneNumberFormatting.PhoneNumberFormatter
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Globalization.PhoneNumberFormatting
{
  /// <summary>Formats phone numbers.</summary>
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Static(typeof (IPhoneNumberFormatterStatics), 196608, "Windows.Foundation.UniversalApiContract")]
  [Activatable(196608, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  public sealed class PhoneNumberFormatter : IPhoneNumberFormatter
  {
    /// <summary>Creates a PhoneNumberFormatter object, using the current default region.</summary>
    [MethodImpl]
    public extern PhoneNumberFormatter();

    /// <summary>Returns a string representation of the provided phone number.</summary>
    /// <param name="number">The phone number to be formatted. The PhoneNumberInfo specifies not just the subscriber number, but also other relevant information such as country code.</param>
    /// <returns>A string containing the formatted phone number, using the default format for the region specified when this PhoneNumberFormatter was created.</returns>
    [Overload("Format")]
    [MethodImpl]
    public extern string Format(PhoneNumberInfo number);

    /// <summary>Returns a string representing the given phone number, using the given format.</summary>
    /// <param name="number">The phone number to be formatted. The PhoneNumberInfo specifies not just the subscriber number, but also other relevant information such as country code.</param>
    /// <param name="numberFormat">The specific format to be used.</param>
    /// <returns>A string containing the phone number, in the specified format.</returns>
    [Overload("FormatWithOutputFormat")]
    [MethodImpl]
    public extern string Format(PhoneNumberInfo number, PhoneNumberFormat numberFormat);

    /// <summary>Returns a string representing the formatted partial phone number given.</summary>
    /// <param name="number">A string representing a partial phone number.</param>
    /// <returns>The input string, formatted as a partial phone number.</returns>
    [MethodImpl]
    public extern string FormatPartialString(string number);

    /// <summary>Returns the input string, formatted as a phone number.</summary>
    /// <param name="number">The input string to be formatted.</param>
    /// <returns>The input string, formatted as a phone number, using the region specified when this PhoneNumberFormatter was created.</returns>
    [MethodImpl]
    public extern string FormatString(string number);

    /// <summary>Returns the input string, formatted as a phone number, surrounded by Unicode Left to Right (LTR) markers.</summary>
    /// <param name="number">The input string to be formatted.</param>
    /// <returns>The input string, formatted as a phone number, using the region specified when this PhoneNumberFormatter was created. The string is surrounded by Unicode Left to Right (LTR) markers.</returns>
    [MethodImpl]
    public extern string FormatStringWithLeftToRightMarkers(string number);

    /// <summary>Attempts to create a PhoneNumberFormatter for a given region code, and doesn't throw on failure.</summary>
    /// <param name="regionCode">The region code of the new PhoneNumberFormatter.</param>
    /// <param name="phoneNumber">On success, a new PhoneNumberFormatter for the requested region code.</param>
    [MethodImpl]
    public static extern void TryCreate(string regionCode, out PhoneNumberFormatter phoneNumber);

    /// <summary>Static method that returns the country code for a given region code.</summary>
    /// <param name="regionCode">The two-letter ISO region code.</param>
    /// <returns>The telephone country code, as an integer.</returns>
    [MethodImpl]
    public static extern int GetCountryCodeForRegion(string regionCode);

    /// <summary>Static method that returns the national direct dialing prefix for the given region.</summary>
    /// <param name="regionCode">The region code of interest.</param>
    /// <param name="stripNonDigit">When **true**, all non-digit characters are stripped from the returned string.</param>
    /// <returns>The national direct dialing prefix for the given region.</returns>
    [MethodImpl]
    public static extern string GetNationalDirectDialingPrefixForRegion(
      string regionCode,
      bool stripNonDigit);

    /// <summary>Wraps a string with Unicode Left to Right (LTR) markers.</summary>
    /// <param name="number">The string to be surrounded with LTR markers.</param>
    /// <returns>The input string, surrounded with LTR markers.</returns>
    [MethodImpl]
    public static extern string WrapWithLeftToRightMarkers(string number);
  }
}
