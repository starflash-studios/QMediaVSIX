// Decompiled with JetBrains decompiler
// Type: Windows.Web.Http.Headers.HttpNameValueHeaderValue
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Web.Http.Headers
{
  /// <summary>Represents name and value information used in a number of HTTP headers.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [DualApiPartition(version = 100859904)]
  [Activatable(typeof (IHttpNameValueHeaderValueFactory), 65536, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Static(typeof (IHttpNameValueHeaderValueStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  public sealed class HttpNameValueHeaderValue : IHttpNameValueHeaderValue, IStringable
  {
    /// <summary>Initializes a new instance of the HttpNameValueHeaderValue class. with a name.</summary>
    /// <param name="name">The name to be used.</param>
    [MethodImpl]
    public extern HttpNameValueHeaderValue(string name);

    /// <summary>Initializes a new instance of the HttpNameValueHeaderValue class. with a name and value.</summary>
    /// <param name="name">The name to be used.</param>
    /// <param name="value">The value to associate with the *name*.</param>
    [MethodImpl]
    public extern HttpNameValueHeaderValue(string name, string value);

    /// <summary>Gets the name used in the HttpNameValueHeaderValue object.</summary>
    /// <returns>The name used in the HttpNameValueHeaderValue object.</returns>
    public extern string Name { [MethodImpl] get; }

    /// <summary>Gets or sets the value associated with a name used in the HttpNameValueHeaderValue object.</summary>
    /// <returns>The value associated with a name used in the HttpNameValueHeaderValue object.</returns>
    public extern string Value { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Returns a string that represents the current HttpNameValueHeaderValue object.</summary>
    /// <returns>A string that represents the current object.</returns>
    [MethodImpl]
    public new extern string ToString();

    /// <summary>Converts a string to an HttpNameValueHeaderValue instance.</summary>
    /// <param name="input">A string that represents the name and value.</param>
    /// <returns>An HttpNameValueHeaderValue instance.</returns>
    [MethodImpl]
    public static extern HttpNameValueHeaderValue Parse(string input);

    /// <summary>Determines whether a string is valid HttpNameValueHeaderValue information.</summary>
    /// <param name="input">The string to validate.</param>
    /// <param name="nameValueHeaderValue">The HttpNameValueHeaderValue version of the string.</param>
    /// <returns>**true** if *input* is valid HttpNameValueHeaderValue information; otherwise, **false**.</returns>
    [MethodImpl]
    public static extern bool TryParse(
      string input,
      out HttpNameValueHeaderValue nameValueHeaderValue);
  }
}
