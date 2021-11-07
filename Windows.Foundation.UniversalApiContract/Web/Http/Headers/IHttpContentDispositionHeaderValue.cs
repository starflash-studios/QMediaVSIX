// Decompiled with JetBrains decompiler
// Type: Windows.Web.Http.Headers.IHttpContentDispositionHeaderValue
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Web.Http.Headers
{
  [ExclusiveTo(typeof (HttpContentDispositionHeaderValue))]
  [Guid(4070764252, 9769, 19273, 153, 8, 150, 161, 104, 233, 54, 94)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IHttpContentDispositionHeaderValue
  {
    string DispositionType { get; set; }

    string FileName { get; set; }

    string FileNameStar { get; set; }

    string Name { get; set; }

    IVector<HttpNameValueHeaderValue> Parameters { get; }

    IReference<ulong> Size { get; set; }
  }
}
