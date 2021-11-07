// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Contacts.IContactListSyncManager
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Contacts
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(342787006, 31013, 19148, 157, 229, 33, 221, 208, 111, 134, 116)]
  [ExclusiveTo(typeof (ContactListSyncManager))]
  internal interface IContactListSyncManager
  {
    ContactListSyncStatus Status { get; }

    DateTime LastSuccessfulSyncTime { get; }

    DateTime LastAttemptedSyncTime { get; }

    [RemoteAsync]
    IAsyncOperation<bool> SyncAsync();

    event TypedEventHandler<ContactListSyncManager, object> SyncStatusChanged;
  }
}
