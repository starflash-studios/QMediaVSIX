// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Email.IEmailStore
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Email
{
  [ExclusiveTo(typeof (EmailStore))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(4160954990, 37175, 20363, 164, 112, 39, 154, 195, 5, 142, 182)]
  internal interface IEmailStore
  {
    [RemoteAsync]
    IAsyncOperation<IVectorView<EmailMailbox>> FindMailboxesAsync();

    [Overload("GetConversationReader")]
    EmailConversationReader GetConversationReader();

    [Overload("GetConversationReaderWithOptions")]
    EmailConversationReader GetConversationReader(EmailQueryOptions options);

    [Overload("GetMessageReader")]
    EmailMessageReader GetMessageReader();

    [Overload("GetMessageReaderWithOptions")]
    EmailMessageReader GetMessageReader(EmailQueryOptions options);

    [RemoteAsync]
    IAsyncOperation<EmailMailbox> GetMailboxAsync(string id);

    [RemoteAsync]
    IAsyncOperation<EmailConversation> GetConversationAsync(
      string id);

    [RemoteAsync]
    IAsyncOperation<EmailFolder> GetFolderAsync(string id);

    [RemoteAsync]
    IAsyncOperation<EmailMessage> GetMessageAsync(string id);

    [RemoteAsync]
    [Overload("CreateMailboxAsync")]
    IAsyncOperation<EmailMailbox> CreateMailboxAsync(
      string accountName,
      string accountAddress);

    [RemoteAsync]
    [Overload("CreateMailboxInAccountAsync")]
    IAsyncOperation<EmailMailbox> CreateMailboxAsync(
      string accountName,
      string accountAddress,
      string userDataAccountId);
  }
}
