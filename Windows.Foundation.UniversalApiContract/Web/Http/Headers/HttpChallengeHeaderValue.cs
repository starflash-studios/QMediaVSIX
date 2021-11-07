// Decompiled with JetBrains decompiler
// Type: Windows.Web.Http.Headers.HttpChallengeHeaderValue
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Web.Http.Headers
{
  /// <summary>Represents authentication information used in the **Proxy-Authenticate** and **WWW-Authenticate** HTTP header values.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [Static(typeof (IHttpChallengeHeaderValueStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Activatable(typeof (IHttpChallengeHeaderValueFactory), 65536, "Windows.Foundation.UniversalApiContract")]
  [DualApiPartition(version = 100859904)]
  [Threading(ThreadingModel.Both)]
  public sealed class HttpChallengeHeaderValue : IHttpChallengeHeaderValue, IStringable
  {
    /// <summary>Initializes a new instance of the HttpChallengeHeaderValue class with the scheme to use for authorization.</summary>
    /// <param name="scheme">The scheme to use for authorization.</param>
    [MethodImpl]
    public extern HttpChallengeHeaderValue(string scheme);

    /// <summary>Initializes a new instance of the HttpChallengeHeaderValue class with the scheme to use for authorization and the **SPNEGO** token.</summary>
    /// <param name="scheme">The scheme to use for authorization.</param>
    /// <param name="token">The **SPNEGO** token to use with the **Negotiate** protocol scheme.</param>
    [MethodImpl]
    public extern HttpChallengeHeaderValue(string scheme, string token);

    /// <summary>Gets the credentials that contain the authentication information of the user agent for the resource being requested.</summary>
    /// <returns>The credentials that contain the authentication information.</returns>
    public extern IVector<HttpNameValueHeaderValue> Parameters { [MethodImpl] get; }

    /// <summary>Gets the scheme to use for authentication.</summary>
    /// <returns>The scheme to use for authentication.</returns>
    public extern string Scheme { [MethodImpl] get; }

    /// <summary>The **SPNEGO** token to use with the **Negotiate** protocol scheme.</summary>
    /// <returns>The **SPNEGO** token.</returns>
    public extern string Token { [MethodImpl] get; }

    /// <summary>Returns a string that represents the current HttpChallengeHeaderValue object.</summary>
    /// <returns>A string that represents the current object.</returns>
    [MethodImpl]
    public new extern string ToString();

    /// <summary>Converts a string to an HttpChallengeHeaderValue instance.</summary>
    /// <param name="input">A string that represents authentication header value information.</param>
    /// <returns>An HttpChallengeHeaderValue instance.</returns>
    [MethodImpl]
    public static extern HttpChallengeHeaderValue Parse(string input);

    /// <summary>Determines whether a string is valid HttpChallengeHeaderValue information.</summary>
    /// <param name="input">The string to validate.</param>
    /// <param name="challengeHeaderValue">The HttpChallengeHeaderValue version of the string.</param>
    /// <returns>**true** if input is valid HttpChallengeHeaderValue information; otherwise, **false**.</returns>
    [MethodImpl]
    public static extern bool TryParse(
      string input,
      out HttpChallengeHeaderValue challengeHeaderValue);
  }
}
