// Decompiled with JetBrains decompiler
// Type: Windows.Web.Http.Headers.HttpContentCodingHeaderValue
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Web.Http.Headers
{
  /// <summary>Represents content encoding information used in the **Content-Encoding** HTTP header on HTTP content in a request or a response.</summary>
  [Static(typeof (IHttpContentCodingHeaderValueStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  [Activatable(typeof (IHttpContentCodingHeaderValueFactory), 65536, "Windows.Foundation.UniversalApiContract")]
  [DualApiPartition(version = 100859904)]
  public sealed class HttpContentCodingHeaderValue : IHttpContentCodingHeaderValue, IStringable
  {
    /// <summary>Initializes a new instance of the HttpContentCodingHeaderValue class.</summary>
    /// <param name="contentCoding">The value of the **content-coding** to use.</param>
    [MethodImpl]
    public extern HttpContentCodingHeaderValue(string contentCoding);

    /// <summary>Gets the value of the **content-coding** information used in the **Content-Encoding** HTTP header.</summary>
    /// <returns>The value of the **content-coding** characteristic in the **Content-Encoding** HTTP header.</returns>
    public extern string ContentCoding { [MethodImpl] get; }

    /// <summary>Returns a string that represents the current HttpContentCodingHeaderValue object.</summary>
    /// <returns>A string that represents the current object.</returns>
    [MethodImpl]
    public new extern string ToString();

    /// <summary>Converts a string to an HttpContentCodingHeaderValue instance.</summary>
    /// <param name="input">A string that represents the content coding information in the **Content-Encoding** HTTP header.</param>
    /// <returns>An HttpContentCodingHeaderValue instance.</returns>
    [MethodImpl]
    public static extern HttpContentCodingHeaderValue Parse(string input);

    /// <summary>Determines whether a string is valid HttpContentCodingHeaderValue information.</summary>
    /// <param name="input">The string to validate.</param>
    /// <param name="contentCodingHeaderValue">The HttpContentCodingHeaderValue version of the string.</param>
    /// <returns>**true** if *input* is valid HttpContentCodingHeaderValue information; otherwise, **false**.</returns>
    [MethodImpl]
    public static extern bool TryParse(
      string input,
      out HttpContentCodingHeaderValue contentCodingHeaderValue);
  }
}
