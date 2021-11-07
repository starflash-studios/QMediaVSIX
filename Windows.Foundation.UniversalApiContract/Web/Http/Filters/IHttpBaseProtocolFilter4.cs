// Decompiled with JetBrains decompiler
// Type: Windows.Web.Http.Filters.IHttpBaseProtocolFilter4
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Web.Http.Filters
{
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [ExclusiveTo(typeof (HttpBaseProtocolFilter))]
  [Guid(2682481871, 10627, 18579, 148, 31, 235, 81, 140, 168, 206, 249)]
  internal interface IHttpBaseProtocolFilter4
  {
    event TypedEventHandler<HttpBaseProtocolFilter, HttpServerCustomValidationRequestedEventArgs> ServerCustomValidationRequested;

    void ClearAuthenticationCache();
  }
}
