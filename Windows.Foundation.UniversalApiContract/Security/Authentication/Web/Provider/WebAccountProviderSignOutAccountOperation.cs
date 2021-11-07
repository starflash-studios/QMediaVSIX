// Decompiled with JetBrains decompiler
// Type: Windows.Security.Authentication.Web.Provider.WebAccountProviderSignOutAccountOperation
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Security.Authentication.Web.Core;
using Windows.Security.Credentials;

namespace Windows.Security.Authentication.Web.Provider
{
  /// <summary>Represents a sign out account operation made by a web account provider.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [DualApiPartition(version = 167772160)]
  public sealed class WebAccountProviderSignOutAccountOperation : 
    IWebAccountProviderSignOutAccountOperation,
    IWebAccountProviderOperation,
    IWebAccountProviderBaseReportOperation
  {
    /// <summary>Gets the web account to sign out.</summary>
    /// <returns>The web account to sign out.</returns>
    public extern WebAccount WebAccount { [MethodImpl] get; }

    /// <summary>Gets the app callback Uri.</summary>
    /// <returns>The app callback Uri.</returns>
    public extern Uri ApplicationCallbackUri { [MethodImpl] get; }

    /// <summary>Gets the client Id.</summary>
    /// <returns>The client Id.</returns>
    public extern string ClientId { [MethodImpl] get; }

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
