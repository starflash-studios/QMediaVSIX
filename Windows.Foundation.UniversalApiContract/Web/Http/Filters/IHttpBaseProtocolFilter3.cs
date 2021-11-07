// Decompiled with JetBrains decompiler
// Type: Windows.Web.Http.Filters.IHttpBaseProtocolFilter3
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Web.Http.Filters
{
  [ExclusiveTo(typeof (HttpBaseProtocolFilter))]
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  [Guid(3560918348, 48450, 17326, 135, 23, 173, 44, 143, 75, 41, 55)]
  internal interface IHttpBaseProtocolFilter3
  {
    HttpCookieUsageBehavior CookieUsageBehavior { get; set; }
  }
}
