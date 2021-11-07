// Decompiled with JetBrains decompiler
// Type: Windows.Devices.AllJoyn.IAllJoynCredentialsVerificationRequestedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Networking.Sockets;
using Windows.Security.Cryptography.Certificates;

namespace Windows.Devices.AllJoyn
{
  [Deprecated("AllJoynCredentialsVerificationRequestedEventArgs has been deprecated.  For more info, see MSDN.", DeprecationType.Deprecate, 786432, "Windows.Foundation.UniversalApiContract")]
  [ExclusiveTo(typeof (AllJoynCredentialsVerificationRequestedEventArgs))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(2148169234, 47109, 17583, 162, 225, 121, 42, 182, 85, 162, 208)]
  internal interface IAllJoynCredentialsVerificationRequestedEventArgs
  {
    AllJoynAuthenticationMechanism AuthenticationMechanism { [Deprecated("AllJoynCredentialsVerificationRequestedEventArgs has been deprecated.  For more info, see MSDN.", DeprecationType.Deprecate, 786432, "Windows.Foundation.UniversalApiContract")] get; }

    string PeerUniqueName { [Deprecated("AllJoynCredentialsVerificationRequestedEventArgs has been deprecated.  For more info, see MSDN.", DeprecationType.Deprecate, 786432, "Windows.Foundation.UniversalApiContract")] get; }

    Certificate PeerCertificate { [Deprecated("AllJoynCredentialsVerificationRequestedEventArgs has been deprecated.  For more info, see MSDN.", DeprecationType.Deprecate, 786432, "Windows.Foundation.UniversalApiContract")] get; }

    SocketSslErrorSeverity PeerCertificateErrorSeverity { [Deprecated("AllJoynCredentialsVerificationRequestedEventArgs has been deprecated.  For more info, see MSDN.", DeprecationType.Deprecate, 786432, "Windows.Foundation.UniversalApiContract")] get; }

    IVectorView<ChainValidationResult> PeerCertificateErrors { [Deprecated("AllJoynCredentialsVerificationRequestedEventArgs has been deprecated.  For more info, see MSDN.", DeprecationType.Deprecate, 786432, "Windows.Foundation.UniversalApiContract")] get; }

    IVectorView<Certificate> PeerIntermediateCertificates { [Deprecated("AllJoynCredentialsVerificationRequestedEventArgs has been deprecated.  For more info, see MSDN.", DeprecationType.Deprecate, 786432, "Windows.Foundation.UniversalApiContract")] get; }

    [Deprecated("AllJoynCredentialsVerificationRequestedEventArgs has been deprecated.  For more info, see MSDN.", DeprecationType.Deprecate, 786432, "Windows.Foundation.UniversalApiContract")]
    void Accept();

    [Deprecated("AllJoynCredentialsVerificationRequestedEventArgs has been deprecated.  For more info, see MSDN.", DeprecationType.Deprecate, 786432, "Windows.Foundation.UniversalApiContract")]
    Deferral GetDeferral();
  }
}
