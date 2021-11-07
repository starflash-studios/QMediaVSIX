// Decompiled with JetBrains decompiler
// Type: Windows.Web.Http.Headers.HttpLanguageRangeWithQualityHeaderValue
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Web.Http.Headers
{
  /// <summary>Represents accept language information used in the **Accept-Language** HTTP header on an HTTP request.</summary>
  [DualApiPartition(version = 100859904)]
  [Static(typeof (IHttpLanguageRangeWithQualityHeaderValueStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Threading(ThreadingModel.Both)]
  [Activatable(typeof (IHttpLanguageRangeWithQualityHeaderValueFactory), 65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class HttpLanguageRangeWithQualityHeaderValue : 
    IHttpLanguageRangeWithQualityHeaderValue,
    IStringable
  {
    /// <summary>Initializes a new instance of the HttpLanguageRangeWithQualityHeaderValue class with language-range information.</summary>
    /// <param name="languageRange">The value of the **language-range** information used in the **Accept-Language** HTTP header.</param>
    [MethodImpl]
    public extern HttpLanguageRangeWithQualityHeaderValue(string languageRange);

    /// <summary>Initializes a new instance of the HttpLanguageRangeWithQualityHeaderValue class with language-range and quality information.</summary>
    /// <param name="languageRange">The value of the **language-range** information used in the **Accept-Language** HTTP header.</param>
    /// <param name="quality">The value of the **qvalue** or quality factor used in the **Accept-Language** HTTP header.</param>
    [MethodImpl]
    public extern HttpLanguageRangeWithQualityHeaderValue(string languageRange, double quality);

    /// <summary>Gets the value of the **language-range** information from the HttpLanguageRangeWithQualityHeaderValue used in the **Accept-Language** HTTP header.</summary>
    /// <returns>The value of the **language-range** information.</returns>
    public extern string LanguageRange { [MethodImpl] get; }

    /// <summary>Gets the value of the **qvalue** or quality factor from the HttpLanguageRangeWithQualityHeaderValue used in the **Accept-Language** HTTP header.</summary>
    /// <returns>The value of the **qvalue** or quality factor.</returns>
    public extern IReference<double> Quality { [MethodImpl] get; }

    /// <summary>Returns a string that represents the current HttpLanguageRangeWithQualityHeaderValue object.</summary>
    /// <returns>A string that represents the current object.</returns>
    [MethodImpl]
    public new extern string ToString();

    /// <summary>Converts a string to an HttpLanguageRangeWithQualityHeaderValue instance.</summary>
    /// <param name="input">A string that represents the language-range and quality factor information used in the **Accept-Encoding** HTTP header.</param>
    /// <returns>An HttpLanguageRangeWithQualityHeaderValue instance.</returns>
    [MethodImpl]
    public static extern HttpLanguageRangeWithQualityHeaderValue Parse(
      string input);

    /// <summary>Determines whether a string is valid HttpLanguageRangeWithQualityHeaderValue information.</summary>
    /// <param name="input">The string to validate.</param>
    /// <param name="languageRangeWithQualityHeaderValue">The HttpLanguageRangeWithQualityHeaderValue version of the string.</param>
    /// <returns>**true** if *input* is valid HttpLanguageRangeWithQualityHeaderValue information; otherwise, **false**.</returns>
    [MethodImpl]
    public static extern bool TryParse(
      string input,
      out HttpLanguageRangeWithQualityHeaderValue languageRangeWithQualityHeaderValue);
  }
}
