// Decompiled with JetBrains decompiler
// Type: Windows.Security.Authentication.Web.Provider.IWebAccountProviderSilentReportOperation
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Security.Authentication.Web.Core;

namespace Windows.Security.Authentication.Web.Provider
{
  /// <summary>Defines methods for silent web account provider operations.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(3769976312, 15119, 17626, 146, 76, 123, 24, 186, 170, 98, 169)]
  public interface IWebAccountProviderSilentReportOperation : IWebAccountProviderBaseReportOperation
  {
    /// <summary>Informs the activating app a token could not be obtained silently and that user interaction is required to continue the operation.</summary>
    [Overload("ReportUserInteractionRequired")]
    void ReportUserInteractionRequired();

    /// <summary>Informs the activating app a token could not be obtained silently and that user interaction is required to continue the operation.</summary>
    /// <param name="value">The error that has occurred.</param>
    [Overload("ReportUserInteractionRequiredWithError")]
    void ReportUserInteractionRequired(WebProviderError value);
  }
}
