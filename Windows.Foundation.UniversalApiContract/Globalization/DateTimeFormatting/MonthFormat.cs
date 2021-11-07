// Decompiled with JetBrains decompiler
// Type: Windows.Globalization.DateTimeFormatting.MonthFormat
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Globalization.DateTimeFormatting
{
  /// <summary>Specifies the intended format for the month in a DateTimeFormatter object.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum MonthFormat
  {
    /// <summary>Do not display the month.</summary>
    None,
    /// <summary>Display the month in the most natural way. It may be abbreviated, full, or numeric depending on the context, such as the language or calendar that is being used.</summary>
    Default,
    /// <summary>Display an abbreviated version of the month (for example, "Sep" for September).</summary>
    Abbreviated,
    /// <summary>Display the month in its entirety (for example, "September").</summary>
    Full,
    /// <summary>Display the month as a number (for example, "9" for September).</summary>
    Numeric,
  }
}
