// Decompiled with JetBrains decompiler
// Type: Windows.Web.Http.IHttpTransportInformation
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Networking.Sockets;
using Windows.Security.Cryptography.Certificates;

namespace Windows.Web.Http
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(1880256920, 50855, 20176, 131, 58, 131, 253, 139, 143, 23, 141)]
  [ExclusiveTo(typeof (HttpTransportInformation))]
  internal interface IHttpTransportInformation
  {
    Certificate ServerCertificate { get; }

    SocketSslErrorSeverity ServerCertificateErrorSeverity { get; }

    IVectorView<ChainValidationResult> ServerCertificateErrors { get; }

    IVectorView<Certificate> ServerIntermediateCertificates { get; }
  }
}
