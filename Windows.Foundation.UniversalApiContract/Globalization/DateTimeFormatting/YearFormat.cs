// Decompiled with JetBrains decompiler
// Type: Windows.Globalization.DateTimeFormatting.YearFormat
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Globalization.DateTimeFormatting
{
  /// <summary>Specifies the intended format for the year in a DateTimeFormatter object.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum YearFormat
  {
    /// <summary>Do not display the year.</summary>
    None,
    /// <summary>Display the year in the most natural way. It may be abbreviated or full depending on the context, such as the language or calendar that is being used.</summary>
    Default,
    /// <summary>Display an abbreviated version of the year (for example, "11" for Gregorian 2011).</summary>
    Abbreviated,
    /// <summary>Display the year in its entirety (for example, "2011" for Gregorian 2011).</summary>
    Full,
  }
}
