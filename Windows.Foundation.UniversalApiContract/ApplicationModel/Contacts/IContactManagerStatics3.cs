// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Contacts.IContactManagerStatics3
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;
using Windows.UI.Popups;

namespace Windows.ApplicationModel.Contacts
{
  [ExclusiveTo(typeof (ContactManager))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(3301719362, 30086, 18730, 147, 11, 123, 193, 56, 252, 33, 57)]
  internal interface IContactManagerStatics3 : IContactManagerStatics2, IContactManagerStatics
  {
    [Overload("ConvertContactToVCardAsync")]
    [RemoteAsync]
    IAsyncOperation<RandomAccessStreamReference> ConvertContactToVCardAsync(
      Contact contact);

    [RemoteAsync]
    [Overload("ConvertContactToVCardAsyncWithMaxBytes")]
    IAsyncOperation<RandomAccessStreamReference> ConvertContactToVCardAsync(
      Contact contact,
      uint maxBytes);

    [RemoteAsync]
    IAsyncOperation<Contact> ConvertVCardToContactAsync(
      IRandomAccessStreamReference vCard);

    [Overload("RequestStoreAsyncWithAccessType")]
    [RemoteAsync]
    IAsyncOperation<ContactStore> RequestStoreAsync(
      ContactStoreAccessType accessType);

    [RemoteAsync]
    IAsyncOperation<ContactAnnotationStore> RequestAnnotationStoreAsync(
      ContactAnnotationStoreAccessType accessType);

    bool IsShowContactCardSupported();

    [Overload("ShowContactCardWithOptions")]
    void ShowContactCard(
      Contact contact,
      Rect selection,
      Placement preferredPlacement,
      ContactCardOptions contactCardOptions);

    bool IsShowDelayLoadedContactCardSupported();

    [Overload("ShowDelayLoadedContactCardWithOptions")]
    ContactCardDelayedDataLoader ShowDelayLoadedContactCard(
      Contact contact,
      Rect selection,
      Placement preferredPlacement,
      ContactCardOptions contactCardOptions);

    void ShowFullContactCard(Contact contact, FullContactCardOptions fullContactCardOptions);

    ContactNameOrder SystemDisplayNameOrder { get; set; }

    ContactNameOrder SystemSortOrder { get; set; }
  }
}
