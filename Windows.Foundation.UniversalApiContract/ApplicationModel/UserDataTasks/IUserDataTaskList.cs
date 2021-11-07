// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.UserDataTasks.IUserDataTaskList
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.UserDataTasks
{
  [Guid(1229008441, 31773, 19953, 190, 211, 49, 75, 124, 191, 94, 78)]
  [ExclusiveTo(typeof (UserDataTaskList))]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  internal interface IUserDataTaskList
  {
    string Id { get; }

    string UserDataAccountId { get; }

    string DisplayName { get; set; }

    string SourceDisplayName { get; }

    UserDataTaskListOtherAppReadAccess OtherAppReadAccess { get; set; }

    UserDataTaskListOtherAppWriteAccess OtherAppWriteAccess { get; set; }

    UserDataTaskListLimitedWriteOperations LimitedWriteOperations { get; }

    UserDataTaskListSyncManager SyncManager { get; }

    [RemoteAsync]
    IAsyncAction RegisterSyncManagerAsync();

    [Overload("GetTaskReader")]
    UserDataTaskReader GetTaskReader();

    [Overload("GetTaskReaderWithOptions")]
    UserDataTaskReader GetTaskReader(UserDataTaskQueryOptions options);

    [RemoteAsync]
    IAsyncOperation<UserDataTask> GetTaskAsync(string userDataTask);

    [RemoteAsync]
    IAsyncAction SaveTaskAsync(UserDataTask userDataTask);

    [RemoteAsync]
    IAsyncAction DeleteTaskAsync(string userDataTaskId);

    [RemoteAsync]
    IAsyncAction DeleteAsync();

    [RemoteAsync]
    IAsyncAction SaveAsync();
  }
}
