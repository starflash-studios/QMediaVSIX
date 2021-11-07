// Decompiled with JetBrains decompiler
// Type: Windows.Security.Authentication.Web.Core.WebTokenResponse
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Security.Credentials;

namespace Windows.Security.Authentication.Web.Core
{
  /// <summary>Represents the response from a web account provider to a web token request.</summary>
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Activatable(typeof (IWebTokenResponseFactory), 65536, "Windows.Foundation.UniversalApiContract")]
  [DualApiPartition(version = 167772160)]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class WebTokenResponse : IWebTokenResponse
  {
    /// <summary>Initializes a new instance of the WebTokenResponse class with one input.</summary>
    /// <param name="token">The token.</param>
    [MethodImpl]
    public extern WebTokenResponse(string token);

    /// <summary>Initializes a new instance of the WebTokenResponse class with two inputs.</summary>
    /// <param name="token">The token.</param>
    /// <param name="webAccount">The WebAccount.</param>
    [MethodImpl]
    public extern WebTokenResponse(string token, WebAccount webAccount);

    /// <summary>Initializes a new instance of the WebTokenResponse class with three inputs.</summary>
    /// <param name="token">The token.</param>
    /// <param name="webAccount">The WebAccount.</param>
    /// <param name="error">The web provider error.</param>
    [MethodImpl]
    public extern WebTokenResponse(string token, WebAccount webAccount, WebProviderError error);

    /// <summary>Initializes a new instance of the WebTokenResponse class.</summary>
    [MethodImpl]
    public extern WebTokenResponse();

    /// <summary>Gets the authentication token.</summary>
    /// <returns>The authentication token.</returns>
    public extern string Token { [MethodImpl] get; }

    /// <summary>Gets the error returned by the provider, if any.</summary>
    /// <returns>The error returned by the provider.</returns>
    public extern WebProviderError ProviderError { [MethodImpl] get; }

    /// <summary>Gets the web account for the request.</summary>
    /// <returns>The web account for the request.</returns>
    public extern WebAccount WebAccount { [MethodImpl] get; }

    /// <summary>Gets the properties of the response</summary>
    /// <returns>The properties of the response.</returns>
    public extern IMap<string, string> Properties { [MethodImpl] get; }
  }
}
