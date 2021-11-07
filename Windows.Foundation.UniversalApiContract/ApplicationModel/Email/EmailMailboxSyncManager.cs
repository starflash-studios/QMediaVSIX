// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Email.EmailMailboxSyncManager
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Email
{
  /// <summary>The functionality described in this topic is not available to all UWP apps. As part of the store app submission process, Microsoft must approve your use of these APIs and provision your developer account before you can publish an app that uses them.</summary>
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class EmailMailboxSyncManager : IEmailMailboxSyncManager, IEmailMailboxSyncManager2
  {
    /// <summary>Gets or sets the sync state of the mailbox.</summary>
    /// <returns>The sync state of the mailbox.</returns>
    public extern EmailMailboxSyncStatus Status { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the last time the mailbox was successfully synced.</summary>
    /// <returns>The last time the mailbox was successfully synced.</returns>
    public extern DateTime LastSuccessfulSyncTime { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the last time the mailbox attempted to sync.</summary>
    /// <returns>The last time the mailbox attempted to sync.</returns>
    public extern DateTime LastAttemptedSyncTime { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Initiates a sync of this mailbox.</summary>
    /// <returns>A Boolean value indicating success.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<bool> SyncAsync();

    /// <summary>Fires whenever a mailbox's sync status changes.</summary>
    public extern event TypedEventHandler<EmailMailboxSyncManager, object> SyncStatusChanged;
  }
}
