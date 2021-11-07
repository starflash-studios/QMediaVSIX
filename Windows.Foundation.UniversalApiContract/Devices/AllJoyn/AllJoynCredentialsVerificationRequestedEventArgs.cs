// Decompiled with JetBrains decompiler
// Type: Windows.Devices.AllJoyn.AllJoynCredentialsVerificationRequestedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Networking.Sockets;
using Windows.Security.Cryptography.Certificates;

namespace Windows.Devices.AllJoyn
{
  /// <summary>Used to allow the application to indicate whether the credentials provided by a peer are valid.</summary>
  [Deprecated("AllJoynCredentialsVerificationRequestedEventArgs has been deprecated.  For more info, see MSDN.", DeprecationType.Deprecate, 786432, "Windows.Foundation.UniversalApiContract")]
  [DualApiPartition(version = 167772160)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class AllJoynCredentialsVerificationRequestedEventArgs : 
    IAllJoynCredentialsVerificationRequestedEventArgs
  {
    /// <summary>The mechanism used to authenticate credentials.</summary>
    /// <returns>The authentication mechanism.</returns>
    public extern AllJoynAuthenticationMechanism AuthenticationMechanism { [Deprecated("AllJoynCredentialsVerificationRequestedEventArgs has been deprecated.  For more info, see MSDN.", DeprecationType.Deprecate, 786432, "Windows.Foundation.UniversalApiContract"), MethodImpl] get; }

    /// <summary>The unique bus name of the remote app being authenticated.</summary>
    /// <returns>A unique bus name.</returns>
    public extern string PeerUniqueName { [Deprecated("AllJoynCredentialsVerificationRequestedEventArgs has been deprecated.  For more info, see MSDN.", DeprecationType.Deprecate, 786432, "Windows.Foundation.UniversalApiContract"), MethodImpl] get; }

    /// <summary>The cryptography certificate provided for authentication.</summary>
    /// <returns>The cryptography certificate.</returns>
    public extern Certificate PeerCertificate { [Deprecated("AllJoynCredentialsVerificationRequestedEventArgs has been deprecated.  For more info, see MSDN.", DeprecationType.Deprecate, 786432, "Windows.Foundation.UniversalApiContract"), MethodImpl] get; }

    /// <summary>The category of an errors encountered authenticating the cryptography certificate.</summary>
    /// <returns>The severity of the error.</returns>
    public extern SocketSslErrorSeverity PeerCertificateErrorSeverity { [Deprecated("AllJoynCredentialsVerificationRequestedEventArgs has been deprecated.  For more info, see MSDN.", DeprecationType.Deprecate, 786432, "Windows.Foundation.UniversalApiContract"), MethodImpl] get; }

    /// <summary>A list of errors that occurred during authentication of the provided cryptography certificate.</summary>
    /// <returns>A list of credential errors.</returns>
    public extern IVectorView<ChainValidationResult> PeerCertificateErrors { [Deprecated("AllJoynCredentialsVerificationRequestedEventArgs has been deprecated.  For more info, see MSDN.", DeprecationType.Deprecate, 786432, "Windows.Foundation.UniversalApiContract"), MethodImpl] get; }

    /// <summary>Retrieves the intermediate certificates sent during authentication.</summary>
    /// <returns>A list of the intermediate certificates.</returns>
    public extern IVectorView<Certificate> PeerIntermediateCertificates { [Deprecated("AllJoynCredentialsVerificationRequestedEventArgs has been deprecated.  For more info, see MSDN.", DeprecationType.Deprecate, 786432, "Windows.Foundation.UniversalApiContract"), MethodImpl] get; }

    /// <summary>Calling this method indicates that the credentials provided for authentication are valid.</summary>
    [Deprecated("AllJoynCredentialsVerificationRequestedEventArgs has been deprecated.  For more info, see MSDN.", DeprecationType.Deprecate, 786432, "Windows.Foundation.UniversalApiContract")]
    [MethodImpl]
    public extern void Accept();

    /// <summary>Conducts verification of provided of credentials asynchronously.</summary>
    /// <returns>The verification deferral.</returns>
    [Deprecated("AllJoynCredentialsVerificationRequestedEventArgs has been deprecated.  For more info, see MSDN.", DeprecationType.Deprecate, 786432, "Windows.Foundation.UniversalApiContract")]
    [MethodImpl]
    public extern Deferral GetDeferral();
  }
}
