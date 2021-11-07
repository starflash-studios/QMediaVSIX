// Decompiled with JetBrains decompiler
// Type: Windows.Web.Http.Filters.IHttpBaseProtocolFilter
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Security.Credentials;
using Windows.Security.Cryptography.Certificates;

namespace Windows.Web.Http.Filters
{
  [Guid(1908972297, 57649, 19284, 165, 60, 235, 67, 255, 55, 233, 187)]
  [ExclusiveTo(typeof (HttpBaseProtocolFilter))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IHttpBaseProtocolFilter
  {
    bool AllowAutoRedirect { get; set; }

    bool AllowUI { get; set; }

    bool AutomaticDecompression { get; set; }

    HttpCacheControl CacheControl { get; }

    HttpCookieManager CookieManager { get; }

    Certificate ClientCertificate { get; set; }

    IVector<ChainValidationResult> IgnorableServerCertificateErrors { get; }

    uint MaxConnectionsPerServer { get; set; }

    PasswordCredential ProxyCredential { get; set; }

    PasswordCredential ServerCredential { get; set; }

    bool UseProxy { get; set; }
  }
}
