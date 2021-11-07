// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.UserDataTasks.DataProvider.UserDataTaskListSyncManagerSyncRequest
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.UserDataTasks.DataProvider
{
  /// <summary>Details of a request from a client to sync a task list.</summary>
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  public sealed class UserDataTaskListSyncManagerSyncRequest : 
    IUserDataTaskListSyncManagerSyncRequest
  {
    /// <summary>Gets the ID of the task list to be synced.</summary>
    /// <returns>The ID of the task list to be synced.</returns>
    public extern string TaskListId { [MethodImpl] get; }

    /// <summary>Informs the client app that the request was processed successfully.</summary>
    /// <returns>An asynchronous sync operation.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction ReportCompletedAsync();

    /// <summary>Informs the client that the request was not processed successfully.</summary>
    /// <returns>An asynchronous sync operation.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction ReportFailedAsync();
  }
}
