// Decompiled with JetBrains decompiler
// Type: Windows.Web.Http.Headers.HttpTransferCodingHeaderValue
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Web.Http.Headers
{
  /// <summary>Represents transfer coding information used in the **Transfer-Encoding** HTTP header on an HTTP request.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [Activatable(typeof (IHttpTransferCodingHeaderValueFactory), 65536, "Windows.Foundation.UniversalApiContract")]
  [Static(typeof (IHttpTransferCodingHeaderValueStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [DualApiPartition(version = 100859904)]
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class HttpTransferCodingHeaderValue : IHttpTransferCodingHeaderValue, IStringable
  {
    /// <summary>Initializes a new instance of the HttpProductInfoHeaderValue class.</summary>
    /// <param name="input">The **transfer-coding** information to initialize the HttpProductInfoHeaderValue object.</param>
    [MethodImpl]
    public extern HttpTransferCodingHeaderValue(string input);

    /// <summary>Gets a set of parameters used in the **Transfer-Encoding** HTTP header.</summary>
    /// <returns>A set of name/value parameters used in the **Transfer-Encoding** HTTP header.</returns>
    public extern IVector<HttpNameValueHeaderValue> Parameters { [MethodImpl] get; }

    /// <summary>Gets the transfer-coding value used in the **Transfer-Encoding** HTTP header.</summary>
    /// <returns>The transfer-coding value (transfer-coding name) used in the **Transfer-Encoding** HTTP header.</returns>
    public extern string Value { [MethodImpl] get; }

    /// <summary>Returns a string that represents the current HttpTransferCodingHeaderValue object.</summary>
    /// <returns>A string that represents the current object.</returns>
    [MethodImpl]
    public new extern string ToString();

    /// <summary>Converts a string to an HttpTransferCodingHeaderValue instance.</summary>
    /// <param name="input">A string that represents the **transfer-coding** information.</param>
    /// <returns>An HttpProductInfoHeaderValue instance.</returns>
    [MethodImpl]
    public static extern HttpTransferCodingHeaderValue Parse(
      string input);

    /// <summary>Determines whether a string is valid HttpTransferCodingHeaderValue information.</summary>
    /// <param name="input">The string to validate.</param>
    /// <param name="transferCodingHeaderValue">The HttpTransferCodingHeaderValue version of the string.</param>
    /// <returns>**true** if *input* is valid HttpTransferCodingHeaderValue information; otherwise, **false**.</returns>
    [MethodImpl]
    public static extern bool TryParse(
      string input,
      out HttpTransferCodingHeaderValue transferCodingHeaderValue);
  }
}
