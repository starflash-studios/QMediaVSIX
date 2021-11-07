// Decompiled with JetBrains decompiler
// Type: Windows.Security.Authentication.Web.Core.WebTokenRequest
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
  /// <summary>Represents a request to an online identity provider for an authentication token.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Activatable(typeof (IWebTokenRequestFactory), 65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  [DualApiPartition(version = 167772160)]
  public sealed class WebTokenRequest : IWebTokenRequest, IWebTokenRequest2, IWebTokenRequest3
  {
    /// <summary>Initializes a new instance of the WebTokenRequest class with three inputs.</summary>
    /// <param name="provider">The web account provider the request is for.</param>
    /// <param name="scope">The scope of the request.</param>
    /// <param name="clientId">The client ID.</param>
    [MethodImpl]
    public extern WebTokenRequest(WebAccountProvider provider, string scope, string clientId);

    /// <summary>Initializes a new instance of the WebTokenRequest class with four inputs.</summary>
    /// <param name="provider">The web account provider the request is for.</param>
    /// <param name="scope">The scope of the request.</param>
    /// <param name="clientId">The client ID.</param>
    /// <param name="promptType">The request prompt type.</param>
    [MethodImpl]
    public extern WebTokenRequest(
      WebAccountProvider provider,
      string scope,
      string clientId,
      WebTokenRequestPromptType promptType);

    /// <summary>Initializes a new instance of the WebTokenRequest class with one input.</summary>
    /// <param name="provider">The web account provider the request is for.</param>
    [MethodImpl]
    public extern WebTokenRequest(WebAccountProvider provider);

    /// <summary>Initializes a new instance of the WebTokenRequest class with two inputs.</summary>
    /// <param name="provider">The web account provider the request is for.</param>
    /// <param name="scope">The scope of the request.</param>
    [MethodImpl]
    public extern WebTokenRequest(WebAccountProvider provider, string scope);

    /// <summary>Gets the web account provider for the request.</summary>
    /// <returns>The web account provider for the request.</returns>
    public extern WebAccountProvider WebAccountProvider { [MethodImpl] get; }

    /// <summary>Gets the scope of the request.</summary>
    /// <returns>The scope of the request.</returns>
    public extern string Scope { [MethodImpl] get; }

    /// <summary>Gets the Id of the client making the request.</summary>
    /// <returns>The Id of the client making the request.</returns>
    public extern string ClientId { [MethodImpl] get; }

    /// <summary>Gets the prompt type of the request.</summary>
    /// <returns>The prompt type of the request.</returns>
    public extern WebTokenRequestPromptType PromptType { [MethodImpl] get; }

    /// <summary>Gets the properties of the request.</summary>
    /// <returns>The properties of the request.</returns>
    public extern IMap<string, string> Properties { [MethodImpl] get; }

    /// <summary>Gets the app properties of the request.</summary>
    /// <returns>The app properties of the request.</returns>
    public extern IMap<string, string> AppProperties { [MethodImpl] get; }

    /// <summary>Gets and sets a correlation Id, a unique identifier used for tracking authentication-related requests.</summary>
    /// <returns>The correlation Id for this request.</returns>
    public extern string CorrelationId { [MethodImpl] get; [MethodImpl] set; }
  }
}
