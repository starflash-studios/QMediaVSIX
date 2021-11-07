// Decompiled with JetBrains decompiler
// Type: Windows.Globalization.PhoneNumberFormatting.PhoneNumberFormat
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Globalization.PhoneNumberFormatting
{
  /// <summary>Lists phone number formats supported by this API.</summary>
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  public enum PhoneNumberFormat
  {
    /// <summary>Format specified in International Telecommunication Union (ITU-T) recommendation E.164.</summary>
    E164,
    /// <summary>International format as specified in ITU-T recommendation E.123.</summary>
    International,
    /// <summary>National format as specified in ITU-T recommendation E.123.</summary>
    National,
    /// <summary>Format specified in RFC 3966, the `tel:` URI for telephone numbers.</summary>
    Rfc3966,
  }
}
