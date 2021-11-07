// Decompiled with JetBrains decompiler
// Type: Windows.Globalization.PhoneNumberFormatting.PredictedPhoneNumberKind
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Globalization.PhoneNumberFormatting
{
  /// <summary>The kinds of phone numbers returned by PhoneNumberInfo.PredictNumberKind.</summary>
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  public enum PredictedPhoneNumberKind
  {
    /// <summary>A fixed telephone line.</summary>
    FixedLine,
    /// <summary>A mobile line.</summary>
    Mobile,
    /// <summary>Either a fixed line or a mobile line.</summary>
    FixedLineOrMobile,
    /// <summary>A toll-free number.</summary>
    TollFree,
    /// <summary>A number that charges a premium rate to connect.</summary>
    PremiumRate,
    /// <summary>A shared-cost service (caller pays part of the cost, recipient pays the rest.)</summary>
    SharedCost,
    /// <summary>A VOIP (Voice over IP) line.</summary>
    Voip,
    /// <summary>A number that reaches a private individual.</summary>
    PersonalNumber,
    /// <summary>A number that reaches a pager.</summary>
    Pager,
    /// <summary>A category that includes national services and corporate, institutional, or private network access numbers.</summary>
    UniversalAccountNumber,
    /// <summary>A number that reaches a voicemail service.</summary>
    Voicemail,
    /// <summary>A number that is none of the other kinds in this enumeration, or whose precise kind is not known.</summary>
    Unknown,
  }
}
