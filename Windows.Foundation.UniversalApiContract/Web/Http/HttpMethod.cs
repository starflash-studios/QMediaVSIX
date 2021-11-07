// Decompiled with JetBrains decompiler
// Type: Windows.Web.Http.HttpMethod
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Web.Http
{
  /// <summary>Retrieves standard HTTP methods such as GET and POST and creates new HTTP methods.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [DualApiPartition(version = 100859904)]
  [Static(typeof (IHttpMethodStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Activatable(typeof (IHttpMethodFactory), 65536, "Windows.Foundation.UniversalApiContract")]
  public sealed class HttpMethod : IHttpMethod, IStringable
  {
    /// <summary>Initializes a new instance of the HttpMethod class with a specific HTTP method.</summary>
    /// <param name="method">The HTTP method.</param>
    [MethodImpl]
    public extern HttpMethod(string method);

    /// <summary>Gets the HTTP method.</summary>
    /// <returns>An HTTP method represented as a String.</returns>
    public extern string Method { [MethodImpl] get; }

    /// <summary>Returns a string that represents the current HttpMethod object.</summary>
    /// <returns>A string that represents the current object.</returns>
    [MethodImpl]
    public new extern string ToString();

    /// <summary>Gets the HTTP DELETE method.</summary>
    /// <returns>The HTTP DELETE method.</returns>
    public static extern HttpMethod Delete { [MethodImpl] get; }

    /// <summary>Gets the HTTP GET method.</summary>
    /// <returns>The HTTP GET method.</returns>
    public static extern HttpMethod Get { [MethodImpl] get; }

    /// <summary>Gets the HTTP HEAD method.</summary>
    /// <returns>The HTTP HEAD method.</returns>
    public static extern HttpMethod Head { [MethodImpl] get; }

    /// <summary>Gets the HTTP OPTIONS method.</summary>
    /// <returns>The HTTP OPTIONS method.</returns>
    public static extern HttpMethod Options { [MethodImpl] get; }

    /// <summary>Gets the HTTP PATCH method,</summary>
    /// <returns>The HTTP PATCH method.</returns>
    public static extern HttpMethod Patch { [MethodImpl] get; }

    /// <summary>Gets the HTTP POST method.</summary>
    /// <returns>The HTTP POST method.</returns>
    public static extern HttpMethod Post { [MethodImpl] get; }

    /// <summary>Gets the HTTP PUT method.</summary>
    /// <returns>The HTTP PUT method.</returns>
    public static extern HttpMethod Put { [MethodImpl] get; }
  }
}
