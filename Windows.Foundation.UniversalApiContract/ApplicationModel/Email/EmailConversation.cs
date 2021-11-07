// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Email.EmailConversation
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Email
{
  /// <summary>Represents an email conversation.</summary>
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class EmailConversation : IEmailConversation
  {
    /// <summary>Gets the unique identifier for the EmailConversation.</summary>
    /// <returns>The unique identifier for the EmailConversation.</returns>
    public extern string Id { [MethodImpl] get; }

    /// <summary>Gets the ID for the mailbox.</summary>
    /// <returns>The ID for the mailbox.</returns>
    public extern string MailboxId { [MethodImpl] get; }

    /// <summary>Gets the EmailFlagState for the conversation.</summary>
    /// <returns>The EmailFlagState for the conversation.</returns>
    public extern EmailFlagState FlagState { [MethodImpl] get; }

    /// <summary>Gets a Boolean value indicating if the conversation has an attachment.</summary>
    /// <returns>A Boolean value indicating if the conversation has an attachment.</returns>
    public extern bool HasAttachment { [MethodImpl] get; }

    /// <summary>Gets the value that specifies the importance of the conversation; normal, high or low.</summary>
    /// <returns>The value that specifies the importance of the conversation; normal, high or low.</returns>
    public extern EmailImportance Importance { [MethodImpl] get; }

    /// <summary>Gets the last EmailMessageResponseKind for the conversation.</summary>
    /// <returns>The last EmailMessageResponseKind for the conversation.</returns>
    public extern EmailMessageResponseKind LastEmailResponseKind { [MethodImpl] get; }

    /// <summary>Gets the number of messages in the conversation.</summary>
    /// <returns>The number of messages in the conversation.</returns>
    public extern uint MessageCount { [MethodImpl] get; }

    /// <summary>Gets the ID of the most recent message in the conversation.</summary>
    /// <returns>The ID of the most recent message in the conversation.</returns>
    public extern string MostRecentMessageId { [MethodImpl] get; }

    /// <summary>Gets the time of the most recent message in the conversation.</summary>
    /// <returns>The time of the most recent message in the conversation.</returns>
    public extern DateTime MostRecentMessageTime { [MethodImpl] get; }

    /// <summary>Gets a preview of the latest message in the conversation.</summary>
    /// <returns>A preview of the latest message in the conversation.</returns>
    public extern string Preview { [MethodImpl] get; }

    /// <summary>Gets the latest sender in the conversation.</summary>
    /// <returns>The latest sender in the conversation.</returns>
    public extern EmailRecipient LatestSender { [MethodImpl] get; }

    /// <summary>Gets the subject of the latest message in the conversation.</summary>
    /// <returns>The subject of the latest message in the conversation.</returns>
    public extern string Subject { [MethodImpl] get; }

    /// <summary>Gets the number of unread messages in the conversation.</summary>
    /// <returns>The number of unread messages in the conversation.</returns>
    public extern uint UnreadMessageCount { [MethodImpl] get; }

    /// <summary>Asynchronously gets a batch of messages in the conversation.</summary>
    /// <returns>The batch of messages.</returns>
    [Overload("FindMessagesAsync")]
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<IVectorView<EmailMessage>> FindMessagesAsync();

    /// <summary>Asynchronously gets a batch of messages in the conversation.</summary>
    /// <param name="count">The size of the batch of messages to retrieve.</param>
    /// <returns>The batch of messages.</returns>
    [Overload("FindMessagesWithCountAsync")]
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<IVectorView<EmailMessage>> FindMessagesAsync(
      uint count);
  }
}
