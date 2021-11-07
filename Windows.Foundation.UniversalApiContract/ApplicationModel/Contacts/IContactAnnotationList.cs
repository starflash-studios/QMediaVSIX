// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Contacts.IContactAnnotationList
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Contacts
{
  [Guid(2460255914, 23688, 17849, 170, 208, 70, 24, 136, 230, 141, 138)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (ContactAnnotationList))]
  internal interface IContactAnnotationList
  {
    string Id { get; }

    string ProviderPackageFamilyName { get; }

    string UserDataAccountId { get; }

    [RemoteAsync]
    IAsyncAction DeleteAsync();

    IAsyncOperation<bool> TrySaveAnnotationAsync(ContactAnnotation annotation);

    [RemoteAsync]
    IAsyncOperation<ContactAnnotation> GetAnnotationAsync(
      string annotationId);

    [RemoteAsync]
    IAsyncOperation<IVectorView<ContactAnnotation>> FindAnnotationsByRemoteIdAsync(
      string remoteId);

    [RemoteAsync]
    IAsyncOperation<IVectorView<ContactAnnotation>> FindAnnotationsAsync();

    IAsyncAction DeleteAnnotationAsync(ContactAnnotation annotation);
  }
}
