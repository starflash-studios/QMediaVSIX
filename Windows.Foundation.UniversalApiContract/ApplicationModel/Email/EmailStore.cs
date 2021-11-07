// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Email.EmailStore
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Email
{
  /// <summary>The functionality described in this topic is not available to all UWP apps. As part of the store app submission process, Microsoft must approve your use of these APIs and provision your developer account before you can publish an app that uses them.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Threading(ThreadingModel.Both)]
  public sealed class EmailStore : IEmailStore
  {
    /// <summary>Gets all mailboxes within the current scope.</summary>
    /// <returns>A collection of mailboxes.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<IVectorView<EmailMailbox>> FindMailboxesAsync();

    /// <summary>Gets a batch of email conversations.</summary>
    /// <returns>A batch of email conversations.</returns>
    [Overload("GetConversationReader")]
    [MethodImpl]
    public extern EmailConversationReader GetConversationReader();

    /// <summary>Gets a batch of email conversations using the specified email query options.</summary>
    /// <param name="options">The email query options.</param>
    /// <returns>A batch of email conversations.</returns>
    [Overload("GetConversationReaderWithOptions")]
    [MethodImpl]
    public extern EmailConversationReader GetConversationReader(
      EmailQueryOptions options);

    /// <summary>Gets a message reader.</summary>
    /// <returns>The email message reader.</returns>
    [Overload("GetMessageReader")]
    [MethodImpl]
    public extern EmailMessageReader GetMessageReader();

    /// <summary>Gets a message reader using the specified query options.</summary>
    /// <param name="options">Specified query options.</param>
    /// <returns>An email message reader.</returns>
    [Overload("GetMessageReaderWithOptions")]
    [MethodImpl]
    public extern EmailMessageReader GetMessageReader(EmailQueryOptions options);

    /// <summary>Gets a mailbox from an identifier.</summary>
    /// <param name="id">The identifier for the mailbox.</param>
    /// <returns>The mailbox described by the identifier.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<EmailMailbox> GetMailboxAsync(string id);

    /// <summary>Gets an email conversation from the provided identifier.</summary>
    /// <param name="id">The identifier of the conversation.</param>
    /// <returns>An email conversation.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<EmailConversation> GetConversationAsync(
      string id);

    /// <summary>Gets an email folder from an identifier.</summary>
    /// <param name="id">The identifier for the email folder.</param>
    /// <returns>The folder described by the identifier.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<EmailFolder> GetFolderAsync(string id);

    /// <summary>Gets the specified email message.</summary>
    /// <param name="id">The identifier for the email message.</param>
    /// <returns>The specified email message.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<EmailMessage> GetMessageAsync(string id);

    /// <summary>Allows an app to create an email account from an account name and an email address.</summary>
    /// <param name="accountName">The name of the account.</param>
    /// <param name="accountAddress">The email address associated with the account.</param>
    /// <returns>An email mailbox.</returns>
    [Overload("CreateMailboxAsync")]
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<EmailMailbox> CreateMailboxAsync(
      string accountName,
      string accountAddress);

    /// <summary>Allows an app to create an email account from an account name, an email address, and the user data account in which the mailbox will reside.</summary>
    /// <param name="accountName">The name of the account.</param>
    /// <param name="accountAddress">The email address associated with the account.</param>
    /// <param name="userDataAccountId">The user data account identifier associated with this user.</param>
    /// <returns>An email mailbox.</returns>
    [RemoteAsync]
    [Overload("CreateMailboxInAccountAsync")]
    [MethodImpl]
    public extern IAsyncOperation<EmailMailbox> CreateMailboxAsync(
      string accountName,
      string accountAddress,
      string userDataAccountId);
  }
}
