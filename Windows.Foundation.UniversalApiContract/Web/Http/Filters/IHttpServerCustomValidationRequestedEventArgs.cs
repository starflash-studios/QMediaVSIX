// Decompiled with JetBrains decompiler
// Type: Windows.Web.Http.Filters.IHttpServerCustomValidationRequestedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Networking.Sockets;
using Windows.Security.Cryptography.Certificates;

namespace Windows.Web.Http.Filters
{
  [ExclusiveTo(typeof (HttpServerCustomValidationRequestedEventArgs))]
  [Guid(828767794, 59357, 18615, 163, 97, 147, 156, 117, 14, 99, 204)]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  internal interface IHttpServerCustomValidationRequestedEventArgs
  {
    HttpRequestMessage RequestMessage { get; }

    Certificate ServerCertificate { get; }

    SocketSslErrorSeverity ServerCertificateErrorSeverity { get; }

    IVectorView<ChainValidationResult> ServerCertificateErrors { get; }

    IVectorView<Certificate> ServerIntermediateCertificates { get; }

    void Reject();

    Deferral GetDeferral();
  }
}
