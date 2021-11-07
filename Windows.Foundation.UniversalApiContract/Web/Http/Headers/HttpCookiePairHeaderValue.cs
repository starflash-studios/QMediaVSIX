// Decompiled with JetBrains decompiler
// Type: Windows.Web.Http.Headers.HttpCookiePairHeaderValue
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Web.Http.Headers
{
  /// <summary>Represents cookie information used in the **Cookie** HTTP header on an HTTP request.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [Activatable(typeof (IHttpCookiePairHeaderValueFactory), 65536, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  [Static(typeof (IHttpCookiePairHeaderValueStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [DualApiPartition(version = 100859904)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class HttpCookiePairHeaderValue : IHttpCookiePairHeaderValue, IStringable
  {
    /// <summary>Initializes a new instance of the HttpCookiePairHeaderValue class. with a cookie name.</summary>
    /// <param name="name">A token that represents the cookie name.</param>
    [MethodImpl]
    public extern HttpCookiePairHeaderValue(string name);

    /// <summary>Initializes a new instance of the HttpCookiePairHeaderValue class. with a cookie name and a value for the cookie.</summary>
    /// <param name="name">A token that represents the cookie name.</param>
    /// <param name="value">A value for the cookie.</param>
    [MethodImpl]
    public extern HttpCookiePairHeaderValue(string name, string value);

    /// <summary>Gets a token that represents the cookie name used in the **Cookie** HTTP header.</summary>
    /// <returns>A token that represents the cookie name.</returns>
    public extern string Name { [MethodImpl] get; }

    /// <summary>Gets or sets a value for the cookie used in the **Cookie** HTTP header.</summary>
    /// <returns>A value for the cookie.</returns>
    public extern string Value { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Returns a string that represents the current HttpCookiePairHeaderValue object.</summary>
    /// <returns>A string that represents the current object.</returns>
    [MethodImpl]
    public new extern string ToString();

    /// <summary>Converts a string to an HttpCookiePairHeaderValue instance.</summary>
    /// <param name="input">A string that represents the cookie name and value in the **Cookie** HTTP header.</param>
    /// <returns>An HttpCookiePairHeaderValue instance.</returns>
    [MethodImpl]
    public static extern HttpCookiePairHeaderValue Parse(string input);

    /// <summary>Determines whether a string is valid HttpCookiePairHeaderValue information.</summary>
    /// <param name="input">The string to validate.</param>
    /// <param name="cookiePairHeaderValue">The HttpCookiePairHeaderValue version of the string.</param>
    /// <returns>**true** if *input* is valid HttpCookiePairHeaderValue information; otherwise, **false**.</returns>
    [MethodImpl]
    public static extern bool TryParse(
      string input,
      out HttpCookiePairHeaderValue cookiePairHeaderValue);
  }
}
