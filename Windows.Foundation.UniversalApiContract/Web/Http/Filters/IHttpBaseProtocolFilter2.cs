// Decompiled with JetBrains decompiler
// Type: Windows.Web.Http.Filters.IHttpBaseProtocolFilter2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Web.Http.Filters
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(784531475, 37927, 18688, 160, 23, 250, 125, 163, 181, 201, 174)]
  [ExclusiveTo(typeof (HttpBaseProtocolFilter))]
  internal interface IHttpBaseProtocolFilter2
  {
    HttpVersion MaxVersion { get; set; }
  }
}
