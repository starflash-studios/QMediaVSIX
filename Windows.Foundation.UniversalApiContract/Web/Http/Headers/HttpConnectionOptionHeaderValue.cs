// Decompiled with JetBrains decompiler
// Type: Windows.Web.Http.Headers.HttpConnectionOptionHeaderValue
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Web.Http.Headers
{
  /// <summary>Represents connection information used in the **Connection** HTTP header on an HTTP request.</summary>
  [Threading(ThreadingModel.Both)]
  [DualApiPartition(version = 100859904)]
  [Static(typeof (IHttpConnectionOptionHeaderValueStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [Activatable(typeof (IHttpConnectionOptionHeaderValueFactory), 65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class HttpConnectionOptionHeaderValue : IHttpConnectionOptionHeaderValue, IStringable
  {
    /// <summary>Initializes a new instance of the HttpConnectionOptionHeaderValue class.</summary>
    /// <param name="token">The value of the **connection-token** to use.</param>
    [MethodImpl]
    public extern HttpConnectionOptionHeaderValue(string token);

    /// <summary>Gets the value of the **connection-token** in the **Connection** HTTP header.</summary>
    /// <returns>The value of the **connection-token** in the **Connection** HTTP header.</returns>
    public extern string Token { [MethodImpl] get; }

    /// <summary>Returns a string that represents the current HttpConnectionOptionHeaderValue object.</summary>
    /// <returns>A string that represents the current object.</returns>
    [MethodImpl]
    public new extern string ToString();

    /// <summary>Converts a string to an HttpConnectionOptionHeaderValue instance.</summary>
    /// <param name="input">A string that represents the connection information in the **Connection** HTTP header.</param>
    /// <returns>An HttpConnectionOptionHeaderValue instance.</returns>
    [MethodImpl]
    public static extern HttpConnectionOptionHeaderValue Parse(
      string input);

    /// <summary>Determines whether a string is valid HttpConnectionOptionHeaderValue information.</summary>
    /// <param name="input">The string to validate.</param>
    /// <param name="connectionOptionHeaderValue">The HttpConnectionOptionHeaderValue version of the string.</param>
    /// <returns>**true** if input is valid HttpConnectionOptionHeaderValue information; otherwise, **false**.</returns>
    [MethodImpl]
    public static extern bool TryParse(
      string input,
      out HttpConnectionOptionHeaderValue connectionOptionHeaderValue);
  }
}
