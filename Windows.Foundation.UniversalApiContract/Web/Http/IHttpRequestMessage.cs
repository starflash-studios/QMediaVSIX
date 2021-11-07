// Decompiled with JetBrains decompiler
// Type: Windows.Web.Http.IHttpRequestMessage
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Web.Http.Headers;

namespace Windows.Web.Http
{
  [Guid(4118162236, 29908, 18449, 181, 220, 159, 139, 78, 47, 154, 191)]
  [ExclusiveTo(typeof (HttpRequestMessage))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IHttpRequestMessage
  {
    IHttpContent Content { get; set; }

    HttpRequestHeaderCollection Headers { get; }

    HttpMethod Method { get; set; }

    IMap<string, object> Properties { get; }

    Uri RequestUri { get; set; }

    HttpTransportInformation TransportInformation { get; }
  }
}
