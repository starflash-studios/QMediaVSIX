// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Contacts.IContactStore
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Contacts
{
  [ExclusiveTo(typeof (ContactStore))]
  [Guid(740428560, 14956, 17043, 185, 188, 254, 152, 127, 110, 13, 82)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IContactStore
  {
    [Overload("FindContactsAsync")]
    [RemoteAsync]
    IAsyncOperation<IVectorView<Contact>> FindContactsAsync();

    [RemoteAsync]
    [Overload("FindContactsWithSearchTextAsync")]
    IAsyncOperation<IVectorView<Contact>> FindContactsAsync(
      string searchText);

    [RemoteAsync]
    IAsyncOperation<Contact> GetContactAsync(string contactId);
  }
}
