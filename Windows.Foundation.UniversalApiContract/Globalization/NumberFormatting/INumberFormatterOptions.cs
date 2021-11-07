// Decompiled with JetBrains decompiler
// Type: Windows.Globalization.NumberFormatting.INumberFormatterOptions
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Globalization.NumberFormatting
{
  /// <summary>An interface that gets and sets options for formatting numbers.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(2150837537, 44769, 19001, 186, 162, 7, 237, 140, 150, 218, 246)]
  public interface INumberFormatterOptions
  {
    /// <summary>Gets the priority list of language identifiers that is used when formatting and parsing numbers.</summary>
    /// <returns>The priority list of language identifiers.</returns>
    IVectorView<string> Languages { get; }

    /// <summary>Gets the region that is used when formatting and parsing numbers.</summary>
    /// <returns>The region that is used.</returns>
    string GeographicRegion { get; }

    /// <summary>Gets or sets the minimum number of digits to display for the integer part of the number.</summary>
    /// <returns>The minimum number of digits to display.</returns>
    int IntegerDigits { get; set; }

    /// <summary>Gets or sets the minimum number of digits to display for the fraction part of the number.</summary>
    /// <returns>The minimum number of digits to display.</returns>
    int FractionDigits { get; set; }

    /// <summary>Gets or sets whether the integer part of the number should be grouped.</summary>
    /// <returns>**True** if the integer part of the number should be grouped, and **false** otherwise.</returns>
    bool IsGrouped { get; set; }

    /// <summary>Gets or sets whether the decimal point of the number should always be displayed.</summary>
    /// <returns>**True** if the decimal point of the number should always be displayed, and **false** otherwise.</returns>
    bool IsDecimalPointAlwaysDisplayed { get; set; }

    /// <summary>Gets or sets the numbering system that is used to format and parse numbers.</summary>
    /// <returns>A string that indicates the numeral system of the formatter, such as "Latn" for the Latin numeral system (0123456789) or "Arab" for the Arabic-Indic numeral system (٠١٢٣٤٥٦٧٨٩). See the supported [NumeralSystem values](https://docs.microsoft.com/previous-versions/windows/apps/jj236471(v=win.10)).</returns>
    string NumeralSystem { get; set; }

    /// <summary>Gets the language that was most recently used to format or parse numbers.</summary>
    /// <returns>The language from the priority list of language identifiers that was most recently used to format or parse numbers.</returns>
    string ResolvedLanguage { get; }

    /// <summary>Gets the geographic region that was most recently used to format or parse numbers.</summary>
    /// <returns>The geographic region that was most recently used to format or parse numbers.</returns>
    string ResolvedGeographicRegion { get; }
  }
}
