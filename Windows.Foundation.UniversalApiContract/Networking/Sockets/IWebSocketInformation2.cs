// Decompiled with JetBrains decompiler
// Type: Windows.Networking.Sockets.IWebSocketInformation2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Security.Cryptography.Certificates;

namespace Windows.Networking.Sockets
{
  /// <summary>Provides socket information on an IWebSocket object. This interface extends IWebSocketInformation with additional properties.</summary>
  [Guid(3458021838, 41399, 19779, 130, 105, 141, 91, 152, 27, 212, 122)]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  public interface IWebSocketInformation2 : IWebSocketInformation
  {
    /// <summary>Gets the certificate provided by the server when a secure WebSocket connection has been established.</summary>
    /// <returns>The server certificate.</returns>
    Certificate ServerCertificate { get; }

    /// <summary>Gets the category of an error that occurred making an SSL connection with a WebSocket server.</summary>
    /// <returns>The category of error on an SSL connection.</returns>
    SocketSslErrorSeverity ServerCertificateErrorSeverity { get; }

    /// <summary>Gets a list of the errors that occurred while establishing a secure WebSocket connection.</summary>
    /// <returns>A list of values describing secure connection errors.</returns>
    IVectorView<ChainValidationResult> ServerCertificateErrors { get; }

    /// <summary>Gets the intermediate certificates sent by the server during SSL negotiation when making an SSL connection with a WebSockets server.</summary>
    /// <returns>The set of certificates sent by the server during SSL negotiation.</returns>
    IVectorView<Certificate> ServerIntermediateCertificates { get; }
  }
}
