// Decompiled with JetBrains decompiler
// Type: Windows.Networking.Vpn.VpnManagementErrorStatus
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Networking.Vpn
{
  /// <summary>Describes the known VPN management errors.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum VpnManagementErrorStatus
  {
    /// <summary>No error.</summary>
    Ok,
    /// <summary>Other</summary>
    Other,
    /// <summary>Invalid XML syntax</summary>
    InvalidXmlSyntax,
    /// <summary>The profile name is too long.</summary>
    ProfileNameTooLong,
    /// <summary>The app id is invalid.</summary>
    ProfileInvalidAppId,
    /// <summary>Access is denied.</summary>
    AccessDenied,
    /// <summary>A specified profile cannot be found.</summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 196608)] CannotFindProfile,
    /// <summary>The connection is in the process of being disconnected.</summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 196608)] AlreadyDisconnecting,
    /// <summary>The connection already exists.</summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 196608)] AlreadyConnected,
    /// <summary>Connection failed during authentication. No further details available.</summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 196608)] GeneralAuthenticationFailure,
    /// <summary>EAP authentication has failed.</summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 196608)] EapFailure,
    /// <summary>Smart Card authentication has failed.</summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 196608)] SmartCardFailure,
    /// <summary>Certificate authentication has failed.</summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 196608)] CertificateFailure,
    /// <summary>The server configuration is invalid.</summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 196608)] ServerConfiguration,
    /// <summary>No internet connection is available.</summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 196608)] NoConnection,
    /// <summary>Can't connect to the server.</summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 196608)] ServerConnection,
    /// <summary>User name/password authentication has failed.</summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 196608)] UserNamePassword,
    /// <summary>A given hostname was not resolvable through the available DNS.</summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 196608)] DnsNotResolvable,
    /// <summary>A given IP address was invalid.</summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 196608)] InvalidIP,
  }
}
