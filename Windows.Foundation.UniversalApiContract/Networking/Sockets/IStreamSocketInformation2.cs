// Decompiled with JetBrains decompiler
// Type: Windows.Networking.Sockets.IStreamSocketInformation2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Security.Cryptography.Certificates;

namespace Windows.Networking.Sockets
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(314737746, 19420, 20196, 151, 106, 207, 19, 14, 157, 146, 227)]
  [ExclusiveTo(typeof (StreamSocketInformation))]
  internal interface IStreamSocketInformation2
  {
    SocketSslErrorSeverity ServerCertificateErrorSeverity { get; }

    IVectorView<ChainValidationResult> ServerCertificateErrors { get; }

    Certificate ServerCertificate { get; }

    IVectorView<Certificate> ServerIntermediateCertificates { get; }
  }
}
