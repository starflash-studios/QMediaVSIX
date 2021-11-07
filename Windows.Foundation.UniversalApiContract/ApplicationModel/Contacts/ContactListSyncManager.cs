// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Contacts.ContactListSyncManager
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Contacts
{
  /// <summary>Provides functionality for syncing contact information with the server.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Threading(ThreadingModel.Both)]
  public sealed class ContactListSyncManager : IContactListSyncManager, IContactListSyncManager2
  {
    /// <summary>Gets or sets the ContactListSyncStatus.</summary>
    /// <returns>The ContactListSyncStatus.</returns>
    public extern ContactListSyncStatus Status { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the last time the ContactList was successfully synced with the server.</summary>
    /// <returns>The last time the ContactList was successfully synced with the server.</returns>
    public extern DateTime LastSuccessfulSyncTime { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the last time a sync was attempted with the server.</summary>
    /// <returns>The last time a sync was attempted with the server.</returns>
    public extern DateTime LastAttemptedSyncTime { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Asynchronously attempts to sync with the contacts server.</summary>
    /// <returns>A Boolean value indicating if the sync was successful.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<bool> SyncAsync();

    /// <summary>Occurs when the sync status with the server has changed.</summary>
    public extern event TypedEventHandler<ContactListSyncManager, object> SyncStatusChanged;
  }
}
