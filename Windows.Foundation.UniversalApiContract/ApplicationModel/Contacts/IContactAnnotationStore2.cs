// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Contacts.IContactAnnotationStore2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Contacts
{
  [Guid(2128487421, 25063, 18791, 142, 197, 189, 242, 128, 162, 64, 99)]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [ExclusiveTo(typeof (ContactAnnotationStore))]
  internal interface IContactAnnotationStore2
  {
    [RemoteAsync]
    IAsyncOperation<IVectorView<ContactAnnotation>> FindAnnotationsForContactListAsync(
      string contactListId);
  }
}
