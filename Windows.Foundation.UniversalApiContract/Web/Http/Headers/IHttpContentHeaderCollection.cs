// Decompiled with JetBrains decompiler
// Type: Windows.Web.Http.Headers.IHttpContentHeaderCollection
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Web.Http.Headers
{
  [Guid(1080109636, 18350, 19326, 145, 36, 105, 98, 139, 100, 170, 24)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (HttpContentHeaderCollection))]
  internal interface IHttpContentHeaderCollection
  {
    HttpContentDispositionHeaderValue ContentDisposition { get; set; }

    HttpContentCodingHeaderValueCollection ContentEncoding { get; }

    HttpLanguageHeaderValueCollection ContentLanguage { get; }

    IReference<ulong> ContentLength { get; set; }

    Uri ContentLocation { get; set; }

    IBuffer ContentMD5 { get; set; }

    HttpContentRangeHeaderValue ContentRange { get; set; }

    HttpMediaTypeHeaderValue ContentType { get; set; }

    IReference<DateTime> Expires { get; set; }

    IReference<DateTime> LastModified { get; set; }

    void Append(string name, string value);

    bool TryAppendWithoutValidation(string name, string value);
  }
}
