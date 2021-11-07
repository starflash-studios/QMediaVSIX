// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Sms.SmsEncoding
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Sms
{
  /// <summary>This enumerated type is used to determine the encoding algorithm to send or calculate the length of an SmsTextMessage object.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum SmsEncoding
  {
    /// <summary>The data encoding is unknown.</summary>
    Unknown,
    /// <summary>7-bit encoding if all characters can be represented, otherwise 2-byte Universal Character Set (UCS-2) encoding.</summary>
    Optimal,
    /// <summary>Seven-bit ASCII encoding.</summary>
    SevenBitAscii,
    /// <summary>Unicode encoding.</summary>
    Unicode,
    /// <summary>Standard 7-bit GSM encoding.</summary>
    GsmSevenBit,
    /// <summary>Standard eight bit encoding.</summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] EightBit,
    /// <summary>Latin encoding.</summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] Latin,
    /// <summary>Korean encoding.</summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] Korean,
    /// <summary>IA5 encoding.</summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] IA5,
    /// <summary>Shift-JIS encoding for the Japanese language.</summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] ShiftJis,
    /// <summary>Latin Hebrew encoding.</summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] LatinHebrew,
  }
}
