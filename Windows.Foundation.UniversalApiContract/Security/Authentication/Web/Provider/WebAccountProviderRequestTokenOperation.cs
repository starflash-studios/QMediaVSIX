// Decompiled with JetBrains decompiler
// Type: Windows.Security.Authentication.Web.Provider.WebAccountProviderRequestTokenOperation
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Security.Authentication.Web.Core;

namespace Windows.Security.Authentication.Web.Provider
{
  /// <summary>Represents a request token operation.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [DualApiPartition(version = 167772160)]
  public sealed class WebAccountProviderRequestTokenOperation : 
    IWebAccountProviderTokenOperation,
    IWebAccountProviderOperation,
    IWebAccountProviderUIReportOperation,
    IWebAccountProviderBaseReportOperation
  {
    /// <summary>Gets the web provider token request.</summary>
    /// <returns>The web provider token request.</returns>
    public extern WebProviderTokenRequest ProviderRequest { [MethodImpl] get; }

    /// <summary>Gets the web provider token responses.</summary>
    /// <returns>The web provider token responses.</returns>
    public extern IVector<WebProviderTokenResponse> ProviderResponses { [MethodImpl] get; }

    /// <summary>Gets or sets the cache expiration time.</summary>
    /// <returns>The cache expiration time.</returns>
    public extern DateTime CacheExpirationTime { [MethodImpl] set; [MethodImpl] get; }

    /// <summary>Gets the kind of web account provider operation.</summary>
    /// <returns>The kind of web account provider operation.</returns>
    public extern WebAccountProviderOperationKind Kind { [MethodImpl] get; }

    /// <summary>Informs the activating app that the user cancelled the operation.</summary>
    [MethodImpl]
    public extern void ReportUserCanceled();

    /// <summary>Informs the activating app that the operation completed successfully.</summary>
    [MethodImpl]
    public extern void ReportCompleted();

    /// <summary>Informs the activating app that the operation encountered an error.</summary>
    /// <param name="value">The type of error encountered.</param>
    [MethodImpl]
    public extern void ReportError(WebProviderError value);
  }
}
