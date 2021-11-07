// Decompiled with JetBrains decompiler
// Type: Windows.Web.Http.Headers.HttpMediaTypeWithQualityHeaderValue
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Web.Http.Headers
{
  /// <summary>Represents accept information used in the **Accept** HTTP header on an HTTP request.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Threading(ThreadingModel.Both)]
  [Activatable(typeof (IHttpMediaTypeWithQualityHeaderValueFactory), 65536, "Windows.Foundation.UniversalApiContract")]
  [Static(typeof (IHttpMediaTypeWithQualityHeaderValueStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [DualApiPartition(version = 100859904)]
  public sealed class HttpMediaTypeWithQualityHeaderValue : 
    IHttpMediaTypeWithQualityHeaderValue,
    IStringable
  {
    /// <summary>Initializes a new instance of the HttpMediaTypeHeaderValue class with a media type.</summary>
    /// <param name="mediaType">The **media-type** of the entity-body to accept that is used in the **Accept** HTTP header.</param>
    [MethodImpl]
    public extern HttpMediaTypeWithQualityHeaderValue(string mediaType);

    /// <summary>Initializes a new instance of the HttpMediaTypeHeaderValue class with a media type and quality.</summary>
    /// <param name="mediaType">The **media-type** of the entity-body to accept that is used in the **Accept** HTTP header.</param>
    /// <param name="quality">The **qvalue** or quality.</param>
    [MethodImpl]
    public extern HttpMediaTypeWithQualityHeaderValue(string mediaType, double quality);

    /// <summary>Gets or sets the character set of the content to accept that is used in the **Accept** HTTP header.</summary>
    /// <returns>The character set of the entity-body.</returns>
    public extern string CharSet { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the **media-type** of the content to accept that is used in the **Accept** HTTP header.</summary>
    /// <returns>The **media-type** of the entity-body.</returns>
    public extern string MediaType { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets a set of parameters included in the **Accept** HTTP header.</summary>
    /// <returns>A set of parameters.</returns>
    public extern IVector<HttpNameValueHeaderValue> Parameters { [MethodImpl] get; }

    /// <summary>Get or set the **qvalue** or quality used in the **Accept** HTTP header.</summary>
    /// <returns>The **qvalue** or quality.</returns>
    public extern IReference<double> Quality { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Returns a string that represents the current HttpMediaTypeWithQualityHeaderValue object.</summary>
    /// <returns>A string that represents the current object.</returns>
    [MethodImpl]
    public new extern string ToString();

    /// <summary>Converts a string to an HttpMediaTypeWithQualityHeaderValue instance.</summary>
    /// <param name="input">A string that represents the media-type, character set, and quality information used in the **Accept** HTTP header.</param>
    /// <returns>An HttpMediaTypeWithQualityHeaderValue instance.</returns>
    [MethodImpl]
    public static extern HttpMediaTypeWithQualityHeaderValue Parse(
      string input);

    /// <summary>Determines whether a string is valid HttpMediaTypeWithQualityHeaderValue information.</summary>
    /// <param name="input">The string to validate.</param>
    /// <param name="mediaTypeWithQualityHeaderValue">The HttpMediaTypeWithQualityHeaderValue version of the string.</param>
    /// <returns>**true** if *input* is valid HttpMediaTypeWithQualityHeaderValue information; otherwise, **false**.</returns>
    [MethodImpl]
    public static extern bool TryParse(
      string input,
      out HttpMediaTypeWithQualityHeaderValue mediaTypeWithQualityHeaderValue);
  }
}
