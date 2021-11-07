// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Contacts.ContactStore
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Contacts
{
  /// <summary>Represents a database that contains contacts.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class ContactStore : IContactStore, IContactStore2, IContactStore3
  {
    /// <summary>Retrieves the list of all contacts in the contact store.</summary>
    /// <returns>An asynchronous operation that returns a list of all Contact objects in the contact store. If you use Asynchronous programming, the result type is a read-only list/vector of Contact items. (You can use APIs of IVectorView&lt;Contact&gt; for C++ or JavaScript, APIs of IReadOnlyList&lt;Contact&gt; for .NET.)</returns>
    [RemoteAsync]
    [Overload("FindContactsAsync")]
    [MethodImpl]
    public extern IAsyncOperation<IVectorView<Contact>> FindContactsAsync();

    /// <summary>Retrieves a list of Contact objects based on the supplied search text.</summary>
    /// <param name="searchText">The search string for the operation. The query will attempt to match the name (Name ), email address (Emails values), or phone number (Phones values) of a contact.</param>
    /// <returns>An asynchronous operation that returns a search-filtered list of contacts on successful completion. If you use Asynchronous programming, the result type is a read-only list/vector of Contact items. (You can use APIs of IVectorView&lt;Contact&gt; for C++ or JavaScript, APIs of IReadOnlyList&lt;Contact&gt; for .NET.)</returns>
    [Overload("FindContactsWithSearchTextAsync")]
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<IVectorView<Contact>> FindContactsAsync(
      string searchText);

    /// <summary>Retrieves a Contact object representing the contact with the specified Id value.</summary>
    /// <param name="contactId">The Id of the contact to be retrieved.</param>
    /// <returns>An asynchronous operation that returns a Contact object on successful completion. If you use Asynchronous programming, the result type is a single Contact object.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<Contact> GetContactAsync(string contactId);

    /// <summary>Gets the ContactChangeTracker which provides functionality for monitoring changes to Contact objects in the ContactStore.</summary>
    /// <returns>The ContactChangeTracker which provides functionality for monitoring changes to Contact objects in the ContactStore.</returns>
    public extern ContactChangeTracker ChangeTracker { [MethodImpl] get; }

    /// <summary>Occurs when a Contact in the ContactStore has been changed.</summary>
    public extern event TypedEventHandler<ContactStore, ContactChangedEventArgs> ContactChanged;

    /// <summary>Gets a contact manager that provides functionality for linking individual (raw) contacts across services together into a single aggregate contact.</summary>
    /// <returns>A contact manager that provides functionality for linking individual (raw) contacts across services together into a single aggregate contact.</returns>
    public extern AggregateContactManager AggregateContactManager { [MethodImpl] get; }

    /// <summary>Asynchronously returns the list of ContactList objects.</summary>
    /// <returns>The list of ContactList objects.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<IVectorView<ContactList>> FindContactListsAsync();

    /// <summary>Asynchronously gets the ContactList with the specified ID.</summary>
    /// <param name="contactListId">The ID of the ContactList to retrieve.</param>
    /// <returns>The ContactList with the specified ID or null if the list is not found.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<ContactList> GetContactListAsync(
      string contactListId);

    /// <summary>Asynchronously creates a ContactList with the specified display name.</summary>
    /// <param name="displayName">A name for the new ContactList, suitable for displaying in the user interface.</param>
    /// <returns>The newly created ContactList.</returns>
    [Overload("CreateContactListAsync")]
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<ContactList> CreateContactListAsync(
      string displayName);

    /// <summary>Get the Contact object for the current user.</summary>
    /// <returns>The Contact object for the current user.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<Contact> GetMeContactAsync();

    /// <summary>Creates and returns a ContactReader for the ContactStore.</summary>
    /// <returns>The newly created ContactReader for the ContactStore.</returns>
    [Overload("GetContactReader")]
    [MethodImpl]
    public extern ContactReader GetContactReader();

    /// <summary>Creates and returns a ContactReader for the ContactStore with the specified ContactQueryOptions.</summary>
    /// <param name="options">The query options to use when creating the new ContactReader.</param>
    /// <returns>The newly created ContactReader for the ContactStore.</returns>
    [Overload("GetContactReaderWithOptions")]
    [MethodImpl]
    public extern ContactReader GetContactReader(ContactQueryOptions options);

    /// <summary>Asynchronously creates a ContactList with the specified display name and user account.</summary>
    /// <param name="displayName">A name for the new ContactList, suitable for displaying in the user interface.</param>
    /// <param name="userDataAccountId">The ID for the UserDataAccount to use when creating the ContactList.</param>
    /// <returns>The newly created ContactList.</returns>
    [Overload("CreateContactListInAccountAsync")]
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<ContactList> CreateContactListAsync(
      string displayName,
      string userDataAccountId);

    /// <summary>Gets a ContactChangeTracker that provides functionality for monitoring changes to Contact objects in the ContactStore.</summary>
    /// <param name="identity">A string that identifies the ContactChangeTracker instance in the store.</param>
    /// <returns>A ContactChangeTracker that provides functionality for monitoring changes to Contact objects in the ContactStore.</returns>
    [MethodImpl]
    public extern ContactChangeTracker GetChangeTracker(string identity);
  }
}
