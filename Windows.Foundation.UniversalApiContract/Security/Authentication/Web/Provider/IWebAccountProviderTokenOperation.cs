// Decompiled with JetBrains decompiler
// Type: Windows.Security.Authentication.Web.Provider.IWebAccountProviderTokenOperation
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Security.Authentication.Web.Provider
{
  /// <summary>Defines properties for web account provider token operations.</summary>
  [Guid(2512786366, 8244, 19512, 148, 52, 210, 108, 20, 178, 180, 178)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public interface IWebAccountProviderTokenOperation : IWebAccountProviderOperation
  {
    /// <summary>Gets the web provider token request.</summary>
    /// <returns>The web provider token request.</returns>
    WebProviderTokenRequest ProviderRequest { get; }

    /// <summary>Gets the web provider token responses.</summary>
    /// <returns>The web provider token responses.</returns>
    IVector<WebProviderTokenResponse> ProviderResponses { get; }

    /// <summary>Gets or sets the cache expiration time.</summary>
    /// <returns>The cache expiration time.</returns>
    DateTime CacheExpirationTime { set; get; }
  }
}
