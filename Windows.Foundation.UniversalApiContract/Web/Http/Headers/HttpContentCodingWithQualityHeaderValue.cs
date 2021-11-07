// Decompiled with JetBrains decompiler
// Type: Windows.Web.Http.Headers.HttpContentCodingWithQualityHeaderValue
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Web.Http.Headers
{
  /// <summary>Represents accept encoding information used in the **Accept-Encoding** HTTP header on an HTTP request.</summary>
  [Static(typeof (IHttpContentCodingWithQualityHeaderValueStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [DualApiPartition(version = 100859904)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  [Activatable(typeof (IHttpContentCodingWithQualityHeaderValueFactory), 65536, "Windows.Foundation.UniversalApiContract")]
  public sealed class HttpContentCodingWithQualityHeaderValue : 
    IHttpContentCodingWithQualityHeaderValue,
    IStringable
  {
    /// <summary>Initializes a new instance of the HttpContentCodingHeaderValue class with **content-coding** information.</summary>
    /// <param name="contentCoding">The value of the **content-coding** to use.</param>
    [MethodImpl]
    public extern HttpContentCodingWithQualityHeaderValue(string contentCoding);

    /// <summary>Initializes a new instance of the HttpContentCodingHeaderValue class with **content-coding** information and a qvalue.</summary>
    /// <param name="contentCoding">The value of the **content-coding** information to use.</param>
    /// <param name="quality">The value of the **qvalue** to use.</param>
    [MethodImpl]
    public extern HttpContentCodingWithQualityHeaderValue(string contentCoding, double quality);

    /// <summary>Gets the value of the **content-coding** characteristic in the **Accept-Encoding** HTTP header.</summary>
    /// <returns>The value of the **content-coding** characteristic in the **Accept-Encoding** HTTP header.</returns>
    public extern string ContentCoding { [MethodImpl] get; }

    /// <summary>Gets the value of the **qvalue** attribute in the **Accept-Encoding** HTTP header.</summary>
    /// <returns>The value of the **qvalue** attribute in the **Accept-Encoding** HTTP header.</returns>
    public extern IReference<double> Quality { [MethodImpl] get; }

    /// <summary>Returns a string that represents the current HttpContentCodingHeaderValue object.</summary>
    /// <returns>A string that represents the current object.</returns>
    [MethodImpl]
    public new extern string ToString();

    /// <summary>Converts a string to an HttpContentCodingWithQualityHeaderValue instance.</summary>
    /// <param name="input">A string that represents the content coding information in the **Accept-Encoding** HTTP header.</param>
    /// <returns>An HttpContentCodingWithQualityHeaderValue instance.</returns>
    [MethodImpl]
    public static extern HttpContentCodingWithQualityHeaderValue Parse(
      string input);

    /// <summary>Determines whether a string is valid HttpContentCodingWithQualityHeaderValue information.</summary>
    /// <param name="input">The string to validate.</param>
    /// <param name="contentCodingWithQualityHeaderValue">The HttpContentCodingWithQualityHeaderValue version of the string.</param>
    /// <returns>**true** if *input* is valid HttpContentCodingWithQualityHeaderValue information; otherwise, **false**.</returns>
    [MethodImpl]
    public static extern bool TryParse(
      string input,
      out HttpContentCodingWithQualityHeaderValue contentCodingWithQualityHeaderValue);
  }
}
