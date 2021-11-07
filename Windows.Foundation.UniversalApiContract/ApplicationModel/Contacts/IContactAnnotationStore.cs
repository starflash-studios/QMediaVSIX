// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Contacts.IContactAnnotationStore
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Contacts
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(598537386, 31351, 17789, 130, 3, 152, 127, 75, 49, 175, 9)]
  [ExclusiveTo(typeof (ContactAnnotationStore))]
  internal interface IContactAnnotationStore
  {
    [RemoteAsync]
    IAsyncOperation<IVectorView<string>> FindContactIdsByEmailAsync(
      string emailAddress);

    [RemoteAsync]
    IAsyncOperation<IVectorView<string>> FindContactIdsByPhoneNumberAsync(
      string phoneNumber);

    IAsyncOperation<IVectorView<ContactAnnotation>> FindAnnotationsForContactAsync(
      Contact contact);

    IAsyncAction DisableAnnotationAsync(ContactAnnotation annotation);

    [RemoteAsync]
    [Overload("CreateAnnotationListAsync")]
    IAsyncOperation<ContactAnnotationList> CreateAnnotationListAsync();

    [RemoteAsync]
    [Overload("CreateAnnotationListInAccountAsync")]
    IAsyncOperation<ContactAnnotationList> CreateAnnotationListAsync(
      string userDataAccountId);

    [RemoteAsync]
    IAsyncOperation<ContactAnnotationList> GetAnnotationListAsync(
      string annotationListId);

    [RemoteAsync]
    IAsyncOperation<IVectorView<ContactAnnotationList>> FindAnnotationListsAsync();
  }
}
