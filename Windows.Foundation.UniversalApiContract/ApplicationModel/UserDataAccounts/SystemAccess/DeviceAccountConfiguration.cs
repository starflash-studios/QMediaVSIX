// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.UserDataAccounts.SystemAccess.DeviceAccountConfiguration
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Security.Credentials;

namespace Windows.ApplicationModel.UserDataAccounts.SystemAccess
{
  /// <summary>Represents device settings for app sync relationships.</summary>
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  public sealed class DeviceAccountConfiguration : 
    IDeviceAccountConfiguration,
    IDeviceAccountConfiguration2
  {
    /// <summary>Initializes a new instance of the DeviceAccountConfiguration class.</summary>
    [MethodImpl]
    public extern DeviceAccountConfiguration();

    /// <summary>Gets or sets the name that identifies the device account.</summary>
    /// <returns>The name that identifies the device account.</returns>
    public extern string AccountName { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the value that identifies the device account type.</summary>
    /// <returns>The value that identifies the device account type.</returns>
    public extern string DeviceAccountTypeId { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a value indicating the type of the server.</summary>
    /// <returns>Enum value indicating the type of the server.</returns>
    public extern DeviceAccountServerType ServerType { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the email address of the current user.</summary>
    /// <returns>The email address of the current user.</returns>
    public extern string EmailAddress { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the network domain of the device.</summary>
    /// <returns>The network domain of the device.</returns>
    public extern string Domain { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a Boolean value indicating if email syncing is enabled.</summary>
    /// <returns>A Boolean value indicating if email syncing is enabled.</returns>
    public extern bool EmailSyncEnabled { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a Boolean value indicating if contacts syncing is enabled.</summary>
    /// <returns>A Boolean value indicating if contacts syncing is enabled.</returns>
    public extern bool ContactsSyncEnabled { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a Boolean value indicating if calendar syncing is enabled.</summary>
    /// <returns>A Boolean value indicating if calendar syncing is enabled.</returns>
    public extern bool CalendarSyncEnabled { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the incoming email server address.</summary>
    /// <returns>The incoming email server address.</returns>
    public extern string IncomingServerAddress { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the port number to use to connect to the incoming email server.</summary>
    /// <returns>The port number to use to connect to the incoming email server.</returns>
    public extern int IncomingServerPort { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a Boolean value indicating if Secure Sockets Layer (SSL) should be used when connecting to the incoming email server.</summary>
    /// <returns>A Boolean value indicating if Secure Sockets Layer (SSL) should be used when connecting to the incoming email server.</returns>
    public extern bool IncomingServerRequiresSsl { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the username to use when connecting to the incoming email server.</summary>
    /// <returns>The username to use when connecting to the incoming email server.</returns>
    public extern string IncomingServerUsername { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the outgoing email server address.</summary>
    /// <returns>The outgoing email server address.</returns>
    public extern string OutgoingServerAddress { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the port number to use to connect to the outgoing email server.</summary>
    /// <returns>The port number to use to connect to the outgoing email server.</returns>
    public extern int OutgoingServerPort { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a Boolean value indicating if Secure Sockets Layer (SSL) should be used when connecting to the outgoing email server.</summary>
    /// <returns>A Boolean value indicating if Secure Sockets Layer (SSL) should be used when connecting to the outgoing email server.</returns>
    public extern bool OutgoingServerRequiresSsl { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the username to use when connecting to the outgoing email server.</summary>
    /// <returns>The username to use when connecting to the outgoing email server.</returns>
    public extern string OutgoingServerUsername { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the incoming mail server's password.</summary>
    /// <returns>The incoming mail server's password.</returns>
    public extern PasswordCredential IncomingServerCredential { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the outgoing mail server's password.</summary>
    /// <returns>The outgoing mail server's password.</returns>
    public extern PasswordCredential OutgoingServerCredential { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the OAuth refresh token used to create a new access token.</summary>
    /// <returns>The OAuth refresh token used to create a new access token.</returns>
    public extern string OAuthRefreshToken { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a Boolean value that indicates if the device account is managed outside the organization.</summary>
    /// <returns>A Boolean value that indicates if the device account is managed outside the organization.</returns>
    public extern bool IsExternallyManaged { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the identifier for the device account icon.</summary>
    /// <returns>The identifier for the device account icon.</returns>
    public extern DeviceAccountIconId AccountIconId { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the DeviceAccountAuthenticationType for this account.</summary>
    /// <returns>The DeviceAccountAuthenticationType for this account.</returns>
    public extern DeviceAccountAuthenticationType AuthenticationType { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a Boolean value indicating if single sign on (SSO) authentication is supported by the server.</summary>
    /// <returns>A Boolean value indicating if single sign on (SSO) authentication is supported by the server.</returns>
    public extern bool IsSsoAuthenticationSupported { [MethodImpl] get; }

    /// <summary>Gets or sets the single sign on account ID.</summary>
    /// <returns>The single sign on account ID.</returns>
    public extern string SsoAccountId { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a Boolean value indicating if the full email message should always be downloaded as opposed to only header information.</summary>
    /// <returns>A Boolean value indicating if the full email message should always be downloaded.</returns>
    public extern bool AlwaysDownloadFullMessage { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets a Boolean value that indicates if this device is allowed to sync with the email server.</summary>
    /// <returns>A Boolean value that indicates if this device is allowed to sync with the email server.</returns>
    public extern bool DoesPolicyAllowMailSync { [MethodImpl] get; }

    /// <summary>Gets or sets an enum value that specifies how often the account is synced.</summary>
    /// <returns>An enum value that specifies how often the account is synced.</returns>
    public extern DeviceAccountSyncScheduleKind SyncScheduleKind { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets an enum value that indicates how many days of email to keep on the client.</summary>
    /// <returns>An enum value that indicates how many days of email to keep on the client.</returns>
    public extern DeviceAccountMailAgeFilter MailAgeFilter { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a Boolean value indicating if a client authentication certificate is required by the server.</summary>
    /// <returns>A Boolean value indicating if a client authentication certificate is required by the server.</returns>
    public extern bool IsClientAuthenticationCertificateRequired { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a Boolean value that indicates if the authentication certificate should be automatically selected.</summary>
    /// <returns>A Boolean value that indicates if the authentication certificate should be automatically selected.</returns>
    public extern bool AutoSelectAuthenticationCertificate { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the identifier for the authentication certificate for this account.</summary>
    /// <returns>The identifier for the authentication certificate for this account.</returns>
    public extern string AuthenticationCertificateId { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets an enum value that specifies how often the account is synced.</summary>
    /// <returns>An enum value that specifies how often the account is synced.</returns>
    public extern DeviceAccountSyncScheduleKind CardDavSyncScheduleKind { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets an enum value that specifies how often the account is synced.</summary>
    /// <returns>An enum value that specifies how often the account is synced.</returns>
    public extern DeviceAccountSyncScheduleKind CalDavSyncScheduleKind { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the address of the CardDav server.</summary>
    /// <returns>The address of the CardDav server.</returns>
    public extern Uri CardDavServerUrl { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a Boolean value that indicates if the CardDav server requires an SSL connection.</summary>
    /// <returns>A Boolean value that indicates if the CardDav server requires an SSL connection.</returns>
    public extern bool CardDavRequiresSsl { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the address of the CalDav server.</summary>
    /// <returns>The address of the CalDav server.</returns>
    public extern Uri CalDavServerUrl { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a Boolean value that indicates if the CalDav server requires an SSL connection.</summary>
    /// <returns>A Boolean value that indicates if the CalDav server requires an SSL connection.</returns>
    public extern bool CalDavRequiresSsl { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a Boolean value that indicates if the account has been modified by the user.</summary>
    /// <returns>A Boolean value that indicates if the account has been modified by the user.</returns>
    public extern bool WasModifiedByUser { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a Boolean value indicating if the incoming server's certificate hash has been confirmed.</summary>
    /// <returns>A Boolean value indicating if the incoming server's certificate hash has been confirmed.</returns>
    public extern bool WasIncomingServerCertificateHashConfirmed { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the incoming mail server's encryption certificate hash.</summary>
    /// <returns>The incoming mail server's encryption certificate hash.</returns>
    public extern string IncomingServerCertificateHash { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a Boolean value indicating if authentication is required by the outgoing mail server.</summary>
    /// <returns>A Boolean value indicating if authentication is required by the outgoing mail server.</returns>
    public extern bool IsOutgoingServerAuthenticationRequired { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a Boolean value indicating if authentication is enabled for the outgoing mail server.</summary>
    /// <returns>A Boolean value indicating if authentication is enabled for the outgoing mail server.</returns>
    public extern bool IsOutgoingServerAuthenticationEnabled { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a Boolean value indicating if the outgoing server's certificate hash has been confirmed.</summary>
    /// <returns>A Boolean value indicating if the outgoing server's certificate hash has been confirmed.</returns>
    public extern bool WasOutgoingServerCertificateHashConfirmed { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the outgoing mail server's encryption certificate hash.</summary>
    /// <returns>The outgoing mail server's encryption certificate hash.</returns>
    public extern string OutgoingServerCertificateHash { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets a Boolean value that indicates if the sync schedule is managed by the system as opposed to the app.</summary>
    /// <returns>A Boolean value that indicates if the sync schedule is managed by the system as opposed to the app.</returns>
    public extern bool IsSyncScheduleManagedBySystem { [MethodImpl] get; [MethodImpl] set; }
  }
}
