// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.UserDataAccounts.SystemAccess.IDeviceAccountConfiguration2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Security.Credentials;

namespace Windows.ApplicationModel.UserDataAccounts.SystemAccess
{
  [ExclusiveTo(typeof (DeviceAccountConfiguration))]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [Guid(4071810470, 29325, 19018, 137, 69, 43, 248, 88, 1, 54, 222)]
  internal interface IDeviceAccountConfiguration2
  {
    PasswordCredential IncomingServerCredential { get; set; }

    PasswordCredential OutgoingServerCredential { get; set; }

    string OAuthRefreshToken { get; set; }

    bool IsExternallyManaged { get; set; }

    DeviceAccountIconId AccountIconId { get; set; }

    DeviceAccountAuthenticationType AuthenticationType { get; set; }

    bool IsSsoAuthenticationSupported { get; }

    string SsoAccountId { get; set; }

    bool AlwaysDownloadFullMessage { get; set; }

    bool DoesPolicyAllowMailSync { get; }

    DeviceAccountSyncScheduleKind SyncScheduleKind { get; set; }

    DeviceAccountMailAgeFilter MailAgeFilter { get; set; }

    bool IsClientAuthenticationCertificateRequired { get; set; }

    bool AutoSelectAuthenticationCertificate { get; set; }

    string AuthenticationCertificateId { get; set; }

    DeviceAccountSyncScheduleKind CardDavSyncScheduleKind { get; set; }

    DeviceAccountSyncScheduleKind CalDavSyncScheduleKind { get; set; }

    Uri CardDavServerUrl { get; set; }

    bool CardDavRequiresSsl { get; set; }

    Uri CalDavServerUrl { get; set; }

    bool CalDavRequiresSsl { get; set; }

    bool WasModifiedByUser { get; set; }

    bool WasIncomingServerCertificateHashConfirmed { get; set; }

    string IncomingServerCertificateHash { get; set; }

    bool IsOutgoingServerAuthenticationRequired { get; set; }

    bool IsOutgoingServerAuthenticationEnabled { get; set; }

    bool WasOutgoingServerCertificateHashConfirmed { get; set; }

    string OutgoingServerCertificateHash { get; set; }

    bool IsSyncScheduleManagedBySystem { get; set; }
  }
}
