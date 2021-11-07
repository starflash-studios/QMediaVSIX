// Decompiled with JetBrains decompiler
// Type: Windows.Globalization.PhoneNumberFormatting.PhoneNumberParseResult
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Globalization.PhoneNumberFormatting
{
  /// <summary>Describes the results of trying to parse a string into a phone number.</summary>
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  public enum PhoneNumberParseResult
  {
    /// <summary>The prospective number has been parsed, and is valid.</summary>
    Valid,
    /// <summary>The prospective number is not valid.</summary>
    NotANumber,
    /// <summary>The prospective number has an invalid country code, and is not valid.</summary>
    InvalidCountryCode,
    /// <summary>The prospective number is too short, and is not valid.</summary>
    TooShort,
    /// <summary>The prospective number is too long, and is not valid.</summary>
    TooLong,
  }
}
