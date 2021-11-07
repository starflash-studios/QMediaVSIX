// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Email.IEmailConversation
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Email
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(3659055688, 41148, 17225, 144, 45, 144, 246, 99, 137, 245, 27)]
  [ExclusiveTo(typeof (EmailConversation))]
  internal interface IEmailConversation
  {
    string Id { get; }

    string MailboxId { get; }

    EmailFlagState FlagState { get; }

    bool HasAttachment { get; }

    EmailImportance Importance { get; }

    EmailMessageResponseKind LastEmailResponseKind { get; }

    uint MessageCount { get; }

    string MostRecentMessageId { get; }

    DateTime MostRecentMessageTime { get; }

    string Preview { get; }

    EmailRecipient LatestSender { get; }

    string Subject { get; }

    uint UnreadMessageCount { get; }

    [Overload("FindMessagesAsync")]
    [RemoteAsync]
    IAsyncOperation<IVectorView<EmailMessage>> FindMessagesAsync();

    [Overload("FindMessagesWithCountAsync")]
    [RemoteAsync]
    IAsyncOperation<IVectorView<EmailMessage>> FindMessagesAsync(
      uint count);
  }
}
