// Decompiled with JetBrains decompiler
// Type: Windows.Security.Authentication.Web.Provider.WebAccountProviderDeleteAccountOperation
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
  /// <summary>Represents a delete account operation.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [DualApiPartition(version = 167772160)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class WebAccountProviderDeleteAccountOperation : 
    IWebAccountProviderDeleteAccountOperation,
    IWebAccountProviderOperation,
    IWebAccountProviderBaseReportOperation
  {
    /// <summary>Gets the web account to delete.</summary>
    /// <returns>The web account to delete.</returns>
    public extern WebAccount WebAccount { [MethodImpl] get; }

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
