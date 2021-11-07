// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Contacts.IContactList
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Contacts
{
  [ExclusiveTo(typeof (ContactList))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(383642741, 14636, 18501, 157, 251, 81, 163, 231, 239, 62, 66)]
  internal interface IContactList
  {
    string Id { get; }

    string DisplayName { get; set; }

    string SourceDisplayName { get; }

    bool IsHidden { get; set; }

    ContactListOtherAppReadAccess OtherAppReadAccess { get; set; }

    ContactListOtherAppWriteAccess OtherAppWriteAccess { get; set; }

    ContactChangeTracker ChangeTracker { get; }

    ContactListSyncManager SyncManager { get; }

    bool SupportsServerSearch { get; }

    string UserDataAccountId { get; }

    event TypedEventHandler<ContactList, ContactChangedEventArgs> ContactChanged;

    [RemoteAsync]
    IAsyncAction SaveAsync();

    [RemoteAsync]
    IAsyncAction DeleteAsync();

    [RemoteAsync]
    IAsyncOperation<Contact> GetContactFromRemoteIdAsync(string remoteId);

    [RemoteAsync]
    IAsyncOperation<Contact> GetMeContactAsync();

    [Overload("GetContactReader")]
    ContactReader GetContactReader();

    [Overload("GetContactReaderWithOptions")]
    ContactReader GetContactReader(ContactQueryOptions options);

    IAsyncAction SaveContactAsync(Contact contact);

    IAsyncAction DeleteContactAsync(Contact contact);

    [RemoteAsync]
    IAsyncOperation<Contact> GetContactAsync(string contactId);
  }
}
