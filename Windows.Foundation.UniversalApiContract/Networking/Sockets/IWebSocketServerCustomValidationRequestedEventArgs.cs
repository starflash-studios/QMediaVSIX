// Decompiled with JetBrains decompiler
// Type: Windows.Networking.Sockets.IWebSocketServerCustomValidationRequestedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Security.Cryptography.Certificates;

namespace Windows.Networking.Sockets
{
  [Guid(4293918280, 554, 19127, 139, 54, 225, 10, 244, 100, 14, 107)]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [ExclusiveTo(typeof (WebSocketServerCustomValidationRequestedEventArgs))]
  internal interface IWebSocketServerCustomValidationRequestedEventArgs
  {
    Certificate ServerCertificate { get; }

    SocketSslErrorSeverity ServerCertificateErrorSeverity { get; }

    IVectorView<ChainValidationResult> ServerCertificateErrors { get; }

    IVectorView<Certificate> ServerIntermediateCertificates { get; }

    void Reject();

    Deferral GetDeferral();
  }
}
