// Decompiled with JetBrains decompiler
// Type: Windows.Web.Http.Filters.HttpServerCustomValidationRequestedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Networking.Sockets;
using Windows.Security.Cryptography.Certificates;

namespace Windows.Web.Http.Filters
{
  /// <summary>Provides data for the ServerCustomValidationRequested event.</summary>
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [DualApiPartition(version = 167772160)]
  public sealed class HttpServerCustomValidationRequestedEventArgs : 
    IHttpServerCustomValidationRequestedEventArgs
  {
    /// <summary>Gets the HTTP request containing the destination URI, headers, and body.</summary>
    /// <returns>The HTTP request containing the destination URI, headers, and body.</returns>
    public extern HttpRequestMessage RequestMessage { [MethodImpl] get; }

    /// <summary>Gets the X509Certificate provided by the server.</summary>
    /// <returns>The X509Certificate provided by the server.</returns>
    public extern Certificate ServerCertificate { [MethodImpl] get; }

    /// <summary>Gets the severity level of errors encountered.</summary>
    /// <returns>The severity level of errors encountered.</returns>
    public extern SocketSslErrorSeverity ServerCertificateErrorSeverity { [MethodImpl] get; }

    /// <summary>Gets the errors that the OS validation logic has found in this certificate or the chain.</summary>
    /// <returns>The errors that the OS validation logic has found in this certificate or the chain.</returns>
    public extern IVectorView<ChainValidationResult> ServerCertificateErrors { [MethodImpl] get; }

    /// <summary>Gets the chain of intermediate certificates, ending in the root CA associated with the remote certificate.</summary>
    /// <returns>The chain of intermediate certificates, ending in the root CA associated with the remote certificate.</returns>
    public extern IVectorView<Certificate> ServerIntermediateCertificates { [MethodImpl] get; }

    /// <summary>Reject the server's certificate. This will result in the client terminating the connection to the server.</summary>
    [MethodImpl]
    public extern void Reject();

    /// <summary>Requests that suspension of the event handler be delayed until the deferral is completed by calling the Complete method on the Deferral object.</summary>
    /// <returns>The deferral object.</returns>
    [MethodImpl]
    public extern Deferral GetDeferral();
  }
}
