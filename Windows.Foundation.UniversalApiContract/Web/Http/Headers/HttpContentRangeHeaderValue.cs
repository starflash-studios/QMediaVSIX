// Decompiled with JetBrains decompiler
// Type: Windows.Web.Http.Headers.HttpContentRangeHeaderValue
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Web.Http.Headers
{
  /// <summary>Represents the value of the **Content-Range** HTTP header on HTTP content in a request or a response.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [Static(typeof (IHttpContentRangeHeaderValueStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [DualApiPartition(version = 100859904)]
  [Activatable(typeof (IHttpContentRangeHeaderValueFactory), 65536, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  public sealed class HttpContentRangeHeaderValue : IHttpContentRangeHeaderValue, IStringable
  {
    /// <summary>Initializes a new instance of the HttpContentRangeHeaderValue class with a content length.</summary>
    /// <param name="length">The length, in bytes, of the full content entity body.</param>
    [MethodImpl]
    public extern HttpContentRangeHeaderValue(ulong length);

    /// <summary>Initializes a new instance of the HttpContentRangeHeaderValue class with a start and stop position.</summary>
    /// <param name="from">The position, in bytes, at which to start sending data.</param>
    /// <param name="to">The position, in bytes, at which to stop sending data.</param>
    [MethodImpl]
    public extern HttpContentRangeHeaderValue(ulong from, ulong to);

    /// <summary>Initializes a new instance of the HttpContentRangeHeaderValue class with a start and stop position and a content length.</summary>
    /// <param name="from">The position, in bytes, at which to start sending data.</param>
    /// <param name="to">The position, in bytes, at which to stop sending data.</param>
    /// <param name="length">The length, in bytes, of the full content entity body.</param>
    [MethodImpl]
    public extern HttpContentRangeHeaderValue(ulong from, ulong to, ulong length);

    /// <summary>Gets the position at which to start sending data in the **Content-Range** HTTP header.</summary>
    /// <returns>The position, in bytes, at which to start sending data.</returns>
    public extern IReference<ulong> FirstBytePosition { [MethodImpl] get; }

    /// <summary>Gets the position at which to stop sending data in the **Content-Range** HTTP header.</summary>
    /// <returns>The position at which to stop sending data.</returns>
    public extern IReference<ulong> LastBytePosition { [MethodImpl] get; }

    /// <summary>Gets the length of the full content entity body in the **Content-Range** HTTP header.</summary>
    /// <returns>The length of the full content entity body.</returns>
    public extern IReference<ulong> Length { [MethodImpl] get; }

    /// <summary>Gets or sets the value of the range units used in the **Content-Range** HTTP header.</summary>
    /// <returns>The range units used.</returns>
    public extern string Unit { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Returns a string that represents the current HttpContentRangeHeaderValue object.</summary>
    /// <returns>A string that represents the current object.</returns>
    [MethodImpl]
    public new extern string ToString();

    /// <summary>Converts a string to an HttpContentRangeHeaderValue instance.</summary>
    /// <param name="input">A string that represents the content range information in the **Content-Range** HTTP header.</param>
    /// <returns>An HttpContentRangeHeaderValue instance.</returns>
    [MethodImpl]
    public static extern HttpContentRangeHeaderValue Parse(string input);

    /// <summary>Determines whether a string is valid HttpContentRangeHeaderValue information.</summary>
    /// <param name="input">The string to validate.</param>
    /// <param name="contentRangeHeaderValue">The HttpContentRangeHeaderValue version of the string.</param>
    /// <returns>**true** if *input* is valid HttpContentRangeHeaderValue information; otherwise, **false**.</returns>
    [MethodImpl]
    public static extern bool TryParse(
      string input,
      out HttpContentRangeHeaderValue contentRangeHeaderValue);
  }
}
