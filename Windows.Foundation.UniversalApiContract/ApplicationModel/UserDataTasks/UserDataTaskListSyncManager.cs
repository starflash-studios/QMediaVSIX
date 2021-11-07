// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.UserDataTasks.UserDataTaskListSyncManager
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.UserDataTasks
{
  /// <summary>Provides functionality for syncing task information with the server.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  public sealed class UserDataTaskListSyncManager : IUserDataTaskListSyncManager
  {
    /// <summary>Gets or sets the last time a sync was attempted with the server.</summary>
    /// <returns>The last time a sync was attempted with the server.</returns>
    public extern DateTime LastAttemptedSyncTime { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the last time the UserDataTaskList was successfully synced with the server.</summary>
    /// <returns>The last time the **UserDataTaskList** was successfully synced with the server.</returns>
    public extern DateTime LastSuccessfulSyncTime { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the UserDataTaskListSyncStatus.</summary>
    /// <returns>The UserDataTaskListSyncStatus.</returns>
    public extern UserDataTaskListSyncStatus Status { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Asynchronously attempts to sync with the tasks server.</summary>
    /// <returns>A Boolean value indicating if the sync was successful.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<bool> SyncAsync();

    /// <summary>Occurs when the sync status with the server has changed.</summary>
    public extern event TypedEventHandler<UserDataTaskListSyncManager, object> SyncStatusChanged;
  }
}
