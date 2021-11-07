// Decompiled with JetBrains decompiler
// Type: Windows.Web.Http.Headers.HttpMediaTypeHeaderValue
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Web.Http.Headers
{
  /// <summary>Represents the value of the **Content-Type** HTTP header on the HTTP content in a request or a response.</summary>
  [Threading(ThreadingModel.Both)]
  [Static(typeof (IHttpMediaTypeHeaderValueStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [DualApiPartition(version = 100859904)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Activatable(typeof (IHttpMediaTypeHeaderValueFactory), 65536, "Windows.Foundation.UniversalApiContract")]
  public sealed class HttpMediaTypeHeaderValue : IHttpMediaTypeHeaderValue, IStringable
  {
    /// <summary>Initializes a new instance of the HttpMediaTypeHeaderValue class.</summary>
    /// <param name="mediaType">The **media-type** of the entity-body used in the **Content-Type** HTTP header.</param>
    [MethodImpl]
    public extern HttpMediaTypeHeaderValue(string mediaType);

    /// <summary>Gets or sets the character set of the entity-body used in the **Content-Type** HTTP header.</summary>
    /// <returns>The character set of the entity-body.</returns>
    public extern string CharSet { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the **media-type** of the entity-body used in the **Content-Type** HTTP header.</summary>
    /// <returns>The **media-type** of the entity-body.</returns>
    public extern string MediaType { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets a set of parameters included in the **Content-Type** HTTP header.</summary>
    /// <returns>A set of parameters.</returns>
    public extern IVector<HttpNameValueHeaderValue> Parameters { [MethodImpl] get; }

    /// <summary>Returns a string that represents the current HttpMediaTypeHeaderValue object.</summary>
    /// <returns>A string that represents the current object.</returns>
    [MethodImpl]
    public new extern string ToString();

    /// <summary>Converts a string to an HttpMediaTypeHeaderValue instance.</summary>
    /// <param name="input">A string that represents the media-type and character set information used in the **Content-Type** HTTP header.</param>
    /// <returns>An HttpMediaTypeHeaderValue instance.</returns>
    [MethodImpl]
    public static extern HttpMediaTypeHeaderValue Parse(string input);

    /// <summary>Determines whether a string is valid HttpMediaTypeHeaderValue information.</summary>
    /// <param name="input">The string to validate.</param>
    /// <param name="mediaTypeHeaderValue">The HttpMediaTypeHeaderValue version of the string.</param>
    /// <returns>**true** if *input* is valid HttpMediaTypeHeaderValue information; otherwise, **false**.</returns>
    [MethodImpl]
    public static extern bool TryParse(
      string input,
      out HttpMediaTypeHeaderValue mediaTypeHeaderValue);
  }
}
