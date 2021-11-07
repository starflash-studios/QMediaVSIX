// Decompiled with JetBrains decompiler
// Type: Windows.Globalization.PhoneNumberFormatting.PhoneNumberInfo
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Globalization.PhoneNumberFormatting
{
  /// <summary>Information about a phone number.</summary>
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [Static(typeof (IPhoneNumberInfoStatics), 196608, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Activatable(typeof (IPhoneNumberInfoFactory), 196608, "Windows.Foundation.UniversalApiContract")]
  public sealed class PhoneNumberInfo : IPhoneNumberInfo, IStringable
  {
    /// <summary>Constructor.</summary>
    /// <param name="number">A phone number that the created object will encapsulate.</param>
    [MethodImpl]
    public extern PhoneNumberInfo(string number);

    /// <summary>Gets the two-letter country code for this phone number.</summary>
    /// <returns>A country code.</returns>
    public extern int CountryCode { [MethodImpl] get; }

    /// <summary>Gets the phone number.</summary>
    /// <returns>The phone number.</returns>
    public extern string PhoneNumber { [MethodImpl] get; }

    /// <summary>Gets the length in characters of the geographical area code.</summary>
    /// <returns>Length, in characters, of the area code.</returns>
    [MethodImpl]
    public extern int GetLengthOfGeographicalAreaCode();

    /// <summary>Gets the national significant number of this object.</summary>
    /// <returns>The national significant number.</returns>
    [MethodImpl]
    public extern string GetNationalSignificantNumber();

    /// <summary>Gets the length, in characters, of the national destination code.</summary>
    /// <returns>The length of the national destination code.</returns>
    [MethodImpl]
    public extern int GetLengthOfNationalDestinationCode();

    /// <summary>Heuristically predicts what kind of number is represented in this object.</summary>
    /// <returns>An enumeration value describing the kind of phone number this object represents.</returns>
    [MethodImpl]
    public extern PredictedPhoneNumberKind PredictNumberKind();

    /// <summary>Gets the geographic region code for this number.</summary>
    /// <returns>A string representing the geographic region code.</returns>
    [MethodImpl]
    public extern string GetGeographicRegionCode();

    /// <summary>Compares two PhoneNumberInfo objects.</summary>
    /// <param name="otherNumber">The number to be compared to this object.</param>
    /// <returns>An enumeration value describing the result of the comparison.</returns>
    [MethodImpl]
    public extern PhoneNumberMatchResult CheckNumberMatch(
      PhoneNumberInfo otherNumber);

    /// <summary>Renders the phone number as a string.</summary>
    /// <returns>The number, rendered as a string.</returns>
    [MethodImpl]
    public new extern string ToString();

    /// <summary>Static method that attempts to parse a given input string as a phone number, and creates a PhoneNumberInfo encapsulating it.</summary>
    /// <param name="input">A phone number, in string form.</param>
    /// <param name="phoneNumber">On success, this object encapsulates the given phone number.</param>
    /// <returns>An enumeration value giving details of the attempt to parse *input*.</returns>
    [Overload("TryParse")]
    [MethodImpl]
    public static extern PhoneNumberParseResult TryParse(
      string input,
      out PhoneNumberInfo phoneNumber);

    /// <summary>Static method that attempts to parse a given input string as a phone number (using a given region code) and creates a PhoneNumberInfo encapsulating it.</summary>
    /// <param name="input">A phone number, in string form.</param>
    /// <param name="regionCode">The two-letter region code to be used to parse *input*. Region codes should use upper-case letters.</param>
    /// <param name="phoneNumber">On success, this object encapsulates the given phone number.</param>
    /// <returns>An enumeration value giving details of the attempt to parse *input*.</returns>
    [Overload("TryParseWithRegion")]
    [MethodImpl]
    public static extern PhoneNumberParseResult TryParse(
      string input,
      string regionCode,
      out PhoneNumberInfo phoneNumber);
  }
}
