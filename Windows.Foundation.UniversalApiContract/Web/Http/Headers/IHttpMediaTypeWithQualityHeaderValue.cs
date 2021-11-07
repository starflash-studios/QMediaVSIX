// Decompiled with JetBrains decompiler
// Type: Windows.Web.Http.Headers.IHttpMediaTypeWithQualityHeaderValue
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Web.Http.Headers
{
  [Guid(411917874, 30398, 17568, 177, 205, 32, 116, 189, 237, 45, 222)]
  [ExclusiveTo(typeof (HttpMediaTypeWithQualityHeaderValue))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IHttpMediaTypeWithQualityHeaderValue
  {
    string CharSet { get; set; }

    string MediaType { get; set; }

    IVector<HttpNameValueHeaderValue> Parameters { get; }

    IReference<double> Quality { get; set; }
  }
}
