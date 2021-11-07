// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Email.DataProvider.EmailDataProviderConnection
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Email.DataProvider
{
  /// <summary>Represents a connection to a data provider client.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [Threading(ThreadingModel.Both)]
  public sealed class EmailDataProviderConnection : IEmailDataProviderConnection
  {
    /// <summary>Occurs when the email client has requested to sync with the mailbox on the server.</summary>
    public extern event TypedEventHandler<EmailDataProviderConnection, EmailMailboxSyncManagerSyncRequestEventArgs> MailboxSyncRequested;

    /// <summary>Occurs when the email client has requested to download a message from the server.</summary>
    public extern event TypedEventHandler<EmailDataProviderConnection, EmailMailboxDownloadMessageRequestEventArgs> DownloadMessageRequested;

    /// <summary>Occurs when the email client has requested to download an attachment from the server.</summary>
    public extern event TypedEventHandler<EmailDataProviderConnection, EmailMailboxDownloadAttachmentRequestEventArgs> DownloadAttachmentRequested;

    /// <summary>Occurs when the email client has requested that a folder be created on the server.</summary>
    public extern event TypedEventHandler<EmailDataProviderConnection, EmailMailboxCreateFolderRequestEventArgs> CreateFolderRequested;

    /// <summary>Occurs when the email client has requested that a folder be deleted on the server.</summary>
    public extern event TypedEventHandler<EmailDataProviderConnection, EmailMailboxDeleteFolderRequestEventArgs> DeleteFolderRequested;

    /// <summary>Occurs when the email client has requested that a folder be emptied the server.</summary>
    public extern event TypedEventHandler<EmailDataProviderConnection, EmailMailboxEmptyFolderRequestEventArgs> EmptyFolderRequested;

    /// <summary>Occurs when the email client has requested that a folder be moved on the server.</summary>
    public extern event TypedEventHandler<EmailDataProviderConnection, EmailMailboxMoveFolderRequestEventArgs> MoveFolderRequested;

    /// <summary>Occurs when the email client has requested that a meeting response be updated.</summary>
    public extern event TypedEventHandler<EmailDataProviderConnection, EmailMailboxUpdateMeetingResponseRequestEventArgs> UpdateMeetingResponseRequested;

    /// <summary>Occurs when the email client has requested to forward a meeting request.</summary>
    public extern event TypedEventHandler<EmailDataProviderConnection, EmailMailboxForwardMeetingRequestEventArgs> ForwardMeetingRequested;

    /// <summary>Occurs when the email client has requested that a new meeting time be proposed.</summary>
    public extern event TypedEventHandler<EmailDataProviderConnection, EmailMailboxProposeNewTimeForMeetingRequestEventArgs> ProposeNewTimeForMeetingRequested;

    /// <summary>Occurs when the email client has requested to set auto reply settings.</summary>
    public extern event TypedEventHandler<EmailDataProviderConnection, EmailMailboxSetAutoReplySettingsRequestEventArgs> SetAutoReplySettingsRequested;

    /// <summary>Occurs when the email client has requested the auto reply settings.</summary>
    public extern event TypedEventHandler<EmailDataProviderConnection, EmailMailboxGetAutoReplySettingsRequestEventArgs> GetAutoReplySettingsRequested;

    /// <summary>Occurs when the email client has requested that the recipients of a message be resolved.</summary>
    public extern event TypedEventHandler<EmailDataProviderConnection, EmailMailboxResolveRecipientsRequestEventArgs> ResolveRecipientsRequested;

    /// <summary>Occurs when the email client has requested that certificates be validated with respect to a particular mailbox.</summary>
    public extern event TypedEventHandler<EmailDataProviderConnection, EmailMailboxValidateCertificatesRequestEventArgs> ValidateCertificatesRequested;

    /// <summary>Occurs when the email client has requested a batch of server-side search results.</summary>
    public extern event TypedEventHandler<EmailDataProviderConnection, EmailMailboxServerSearchReadBatchRequestEventArgs> ServerSearchReadBatchRequested;

    /// <summary>Call this method to indicate that all event handlers have been set, and the data provider is ready to start handling requests.</summary>
    [MethodImpl]
    public extern void Start();
  }
}
