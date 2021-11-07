// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Email.DataProvider.EmailMailboxServerSearchReadBatchRequest
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Email.DataProvider
{
  /// <summary>Details of a request to read a batch of server-side search results.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  public sealed class EmailMailboxServerSearchReadBatchRequest : 
    IEmailMailboxServerSearchReadBatchRequest
  {
    /// <summary>Gets the search session ID of this server-side batch read request.</summary>
    /// <returns>A search session ID.</returns>
    public extern string SessionId { [MethodImpl] get; }

    /// <summary>Gets the mailbox ID of the mailbox where the search is to be performed.</summary>
    /// <returns>A mailbox ID.</returns>
    public extern string EmailMailboxId { [MethodImpl] get; }

    /// <summary>Gets the folder ID of the folder where the search is to be performed.</summary>
    /// <returns>A folder ID.</returns>
    public extern string EmailFolderId { [MethodImpl] get; }

    /// <summary>Gets the search options to be applied to this search.</summary>
    /// <returns>An EmailQueryOptions object specifying the search options.</returns>
    public extern EmailQueryOptions Options { [MethodImpl] get; }

    /// <summary>Gets the suggested batch size for the server-side search batch read.</summary>
    /// <returns>The suggested number of messages in a batch. Clients suggest a batch size based on client-side criteria such as screen real estate, storage capacity, or bandwidth.</returns>
    public extern uint SuggestedBatchSize { [MethodImpl] get; }

    /// <summary>Saves a message that meets server-side search criteria.</summary>
    /// <param name="message">A message that matches the search criteria of a server-side batch read request.</param>
    /// <returns>An asynchronous message save operation on an EmailMailboxServerSearchReadBatchRequest.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction SaveMessageAsync(EmailMessage message);

    /// <summary>Informs the email client that the request was processed successfully.</summary>
    /// <returns>An asynchronous batch read request operation on an EmailMailboxServerSearchReadBatchRequest.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction ReportCompletedAsync();

    /// <summary>Informs the client that the request was not processed successfully.</summary>
    /// <param name="batchStatus">An EmailBatchStatus value describing the current status of the batch.</param>
    /// <returns>An asynchronous batch read request operation on an EmailMailboxServerSearchReadBatchRequest.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction ReportFailedAsync(EmailBatchStatus batchStatus);
  }
}
