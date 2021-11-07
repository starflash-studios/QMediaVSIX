// Decompiled with JetBrains decompiler
// Type: Windows.Security.Authentication.Web.Provider.IWebAccountProviderAddAccountOperation
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Security.Authentication.Web.Provider
{
  [Guid(1944837327, 17272, 19577, 147, 53, 165, 215, 171, 129, 89, 78)]
  [ExclusiveTo(typeof (WebAccountProviderAddAccountOperation))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IWebAccountProviderAddAccountOperation : IWebAccountProviderOperation
  {
    void ReportCompleted();
  }
}
