// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.UserDataTasks.IUserDataTaskListSyncManager
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.UserDataTasks
{
  [Guid(2388204181, 7631, 18079, 147, 236, 186, 72, 187, 85, 60, 107)]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [ExclusiveTo(typeof (UserDataTaskListSyncManager))]
  internal interface IUserDataTaskListSyncManager
  {
    DateTime LastAttemptedSyncTime { get; set; }

    DateTime LastSuccessfulSyncTime { get; set; }

    UserDataTaskListSyncStatus Status { get; set; }

    [RemoteAsync]
    IAsyncOperation<bool> SyncAsync();

    event TypedEventHandler<UserDataTaskListSyncManager, object> SyncStatusChanged;
  }
}
