// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Email.DataProvider.IEmailDataProviderConnection
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Email.DataProvider
{
  [ExclusiveTo(typeof (EmailDataProviderConnection))]
  [Guid(1000119751, 14258, 19440, 174, 48, 123, 100, 74, 28, 150, 225)]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  internal interface IEmailDataProviderConnection
  {
    event TypedEventHandler<EmailDataProviderConnection, EmailMailboxSyncManagerSyncRequestEventArgs> MailboxSyncRequested;

    event TypedEventHandler<EmailDataProviderConnection, EmailMailboxDownloadMessageRequestEventArgs> DownloadMessageRequested;

    event TypedEventHandler<EmailDataProviderConnection, EmailMailboxDownloadAttachmentRequestEventArgs> DownloadAttachmentRequested;

    event TypedEventHandler<EmailDataProviderConnection, EmailMailboxCreateFolderRequestEventArgs> CreateFolderRequested;

    event TypedEventHandler<EmailDataProviderConnection, EmailMailboxDeleteFolderRequestEventArgs> DeleteFolderRequested;

    event TypedEventHandler<EmailDataProviderConnection, EmailMailboxEmptyFolderRequestEventArgs> EmptyFolderRequested;

    event TypedEventHandler<EmailDataProviderConnection, EmailMailboxMoveFolderRequestEventArgs> MoveFolderRequested;

    event TypedEventHandler<EmailDataProviderConnection, EmailMailboxUpdateMeetingResponseRequestEventArgs> UpdateMeetingResponseRequested;

    event TypedEventHandler<EmailDataProviderConnection, EmailMailboxForwardMeetingRequestEventArgs> ForwardMeetingRequested;

    event TypedEventHandler<EmailDataProviderConnection, EmailMailboxProposeNewTimeForMeetingRequestEventArgs> ProposeNewTimeForMeetingRequested;

    event TypedEventHandler<EmailDataProviderConnection, EmailMailboxSetAutoReplySettingsRequestEventArgs> SetAutoReplySettingsRequested;

    event TypedEventHandler<EmailDataProviderConnection, EmailMailboxGetAutoReplySettingsRequestEventArgs> GetAutoReplySettingsRequested;

    event TypedEventHandler<EmailDataProviderConnection, EmailMailboxResolveRecipientsRequestEventArgs> ResolveRecipientsRequested;

    event TypedEventHandler<EmailDataProviderConnection, EmailMailboxValidateCertificatesRequestEventArgs> ValidateCertificatesRequested;

    event TypedEventHandler<EmailDataProviderConnection, EmailMailboxServerSearchReadBatchRequestEventArgs> ServerSearchReadBatchRequested;

    void Start();
  }
}
