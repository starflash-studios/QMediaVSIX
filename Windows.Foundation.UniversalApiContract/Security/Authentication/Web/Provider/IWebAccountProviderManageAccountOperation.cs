// Decompiled with JetBrains decompiler
// Type: Windows.Security.Authentication.Web.Provider.IWebAccountProviderManageAccountOperation
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Security.Credentials;

namespace Windows.Security.Authentication.Web.Provider
{
  [ExclusiveTo(typeof (WebAccountProviderManageAccountOperation))]
  [Guid(3978353756, 53787, 17982, 169, 183, 193, 253, 14, 218, 233, 120)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IWebAccountProviderManageAccountOperation : IWebAccountProviderOperation
  {
    WebAccount WebAccount { get; }

    void ReportCompleted();
  }
}
