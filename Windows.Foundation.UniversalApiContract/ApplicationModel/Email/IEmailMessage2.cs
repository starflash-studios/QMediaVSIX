// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Email.IEmailMessage2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.ApplicationModel.Email
{
  [Guid(4257752203, 40730, 17627, 189, 60, 101, 195, 132, 119, 15, 134)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (EmailMessage))]
  internal interface IEmailMessage2
  {
    string Id { get; }

    string RemoteId { get; set; }

    string MailboxId { get; }

    string ConversationId { get; }

    string FolderId { get; }

    bool AllowInternetImages { get; set; }

    ulong ChangeNumber { get; }

    EmailMessageDownloadState DownloadState { get; set; }

    uint EstimatedDownloadSizeInBytes { get; set; }

    EmailFlagState FlagState { get; set; }

    bool HasPartialBodies { get; }

    EmailImportance Importance { get; set; }

    string InResponseToMessageId { get; }

    EmailIrmInfo IrmInfo { get; set; }

    bool IsDraftMessage { get; }

    bool IsRead { get; set; }

    bool IsSeen { get; set; }

    bool IsServerSearchMessage { get; }

    bool IsSmartSendable { get; }

    string MessageClass { get; set; }

    string NormalizedSubject { get; }

    int OriginalCodePage { get; set; }

    string Preview { get; set; }

    EmailMessageResponseKind LastResponseKind { get; set; }

    EmailRecipient Sender { get; set; }

    IReference<DateTime> SentTime { get; set; }

    EmailMeetingInfo MeetingInfo { get; set; }

    IRandomAccessStreamReference GetBodyStream(EmailMessageBodyKind type);

    void SetBodyStream(EmailMessageBodyKind type, IRandomAccessStreamReference stream);
  }
}
