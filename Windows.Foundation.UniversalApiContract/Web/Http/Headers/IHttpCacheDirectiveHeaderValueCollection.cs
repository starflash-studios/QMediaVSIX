// Decompiled with JetBrains decompiler
// Type: Windows.Web.Http.Headers.IHttpCacheDirectiveHeaderValueCollection
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Web.Http.Headers
{
  [Guid(2589485961, 54736, 20414, 189, 157, 181, 179, 99, 104, 17, 180)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (HttpCacheDirectiveHeaderValueCollection))]
  internal interface IHttpCacheDirectiveHeaderValueCollection
  {
    IReference<TimeSpan> MaxAge { get; set; }

    IReference<TimeSpan> MaxStale { get; set; }

    IReference<TimeSpan> MinFresh { get; set; }

    IReference<TimeSpan> SharedMaxAge { get; set; }

    void ParseAdd(string input);

    bool TryParseAdd(string input);
  }
}
