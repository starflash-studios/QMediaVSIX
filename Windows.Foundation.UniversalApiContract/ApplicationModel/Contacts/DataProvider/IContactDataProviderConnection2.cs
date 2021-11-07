// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Contacts.DataProvider.IContactDataProviderConnection2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Contacts.DataProvider
{
  [ExclusiveTo(typeof (ContactDataProviderConnection))]
  [Guid(2714970032, 6508, 19453, 143, 15, 198, 141, 103, 242, 73, 211)]
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  internal interface IContactDataProviderConnection2
  {
    event TypedEventHandler<ContactDataProviderConnection, ContactListCreateOrUpdateContactRequestEventArgs> CreateOrUpdateContactRequested;

    event TypedEventHandler<ContactDataProviderConnection, ContactListDeleteContactRequestEventArgs> DeleteContactRequested;
  }
}
