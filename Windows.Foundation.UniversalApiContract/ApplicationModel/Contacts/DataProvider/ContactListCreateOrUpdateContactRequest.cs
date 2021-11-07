// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Contacts.DataProvider.ContactListCreateOrUpdateContactRequest
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Contacts.DataProvider
{
  /// <summary>Details of a request to create or update a contact.</summary>
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  public sealed class ContactListCreateOrUpdateContactRequest : 
    IContactListCreateOrUpdateContactRequest
  {
    /// <summary>Gets the ID of the contact list that contains the task that is to created or updated.</summary>
    /// <returns>The ID of the contact list that contains the task that is to created or updated.</returns>
    public extern string ContactListId { [MethodImpl] get; }

    /// <summary>Gets the Contact of the task to be created or updated.</summary>
    /// <returns>The Contact of the task to be created or updated.</returns>
    public extern Contact Contact { [MethodImpl] get; }

    /// <summary>Informs the client app that the request was processed successfully.</summary>
    /// <param name="createdOrUpdatedContact">The Contact of the contact that was created or updated.</param>
    /// <returns>An asynchronous operation.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction ReportCompletedAsync(Contact createdOrUpdatedContact);

    /// <summary>Informs the client that the request was not processed successfully.</summary>
    /// <returns>An asynchronous operation.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction ReportFailedAsync();
  }
}
