// Decompiled with JetBrains decompiler
// Type: Windows.Web.Http.Filters.IHttpCacheControl
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Web.Http.Filters
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (HttpCacheControl))]
  [Guid(3346930868, 15594, 20149, 172, 133, 4, 225, 134, 230, 58, 183)]
  internal interface IHttpCacheControl
  {
    HttpCacheReadBehavior ReadBehavior { get; set; }

    HttpCacheWriteBehavior WriteBehavior { get; set; }
  }
}
