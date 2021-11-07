// Decompiled with JetBrains decompiler
// Type: Windows.Security.Authentication.Web.Provider.IWebAccountProviderUIReportOperation
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Security.Authentication.Web.Provider
{
  /// <summary>Defines methods for web account provider UI report operations.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(687837907, 36736, 17147, 148, 79, 178, 16, 123, 189, 66, 230)]
  public interface IWebAccountProviderUIReportOperation : IWebAccountProviderBaseReportOperation
  {
    /// <summary>Informs the activating app that the user has cancelled the operation.</summary>
    void ReportUserCanceled();
  }
}
