// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Contacts.DataProvider.ContactListServerSearchReadBatchRequest
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Contacts.DataProvider
{
  /// <summary>Details of a request to read a batch of server-side search results.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [Threading(ThreadingModel.Both)]
  public sealed class ContactListServerSearchReadBatchRequest : 
    IContactListServerSearchReadBatchRequest
  {
    /// <summary>Gets the search session ID of this batch read request.</summary>
    /// <returns>A search session ID.</returns>
    public extern string SessionId { [MethodImpl] get; }

    /// <summary>Gets the contact list ID of the contact list to be searched.</summary>
    /// <returns>A contact list ID.</returns>
    public extern string ContactListId { [MethodImpl] get; }

    /// <summary>Gets the search options to be applied in this search.</summary>
    /// <returns>A ContactQueryOptions object specifying search options.</returns>
    public extern ContactQueryOptions Options { [MethodImpl] get; }

    /// <summary>Gets the suggested batch size for the server-side search batch read.</summary>
    /// <returns>The suggested number of contacts in a batch.</returns>
    public extern uint SuggestedBatchSize { [MethodImpl] get; }

    /// <summary>Asynchronously saves a contact that meets server-side search criteria.</summary>
    /// <param name="contact">A Contact that meets the search criteria.</param>
    /// <returns>An asynchronous contact save operation.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction SaveContactAsync(Contact contact);

    /// <summary>Informs the client app that the request was processed successfully.</summary>
    /// <returns>An asynchronous batch read request operation.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction ReportCompletedAsync();

    /// <summary>Informs the client that the request was not processed successfully.</summary>
    /// <param name="batchStatus">A ContactBatchStatus value describing the reason for the failure.</param>
    /// <returns>An asynchronous batch read request operation.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction ReportFailedAsync(ContactBatchStatus batchStatus);
  }
}
