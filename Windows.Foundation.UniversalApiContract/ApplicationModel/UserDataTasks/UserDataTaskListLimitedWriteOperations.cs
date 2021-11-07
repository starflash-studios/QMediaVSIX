// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.UserDataTasks.UserDataTaskListLimitedWriteOperations
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.UserDataTasks
{
  /// <summary>Provides operations that an app can perform on a task list that it has not created.</summary>
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  public sealed class UserDataTaskListLimitedWriteOperations : 
    IUserDataTaskListLimitedWriteOperations
  {
    /// <summary>Asynchronously attempts to mark a task as completed.</summary>
    /// <param name="userDataTaskId">The ID of the task to mark as completed.</param>
    /// <returns>The ID of the task marked as completed.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<string> TryCompleteTaskAsync(string userDataTaskId);

    /// <summary>Asynchronously attempts to create or update a task.</summary>
    /// <param name="userDataTask">The task to create or update.</param>
    /// <returns>A Boolean value indicating if the operation was successful.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<bool> TryCreateOrUpdateTaskAsync(
      UserDataTask userDataTask);

    /// <summary>Asynchronously attempts to delete a task.</summary>
    /// <param name="userDataTaskId">The ID of the task to delete.</param>
    /// <returns>A Boolean value indicating if the operation was successful.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<bool> TryDeleteTaskAsync(string userDataTaskId);

    /// <summary>Asynchronously attempts to skip the current instance of a reoccurring task and move to the next instance.</summary>
    /// <param name="userDataTaskId">The ID of the reoccurring task.</param>
    /// <returns>A Boolean value indicating if the operation was successful.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<bool> TrySkipOccurrenceAsync(string userDataTaskId);
  }
}
