// Decompiled with JetBrains decompiler
// Type: Windows.Security.Authentication.Web.Provider.WebAccountProviderAddAccountOperation
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Security.Authentication.Web.Provider
{
  /// <summary>Represents an add account operation.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [DualApiPartition(version = 167772160)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class WebAccountProviderAddAccountOperation : 
    IWebAccountProviderAddAccountOperation,
    IWebAccountProviderOperation
  {
    /// <summary>Informs the activating app that the operation completed successfully.</summary>
    [MethodImpl]
    public extern void ReportCompleted();

    /// <summary>Gets the kind of web account provider operation.</summary>
    /// <returns>The kind of web account provider operation.</returns>
    public extern WebAccountProviderOperationKind Kind { [MethodImpl] get; }
  }
}
