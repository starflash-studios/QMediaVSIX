// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Contacts.DataProvider.IContactDataProviderConnection
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Contacts.DataProvider
{
  [Guid(439978578, 35997, 19823, 164, 224, 17, 30, 154, 18, 90, 48)]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [ExclusiveTo(typeof (ContactDataProviderConnection))]
  internal interface IContactDataProviderConnection
  {
    event TypedEventHandler<ContactDataProviderConnection, ContactListSyncManagerSyncRequestEventArgs> SyncRequested;

    event TypedEventHandler<ContactDataProviderConnection, ContactListServerSearchReadBatchRequestEventArgs> ServerSearchReadBatchRequested;

    void Start();
  }
}
