// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.UserDataTasks.UserDataTaskList
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.UserDataTasks
{
  /// <summary>Represents a list of UserDataTask objects.</summary>
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  public sealed class UserDataTaskList : IUserDataTaskList
  {
    /// <summary>Gets the locally unique identifier for this UserDataTaskList.</summary>
    /// <returns>The locally unique identifier for this UserDataTaskList.</returns>
    public extern string Id { [MethodImpl] get; }

    /// <summary>Gets a string that represents the ID of the user data account for this UserDataTaskList.</summary>
    /// <returns>A string that represents the ID of the user data account for this UserDataTaskList.</returns>
    public extern string UserDataAccountId { [MethodImpl] get; }

    /// <summary>Gets or sets the name of the UserDataTaskList, suitable for display in the user interface.</summary>
    /// <returns>The name of the UserDataTaskList, suitable for display in the user interface.</returns>
    public extern string DisplayName { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets the name of the source of the UserDataTaskList, suitable for display in the user interface.</summary>
    /// <returns>The name of the source of the UserDataTaskList, suitable for display in the user interface.</returns>
    public extern string SourceDisplayName { [MethodImpl] get; }

    /// <summary>Gets or sets a value indicating the read access level to this UserDataTaskList for other apps on the system.</summary>
    /// <returns>A value indicating the read access level to this UserDataTaskList for other apps on the system.</returns>
    public extern UserDataTaskListOtherAppReadAccess OtherAppReadAccess { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a value indicating the write access level to this UserDataTaskList for other apps on the system.</summary>
    /// <returns>A value indicating the write access level to this UserDataTaskList for other apps on the system.</returns>
    public extern UserDataTaskListOtherAppWriteAccess OtherAppWriteAccess { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets an object that provides operations that an app can perform on a task list that it has not created.</summary>
    /// <returns>An object that provides operations that an app can perform on a task list that it has not created.</returns>
    public extern UserDataTaskListLimitedWriteOperations LimitedWriteOperations { [MethodImpl] get; }

    /// <summary>Gets the UserDataTaskListSyncManager used to communicate with the server.</summary>
    /// <returns>The UserDataTaskListSyncManager used to communicate with the server.</returns>
    public extern UserDataTaskListSyncManager SyncManager { [MethodImpl] get; }

    /// <summary>Adds a SyncManager to the UserDataTaskList.</summary>
    /// <returns>An asynchronous registration operation that you can await.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction RegisterSyncManagerAsync();

    /// <summary>Gets a UserDataTaskReader object associated with this UserDataTaskList.</summary>
    /// <returns>A UserDataTaskReader object associated with this UserDataTaskList.</returns>
    [Overload("GetTaskReader")]
    [MethodImpl]
    public extern UserDataTaskReader GetTaskReader();

    /// <summary>Gets a UserDataTaskReader object associated with this UserDataTaskList by using the specified UserDataTaskQueryOptions.</summary>
    /// <param name="options">The UserDataTaskQueryOptions to use when creating the UserDataTaskReader.</param>
    /// <returns>A UserDataTaskReader object associated with this UserDataTaskList.</returns>
    [Overload("GetTaskReaderWithOptions")]
    [MethodImpl]
    public extern UserDataTaskReader GetTaskReader(
      UserDataTaskQueryOptions options);

    /// <summary>Asynchronously retrieves the specified UserDataTask object from the UserDataTaskList.</summary>
    /// <param name="userDataTask">The string that identifies the UserDataTask to return.</param>
    /// <returns>The UserDataTask identified by the *UserDataTask* parameter.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<UserDataTask> GetTaskAsync(
      string userDataTask);

    /// <summary>Asynchronously saves the specified UserDataTask to the UserDataTaskStore.</summary>
    /// <param name="userDataTask">The task to save.</param>
    /// <returns>
    /// </returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction SaveTaskAsync(UserDataTask userDataTask);

    /// <summary>Asynchronously deletes and individual UserDataTask from this UserDataTaskList and the UserDataTaskStore.</summary>
    /// <param name="userDataTaskId">The UserDataTask to delete.</param>
    /// <returns>An async action indicating that the method is complete.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction DeleteTaskAsync(string userDataTaskId);

    /// <summary>Asynchronously deletes this UserDataTaskList, including all UserDataTask objects in the UserDataTaskStore.</summary>
    /// <returns>An async action indicating that the method is complete.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction DeleteAsync();

    /// <summary>Asynchronously saves this UserDataTaskList.</summary>
    /// <returns>An async action indicating that the method has completed.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction SaveAsync();
  }
}
