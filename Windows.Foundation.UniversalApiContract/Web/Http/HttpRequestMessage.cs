// Decompiled with JetBrains decompiler
// Type: Windows.Web.Http.HttpRequestMessage
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Web.Http.Headers;

namespace Windows.Web.Http
{
  /// <summary>Represents an HTTP request message including headers.</summary>
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [Activatable(typeof (IHttpRequestMessageFactory), 65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Threading(ThreadingModel.Both)]
  [DualApiPartition(version = 100859904)]
  public sealed class HttpRequestMessage : IHttpRequestMessage, IClosable, IStringable
  {
    [MethodImpl]
    public extern HttpRequestMessage(HttpMethod method, Uri uri);

    /// <summary>Initializes a new instance of the HttpRequestMessage class.</summary>
    [MethodImpl]
    public extern HttpRequestMessage();

    /// <summary>Gets or sets the HTTP content to send to the server on the HttpRequestMessage object.</summary>
    /// <returns>The HTTP content to send to the server on the HttpRequestMessage object.</returns>
    public extern IHttpContent Content { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets the collection of the HTTP request headers associated with the HttpRequestMessage.</summary>
    /// <returns>The collection of HTTP request headers associated with the HttpRequestMessage.</returns>
    public extern HttpRequestHeaderCollection Headers { [MethodImpl] get; }

    /// <summary>Gets or sets the HTTP method to be performed on the request URI.</summary>
    /// <returns>The HTTP method to be performed on the request URI.</returns>
    public extern HttpMethod Method { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets a set of properties on the HttpRequestMessage instance that are for use by the developer.</summary>
    /// <returns>A set of properties on the HttpRequestMessage instance that are for use by the developer.</returns>
    public extern IMap<string, object> Properties { [MethodImpl] get; }

    /// <summary>Gets or sets the Uri used for the HttpRequestMessage object.</summary>
    /// <returns>The Uri used for the HTTP request.</returns>
    public extern Uri RequestUri { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Get information about the underlying transport socket used by an HTTP connection.</summary>
    /// <returns>Information about the underlying transport socket used by an HTTP connection.</returns>
    public extern HttpTransportInformation TransportInformation { [MethodImpl] get; }

    [MethodImpl]
    public extern void Close();

    /// <summary>Returns a string that represents the current HttpRequestMessage object.</summary>
    /// <returns>A string that represents the current object.</returns>
    [MethodImpl]
    public new extern string ToString();
  }
}
