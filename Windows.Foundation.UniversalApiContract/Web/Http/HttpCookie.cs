// Decompiled with JetBrains decompiler
// Type: Windows.Web.Http.HttpCookie
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Web.Http
{
  /// <summary>Provides a set of properties and methods to manage an HTTP cookie.</summary>
  [Threading(ThreadingModel.Both)]
  [Activatable(typeof (IHttpCookieFactory), 65536, "Windows.Foundation.UniversalApiContract")]
  [DualApiPartition(version = 100859904)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class HttpCookie : IHttpCookie, IStringable
  {
    /// <summary>Initializes a new instance of the HttpCookie class with a specified name, domain, and path.</summary>
    /// <param name="name">The name for the HttpCookie</param>
    /// <param name="domain">The domain for which the HttpCookie is valid.</param>
    /// <param name="path">The URIs to which the HttpCookie applies.</param>
    [MethodImpl]
    public extern HttpCookie(string name, string domain, string path);

    /// <summary>Get the token that represents the HttpCookie name.</summary>
    /// <returns>The token that represents the HttpCookie name.</returns>
    public extern string Name { [MethodImpl] get; }

    /// <summary>Get the domain for which the HttpCookie is valid.</summary>
    /// <returns>The domain for which the HttpCookie is valid.</returns>
    public extern string Domain { [MethodImpl] get; }

    /// <summary>Get the URI path component to which the HttpCookie applies.</summary>
    /// <returns>The URI path component to which the HttpCookie applies.</returns>
    public extern string Path { [MethodImpl] get; }

    /// <summary>Get or set the expiration date and time for the HttpCookie.</summary>
    /// <returns>The expiration date and time for the HttpCookie.</returns>
    public extern IReference<DateTime> Expires { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Get or set a value that controls whether a script or other active content can access this HttpCookie.</summary>
    /// <returns>Whether a script or other active content can access this HttpCookie.</returns>
    public extern bool HttpOnly { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Get or set the security level for the HttpCookie.</summary>
    /// <returns>The security level for the HttpCookie.</returns>
    public extern bool Secure { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Get or set the value for the HttpCookie.</summary>
    /// <returns>The value for the HttpCookie.</returns>
    public extern string Value { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Returns a string that represents the current HttpCookie object.</summary>
    /// <returns>A string that represents the current object.</returns>
    [MethodImpl]
    public new extern string ToString();
  }
}
