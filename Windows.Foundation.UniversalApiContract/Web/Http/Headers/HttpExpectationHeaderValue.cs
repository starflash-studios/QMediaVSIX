// Decompiled with JetBrains decompiler
// Type: Windows.Web.Http.Headers.HttpExpectationHeaderValue
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Web.Http.Headers
{
  /// <summary>Represents a token for a particular server behavior required by the client that is used in the **Expect** HTTP header on an HTTP request.</summary>
  [Activatable(typeof (IHttpExpectationHeaderValueFactory), 65536, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [DualApiPartition(version = 100859904)]
  [Static(typeof (IHttpExpectationHeaderValueStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  public sealed class HttpExpectationHeaderValue : IHttpExpectationHeaderValue, IStringable
  {
    /// <summary>Initializes a new instance of the HttpExpectationHeaderValue class with a name.</summary>
    /// <param name="name">A token that represents a name used in the **Expect** HTTP header.</param>
    [MethodImpl]
    public extern HttpExpectationHeaderValue(string name);

    /// <summary>Initializes a new instance of the HttpExpectationHeaderValue class with a name and value for the name.</summary>
    /// <param name="name">A token that represents a name used in the **Expect** HTTP header.</param>
    /// <param name="value">A value for the name used in the **Expect** HTTP header.</param>
    [MethodImpl]
    public extern HttpExpectationHeaderValue(string name, string value);

    /// <summary>Gets or sets a token that represents a name for a server behavior used in the **Expect** HTTP header.</summary>
    /// <returns>A token that represents the name for a server behavior.</returns>
    public extern string Name { [MethodImpl] get; }

    /// <summary>Gets or sets a value for a server behavior used in the **Expect** HTTP header.</summary>
    /// <returns>A value for a server behavior used in the **Expect** HTTP header.</returns>
    public extern string Value { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets a set of parameters for a server behavior included in the **Expect** HTTP header.</summary>
    /// <returns>A set of parameters for a server behavior.</returns>
    public extern IVector<HttpNameValueHeaderValue> Parameters { [MethodImpl] get; }

    /// <summary>Returns a string that represents the current HttpExpectationHeaderValue object.</summary>
    /// <returns>A string that represents the current object.</returns>
    [MethodImpl]
    public new extern string ToString();

    /// <summary>Converts a string to an HttpExpectationHeaderValue instance.</summary>
    /// <param name="input">A string that represents the information in the **Expect** HTTP header.</param>
    /// <returns>An HttpExpectationHeaderValue instance.</returns>
    [MethodImpl]
    public static extern HttpExpectationHeaderValue Parse(string input);

    /// <summary>Determines whether a string is valid HttpCredentialsHeaderValue information.</summary>
    /// <param name="input">The string to validate.</param>
    /// <param name="expectationHeaderValue">The HttpExpectationHeaderValue version of the string.</param>
    /// <returns>**true** if *input* is valid HttpExpectationHeaderValue information; otherwise, **false**.</returns>
    [MethodImpl]
    public static extern bool TryParse(
      string input,
      out HttpExpectationHeaderValue expectationHeaderValue);
  }
}
