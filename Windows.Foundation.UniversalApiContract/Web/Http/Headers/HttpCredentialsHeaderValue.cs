// Decompiled with JetBrains decompiler
// Type: Windows.Web.Http.Headers.HttpCredentialsHeaderValue
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Web.Http.Headers
{
  /// <summary>Represents the value of the **Authorization** or **Proxy-Authorization** HTTP header on an HTTP request.</summary>
  [Static(typeof (IHttpCredentialsHeaderValueStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Activatable(typeof (IHttpCredentialsHeaderValueFactory), 65536, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  [DualApiPartition(version = 100859904)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class HttpCredentialsHeaderValue : IHttpCredentialsHeaderValue, IStringable
  {
    /// <summary>Initializes a new instance of the HttpCredentialsHeaderValue class with the scheme to use for authentication.</summary>
    /// <param name="scheme">The scheme to use for authentication.</param>
    [MethodImpl]
    public extern HttpCredentialsHeaderValue(string scheme);

    /// <summary>Initializes a new instance of the HttpCredentialsHeaderValue class with the scheme and user token information to use for authentication.</summary>
    /// <param name="scheme">The scheme to use for authentication.</param>
    /// <param name="token">The user token information to use for authentication.</param>
    [MethodImpl]
    public extern HttpCredentialsHeaderValue(string scheme, string token);

    /// <summary>Gets a set of name/value pairs included in the **Authorization** or **Proxy-Authorization** HTTP header.</summary>
    /// <returns>A set of name/value pairs.</returns>
    public extern IVector<HttpNameValueHeaderValue> Parameters { [MethodImpl] get; }

    /// <summary>Gets the scheme to use for authentication.</summary>
    /// <returns>The scheme to use for authentication.</returns>
    public extern string Scheme { [MethodImpl] get; }

    /// <summary>Gets the user token information used in the **Authorization** or **Proxy-Authorization** HTTP header.</summary>
    /// <returns>The user token information in the **Authorization** or **Proxy-Authorization** HTTP header.</returns>
    public extern string Token { [MethodImpl] get; }

    /// <summary>Returns a string that represents the current HttpCredentialsHeaderValue object.</summary>
    /// <returns>A string that represents the current object.</returns>
    [MethodImpl]
    public new extern string ToString();

    /// <summary>Converts a string to an HttpCredentialsHeaderValue instance.</summary>
    /// <param name="input">A string that represents the credential information in the **Authorization** or **Proxy-Authorization** HTTP header.</param>
    /// <returns>An HttpCredentialsHeaderValue instance.</returns>
    [MethodImpl]
    public static extern HttpCredentialsHeaderValue Parse(string input);

    /// <summary>Determines whether a string is valid HttpCredentialsHeaderValue information.</summary>
    /// <param name="input">The string to validate.</param>
    /// <param name="credentialsHeaderValue">The HttpCredentialsHeaderValue version of the string.</param>
    /// <returns>**true** if *input* is valid HttpCredentialsHeaderValue information; otherwise, **false**.</returns>
    [MethodImpl]
    public static extern bool TryParse(
      string input,
      out HttpCredentialsHeaderValue credentialsHeaderValue);
  }
}
