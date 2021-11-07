// Decompiled with JetBrains decompiler
// Type: Windows.Web.Http.HttpGetStringResult
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Web.Http
{
  /// <summary>Combines the final string result along with the following: the original HTTP request, the resulting HTTP response (if any), an extended error value, and a succeeded indication.</summary>
  [DualApiPartition(version = 1)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 524288)]
  public sealed class HttpGetStringResult : IHttpGetStringResult, IClosable, IStringable
  {
    /// <summary>The extended error code for an HTTP request.</summary>
    /// <returns>HRESULT value of the error or null if there was no error.</returns>
    public extern HResult ExtendedError { [MethodImpl] get; }

    /// <summary>Gets the request message that led to this HttpGetStringResult.</summary>
    /// <returns>The request message that led to this HttpGetStringResult.</returns>
    public extern HttpRequestMessage RequestMessage { [MethodImpl] get; }

    /// <summary>Gets the HTTP response message including headers, the status code, and data.</summary>
    /// <returns>The response message which resulted from the HttpRequestMessage.</returns>
    public extern HttpResponseMessage ResponseMessage { [MethodImpl] get; }

    /// <summary>Gets whether the HTTP request was successful.</summary>
    /// <returns>True if HTTP request was successful; otherwise False. A request is successful if a 200-series HTTP response was received and, if the response body was read, that there were no exceptions when processing the response body.</returns>
    public extern bool Succeeded { [MethodImpl] get; }

    /// <summary>The returned string data from an HTTP request as a string.</summary>
    /// <returns>String value of the HTTP response.</returns>
    public extern string Value { [MethodImpl] get; }

    [MethodImpl]
    public extern void Close();

    /// <summary>Returns a string that represents the current HttpGetStringResult object.</summary>
    /// <returns>A string that represents the current object.</returns>
    [MethodImpl]
    public new extern string ToString();
  }
}
