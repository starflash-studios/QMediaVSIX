// Decompiled with JetBrains decompiler
// Type: Windows.Security.Authentication.Web.Provider.WebAccountProviderRetrieveCookiesOperation
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Security.Authentication.Web.Core;
using Windows.Web.Http;

namespace Windows.Security.Authentication.Web.Provider
{
  /// <summary>Represents a retrieve cookies operation made by a web account provider.</summary>
  [DualApiPartition(version = 167772160)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class WebAccountProviderRetrieveCookiesOperation : 
    IWebAccountProviderRetrieveCookiesOperation,
    IWebAccountProviderOperation,
    IWebAccountProviderBaseReportOperation
  {
    /// <summary>Gets the context of the retrieve cookies operation.</summary>
    /// <returns>The context of the retrieve cookies operation.</returns>
    public extern Uri Context { [MethodImpl] get; }

    /// <summary>Gets the cookies.</summary>
    /// <returns>The cookies to retrieve.</returns>
    public extern IVector<HttpCookie> Cookies { [MethodImpl] get; }

    /// <summary>Gets or sets the Uri to retrieve cookies from.</summary>
    /// <returns>The Uri to retrieve cookies from.</returns>
    public extern Uri Uri { [MethodImpl] set; [MethodImpl] get; }

    /// <summary>Gets the app callback Uri.</summary>
    /// <returns>The app callback Uri.</returns>
    public extern Uri ApplicationCallbackUri { [MethodImpl] get; }

    /// <summary>Gets the kind of web account provider operation.</summary>
    /// <returns>The kind of web account provider operation.</returns>
    public extern WebAccountProviderOperationKind Kind { [MethodImpl] get; }

    /// <summary>Informs the activating app that the operation completed successfully.</summary>
    [MethodImpl]
    public extern void ReportCompleted();

    /// <summary>Informs the activating app that the operation encountered an error.</summary>
    /// <param name="value">The type of error encountered.</param>
    [MethodImpl]
    public extern void ReportError(WebProviderError value);
  }
}
