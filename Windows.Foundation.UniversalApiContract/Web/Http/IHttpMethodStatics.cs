// Decompiled with JetBrains decompiler
// Type: Windows.Web.Http.IHttpMethodStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Web.Http
{
  [ExclusiveTo(typeof (HttpMethod))]
  [Guid(1691447792, 55706, 16723, 141, 198, 214, 140, 196, 204, 227, 23)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IHttpMethodStatics
  {
    HttpMethod Delete { get; }

    HttpMethod Get { get; }

    HttpMethod Head { get; }

    HttpMethod Options { get; }

    HttpMethod Patch { get; }

    HttpMethod Post { get; }

    HttpMethod Put { get; }
  }
}
