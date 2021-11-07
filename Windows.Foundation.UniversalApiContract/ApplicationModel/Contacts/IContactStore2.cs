// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Contacts.IContactStore2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Contacts
{
  [Guid(416160802, 60373, 19451, 182, 144, 95, 79, 39, 196, 240, 232)]
  [ExclusiveTo(typeof (ContactStore))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IContactStore2 : IContactStore
  {
    ContactChangeTracker ChangeTracker { get; }

    event TypedEventHandler<ContactStore, ContactChangedEventArgs> ContactChanged;

    AggregateContactManager AggregateContactManager { get; }

    [RemoteAsync]
    IAsyncOperation<IVectorView<ContactList>> FindContactListsAsync();

    [RemoteAsync]
    IAsyncOperation<ContactList> GetContactListAsync(string contactListId);

    [Overload("CreateContactListAsync")]
    [RemoteAsync]
    IAsyncOperation<ContactList> CreateContactListAsync(string displayName);

    [RemoteAsync]
    IAsyncOperation<Contact> GetMeContactAsync();

    [Overload("GetContactReader")]
    ContactReader GetContactReader();

    [Overload("GetContactReaderWithOptions")]
    ContactReader GetContactReader(ContactQueryOptions options);

    [Overload("CreateContactListInAccountAsync")]
    [RemoteAsync]
    IAsyncOperation<ContactList> CreateContactListAsync(
      string displayName,
      string userDataAccountId);
  }
}
