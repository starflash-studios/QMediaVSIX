// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.UserDataTasks.DataProvider.UserDataTaskListCreateOrUpdateTaskRequest
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.UserDataTasks.DataProvider
{
  /// <summary>Details of a request to create or update a task.</summary>
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class UserDataTaskListCreateOrUpdateTaskRequest : 
    IUserDataTaskListCreateOrUpdateTaskRequest
  {
    /// <summary>Gets the ID of the task list that contains the task that is to created or updated.</summary>
    /// <returns>The ID of the task list that contains the task that is to created or updated.</returns>
    public extern string TaskListId { [MethodImpl] get; }

    /// <summary>Gets the UserDataTask of the task to be created or updated.</summary>
    /// <returns>The UserDataTask of the task to be created or updated.</returns>
    public extern UserDataTask Task { [MethodImpl] get; }

    /// <summary>Informs the client app that the request was processed successfully.</summary>
    /// <param name="createdOrUpdatedUserDataTask">The UserDataTask of the task that was created or updated.</param>
    /// <returns>An asynchronous operation.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction ReportCompletedAsync(
      UserDataTask createdOrUpdatedUserDataTask);

    /// <summary>Informs the client that the request was not processed successfully.</summary>
    /// <returns>An asynchronous operation.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction ReportFailedAsync();
  }
}
