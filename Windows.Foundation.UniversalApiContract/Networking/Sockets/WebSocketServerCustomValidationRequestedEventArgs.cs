// Decompiled with JetBrains decompiler
// Type: Windows.Networking.Sockets.WebSocketServerCustomValidationRequestedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Security.Cryptography.Certificates;

namespace Windows.Networking.Sockets
{
  /// <summary>Provides data for a ServerCustomValidationRequested event on a WebSocket. This event occurs when a new, secure connection to a WebSocket is being made, and gives your code the opportunity to perform custom validation of the server certificates before the connection has been established.</summary>
  [DualApiPartition(version = 167772160)]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class WebSocketServerCustomValidationRequestedEventArgs : 
    IWebSocketServerCustomValidationRequestedEventArgs
  {
    /// <summary>The certificate being offered by the server for validation.</summary>
    /// <returns>The server certificate.</returns>
    public extern Certificate ServerCertificate { [MethodImpl] get; }

    /// <summary>Gets the category of an error that occurred making an SSL connection with this WebSocket server.</summary>
    /// <returns>A value describing the severity of errors encountered so far in validating this connection.</returns>
    public extern SocketSslErrorSeverity ServerCertificateErrorSeverity { [MethodImpl] get; }

    /// <summary>A list of errors encountered in validating the server certificate.</summary>
    /// <returns>A list of enumeration values giving validation results.</returns>
    public extern IVectorView<ChainValidationResult> ServerCertificateErrors { [MethodImpl] get; }

    /// <summary>Gets a list of intermediate certificates from the validation process currently being validated.</summary>
    /// <returns>A list of intermediate certificates.</returns>
    public extern IVectorView<Certificate> ServerIntermediateCertificates { [MethodImpl] get; }

    /// <summary>Rejects validation of this server. Call this method when your validation has determined that you should not connect to the server.</summary>
    [MethodImpl]
    public extern void Reject();

    /// <summary>Gets the Deferral object that manages the validation operation. Call this method when you begin your validation operation, and call Deferral.Complete when the operation is complete.</summary>
    /// <returns>The Deferral object.</returns>
    [MethodImpl]
    public extern Deferral GetDeferral();
  }
}
