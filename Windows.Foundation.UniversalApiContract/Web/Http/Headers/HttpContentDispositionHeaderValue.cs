// Decompiled with JetBrains decompiler
// Type: Windows.Web.Http.Headers.HttpContentDispositionHeaderValue
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Web.Http.Headers
{
  /// <summary>Represents the value of the **Content-Disposition** HTTP header on HTTP content in a request or a response.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Activatable(typeof (IHttpContentDispositionHeaderValueFactory), 65536, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [DualApiPartition(version = 100859904)]
  [Static(typeof (IHttpContentDispositionHeaderValueStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  public sealed class HttpContentDispositionHeaderValue : 
    IHttpContentDispositionHeaderValue,
    IStringable
  {
    /// <summary>Initializes a new instance of the HttpContentDispositionHeaderValue class with **content-coding** information for use in the **Content-Disposition** HTTP header.</summary>
    /// <param name="dispositionType">The content disposition value to be used in the **Content-Disposition** HTTP header. For valid values, see Content Disposition Values and [Content-Disposition</param>
    [MethodImpl]
    public extern HttpContentDispositionHeaderValue(string dispositionType);

    /// <summary>Gets or sets the value of the **disposition-type** information in the **Content-Disposition** HTTP header.</summary>
    /// <returns>The value of the **disposition-type** characteristic in the **Content-Disposition** HTTP header.</returns>
    public extern string DispositionType { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the value of the **filename-parm** information in the **Content-Disposition** HTTP header for a single file.</summary>
    /// <returns>A suggested filename.</returns>
    public extern string FileName { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the value of the **filename-parm** characteristic in the **Content-Disposition** HTTP header for multiple files.</summary>
    /// <returns>A suggested filename of the form filename*.</returns>
    public extern string FileNameStar { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the name for a content body part in the **Content-Disposition** HTTP header.</summary>
    /// <returns>The name for the content body part.</returns>
    public extern string Name { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets a set of parameters included in the **Content-Disposition** HTTP header.</summary>
    /// <returns>A set of parameters.</returns>
    public extern IVector<HttpNameValueHeaderValue> Parameters { [MethodImpl] get; }

    /// <summary>Gets or sets the approximate size, in bytes, of the file used in the **Content-Disposition** HTTP header.</summary>
    /// <returns>The approximate size, in bytes.</returns>
    public extern IReference<ulong> Size { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Returns a string that represents the current HttpContentDispositionHeaderValue object.</summary>
    /// <returns>A string that represents the current object.</returns>
    [MethodImpl]
    public new extern string ToString();

    /// <summary>Converts a string to an HttpContentDispositionHeaderValue instance.</summary>
    /// <param name="input">A string that represents the content disposition information in the **Content-Disposition** HTTP header.</param>
    /// <returns>An HttpContentDispositionHeaderValue instance.</returns>
    [MethodImpl]
    public static extern HttpContentDispositionHeaderValue Parse(
      string input);

    /// <summary>Determines whether a string is valid HttpContentDispositionHeaderValue information.</summary>
    /// <param name="input">The string to validate.</param>
    /// <param name="contentDispositionHeaderValue">The HttpContentDispositionHeaderValue version of the string.</param>
    /// <returns>**true** if *input* is valid HttpContentDispositionHeaderValue information; otherwise, **false**.</returns>
    [MethodImpl]
    public static extern bool TryParse(
      string input,
      out HttpContentDispositionHeaderValue contentDispositionHeaderValue);
  }
}
