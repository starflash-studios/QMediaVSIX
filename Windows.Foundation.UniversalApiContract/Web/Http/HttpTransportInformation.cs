// Decompiled with JetBrains decompiler
// Type: Windows.Web.Http.HttpTransportInformation
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Networking.Sockets;
using Windows.Security.Cryptography.Certificates;

namespace Windows.Web.Http
{
  /// <summary>Provides information about the underlying transport used by the HTTP connection.</summary>
  [DualApiPartition(version = 100859904)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class HttpTransportInformation : IHttpTransportInformation, IStringable
  {
    /// <summary>Gets the certificate from the server with the SSL information.</summary>
    /// <returns>The certificate from the server with the SSL information.</returns>
    public extern Certificate ServerCertificate { [MethodImpl] get; }

    /// <summary>Gets the category of an error on an SSL connection.</summary>
    /// <returns>The category of error on an SSL connection.</returns>
    public extern SocketSslErrorSeverity ServerCertificateErrorSeverity { [MethodImpl] get; }

    /// <summary>Gets the list of errors that occurred making an SSL connection.</summary>
    /// <returns>The list of errors that occurred making an SSL connection.</returns>
    public extern IVectorView<ChainValidationResult> ServerCertificateErrors { [MethodImpl] get; }

    /// <summary>Gets the intermediate certificates sent by the server during SSL negotiation on this HttpTransportInformation object.</summary>
    /// <returns>The set of certificates sent by the server during SSL negotiation on this HttpTransportInformation object.</returns>
    public extern IVectorView<Certificate> ServerIntermediateCertificates { [MethodImpl] get; }

    /// <summary>Returns a string that represents the current HttpTransportInformation object.</summary>
    /// <returns>A string that represents the current object.</returns>
    [MethodImpl]
    public new extern string ToString();
  }
}
