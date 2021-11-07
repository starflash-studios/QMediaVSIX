// Decompiled with JetBrains decompiler
// Type: Windows.Globalization.PhoneNumberFormatting.PhoneNumberMatchResult
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Globalization.PhoneNumberFormatting
{
  /// <summary>The result of calling the PhoneNumberInfo.CheckNumberMatch method.</summary>
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  public enum PhoneNumberMatchResult
  {
    /// <summary>The two numbers do not match.</summary>
    NoMatch,
    /// <summary>The short national significant part (the subscriber number) of the two numbers match.</summary>
    ShortNationalSignificantNumberMatch,
    /// <summary>The entire national significant part (area code and subscriber number) of the two numbers match.</summary>
    NationalSignificantNumberMatch,
    /// <summary>The two numbers are an exact match.</summary>
    ExactMatch,
  }
}
