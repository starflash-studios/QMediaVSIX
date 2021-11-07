// Decompiled with JetBrains decompiler
// Type: Windows.Security.Authentication.Web.Provider.IWebAccountProviderBaseReportOperation
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Security.Authentication.Web.Core;

namespace Windows.Security.Authentication.Web.Provider
{
  /// <summary>Defines methods for web account provider operations that report success or failure.</summary>
  [Guid(3148131515, 39227, 19799, 187, 228, 20, 33, 227, 102, 139, 76)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public interface IWebAccountProviderBaseReportOperation
  {
    /// <summary>Informs the activating app that the operation completed successfully.</summary>
    void ReportCompleted();

    /// <summary>Informs the activating app that the operation encountered an error.</summary>
    /// <param name="value">The type of error encountered.</param>
    void ReportError(WebProviderError value);
  }
}
