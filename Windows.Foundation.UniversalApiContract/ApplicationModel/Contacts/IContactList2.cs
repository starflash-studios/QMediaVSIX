// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Contacts.IContactList2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Contacts
{
  [ExclusiveTo(typeof (ContactList))]
  [Guid(3409527732, 17744, 19915, 146, 41, 64, 255, 145, 251, 2, 3)]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  internal interface IContactList2
  {
    [RemoteAsync]
    IAsyncAction RegisterSyncManagerAsync();

    bool SupportsServerSearch { set; }

    ContactListSyncConstraints SyncConstraints { get; }
  }
}
