// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Contacts.IAggregateContactManager
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Contacts
{
  [Guid(58316253, 56154, 20435, 181, 78, 77, 241, 121, 23, 162, 18)]
  [ExclusiveTo(typeof (AggregateContactManager))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IAggregateContactManager
  {
    IAsyncOperation<IVectorView<Contact>> FindRawContactsAsync(
      Contact contact);

    IAsyncOperation<Contact> TryLinkContactsAsync(
      Contact primaryContact,
      Contact secondaryContact);

    IAsyncAction UnlinkRawContactAsync(Contact contact);

    IAsyncOperation<bool> TrySetPreferredSourceForPictureAsync(
      Contact aggregateContact,
      Contact rawContact);
  }
}
