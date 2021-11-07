// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Contacts.ContactList
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Contacts
{
  /// <summary>Represents a list of Contact objects.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class ContactList : IContactList, IContactList2, IContactList3
  {
    /// <summary>Gets the locally unique identifier for this ContactList.</summary>
    /// <returns>The locally unique identifier for this ContactList.</returns>
    public extern string Id { [MethodImpl] get; }

    /// <summary>Gets or puts the name of the ContactList, suitable for display in the user interface.</summary>
    /// <returns>The name of the ContactList, suitable for display in the user interface.</returns>
    public extern string DisplayName { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets the name of the source of the ContactList, suitable for display in the user interface.</summary>
    /// <returns>The name of the source of the ContactList, suitable for display in the user interface.</returns>
    public extern string SourceDisplayName { [MethodImpl] get; }

    /// <summary>Gets or puts a Boolean value indicating of the ContactList is hidden in the user interface.</summary>
    /// <returns>A Boolean value indicating of the ContactList is hidden in the user interface.</returns>
    public extern bool IsHidden { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or puts a value indicating the read access level to this ContactList for other apps on the system.</summary>
    /// <returns>A value indicating the read access level to this ContactList for other apps on the system.</returns>
    public extern ContactListOtherAppReadAccess OtherAppReadAccess { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or puts a value indicating the write access level to this ContactList for other apps on the system.</summary>
    /// <returns>A value indicating the write access level to this ContactList for other apps on the system.</returns>
    public extern ContactListOtherAppWriteAccess OtherAppWriteAccess { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets the app's ContactChangeTracker for this ContactList.</summary>
    /// <returns>The app's ContactChangeTracker for this ContactList.</returns>
    public extern ContactChangeTracker ChangeTracker { [MethodImpl] get; }

    /// <summary>Gets the ContactListSyncManager used to communicate with the server.</summary>
    /// <returns>The ContactListSyncManager used to communicate with the server.</returns>
    public extern ContactListSyncManager SyncManager { [MethodImpl] get; }

    /// <summary>Gets or sets a Boolean value indicating if you can search the remote server with this ContactList.</summary>
    /// <returns>A Boolean value indicating if you can search the remote server with this ContactList.</returns>
    public extern bool SupportsServerSearch { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets a string that represents the ID of the user data account for this ContactList.</summary>
    /// <returns>A string that represents the ID of the user data account for this ContactList.</returns>
    public extern string UserDataAccountId { [MethodImpl] get; }

    /// <summary>Occurs when a Contact in this ContactList has been changed.</summary>
    public extern event TypedEventHandler<ContactList, ContactChangedEventArgs> ContactChanged;

    /// <summary>Asynchronously saves this ContactList.</summary>
    /// <returns>An async action indicating that the method has completed.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction SaveAsync();

    /// <summary>Asynchronously deletes this ContactList, including all Contact objects in the ContactStore.</summary>
    /// <returns>An async action indicating that the method is complete.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction DeleteAsync();

    /// <summary>Asynchronously gets the Contact identified by the specified RemoteId.</summary>
    /// <param name="remoteId">An ID that can be used by a service provider to access the Contact in their remote system.</param>
    /// <returns>The Contact identified by the *remoteId* parameter.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<Contact> GetContactFromRemoteIdAsync(
      string remoteId);

    /// <summary>Asynchronously gets the Contact object for the current user.</summary>
    /// <returns>The Contact object for the current user.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<Contact> GetMeContactAsync();

    /// <summary>Gets a ContactReader object associated with this ContactList.</summary>
    /// <returns>A ContactReader object associated with this ContactList.</returns>
    [Overload("GetContactReader")]
    [MethodImpl]
    public extern ContactReader GetContactReader();

    /// <summary>Gets a ContactReader object associated with this ContactList and using the specified ContactQueryOptions.</summary>
    /// <param name="options">The ContactQueryOptions to use when creating the ContactReader.</param>
    /// <returns>A ContactReader object associated with this ContactList.</returns>
    [Overload("GetContactReaderWithOptions")]
    [MethodImpl]
    public extern ContactReader GetContactReader(ContactQueryOptions options);

    /// <summary>Asynchronously saves the specified Contact to the ContactStore.</summary>
    /// <param name="contact">The contact to save.</param>
    /// <returns>An async action indicating that the method has completed.</returns>
    [MethodImpl]
    public extern IAsyncAction SaveContactAsync(Contact contact);

    /// <summary>Asynchronously deletes and individual Contact from this ContactList and the ContactStore.</summary>
    /// <param name="contact">The Contact to delete.</param>
    /// <returns>An async action indicating that the method is complete.</returns>
    [MethodImpl]
    public extern IAsyncAction DeleteContactAsync(Contact contact);

    /// <summary>Asynchronously retrieves the specified Contact object from the ContactList.</summary>
    /// <param name="contactId">The string that identifies the Contact to return.</param>
    /// <returns>The Contact identified by the *contactId* parameter.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<Contact> GetContactAsync(string contactId);

    /// <summary>Adds a SyncManager  to the ContactList.</summary>
    /// <returns>An asynchronous registration operation that you can await.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction RegisterSyncManagerAsync();

    /// <summary>Gets the ContactListSyncConstraints which indicates the maximum amount of contact list data that can be synchronized.</summary>
    /// <returns>The ContactListSyncConstraints for this contact list.</returns>
    public extern ContactListSyncConstraints SyncConstraints { [MethodImpl] get; }

    /// <summary>Gets an object that provides operations that an app can perform on a contact list that it has not created.</summary>
    /// <returns>An object that provides operations that an app can perform on a contact list that it has not created.</returns>
    public extern ContactListLimitedWriteOperations LimitedWriteOperations { [MethodImpl] get; }

    /// <summary>Gets a ContactChangeTracker that provides functionality for monitoring changes to Contact objects in the ContactList.</summary>
    /// <param name="identity">A string that identifies the ContactChangeTracker instance in the ContactList.</param>
    /// <returns>A ContactChangeTracker that provides functionality for monitoring changes to Contact objects in the ContactList.</returns>
    [MethodImpl]
    public extern ContactChangeTracker GetChangeTracker(string identity);
  }
}
