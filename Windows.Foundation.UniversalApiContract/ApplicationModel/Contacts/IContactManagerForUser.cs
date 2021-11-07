// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Contacts.IContactManagerForUser
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;
using Windows.System;

namespace Windows.ApplicationModel.Contacts
{
  [Guid(3075193431, 4214, 19439, 174, 243, 84, 104, 109, 24, 56, 125)]
  [ExclusiveTo(typeof (ContactManagerForUser))]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  internal interface IContactManagerForUser
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

    [RemoteAsync]
    IAsyncOperation<ContactStore> RequestStoreAsync(
      ContactStoreAccessType accessType);

    [RemoteAsync]
    IAsyncOperation<ContactAnnotationStore> RequestAnnotationStoreAsync(
      ContactAnnotationStoreAccessType accessType);

    ContactNameOrder SystemDisplayNameOrder { get; set; }

    ContactNameOrder SystemSortOrder { get; set; }

    User User { get; }
  }
}
