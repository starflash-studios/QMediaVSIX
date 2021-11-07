// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.UserDataTasks.DataProvider.UserDataTaskListSkipOccurrenceRequest
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.UserDataTasks.DataProvider
{
  /// <summary>Details of a request to skip the current instance of a reoccurring task and move to the next instance.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  public sealed class UserDataTaskListSkipOccurrenceRequest : IUserDataTaskListSkipOccurrenceRequest
  {
    /// <summary>Gets the ID of the task list that contains the task to be skipped.</summary>
    /// <returns>The ID of the task list that contains the task to be skipped.</returns>
    public extern string TaskListId { [MethodImpl] get; }

    /// <summary>Gets the task ID of the task to be skipped.</summary>
    /// <returns>The task ID of the task to be skipped.</returns>
    public extern string TaskId { [MethodImpl] get; }

    /// <summary>Informs the client app that the request was processed successfully.</summary>
    /// <returns>An asynchronous operation.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction ReportCompletedAsync();

    /// <summary>Informs the client that the request was not processed successfully.</summary>
    /// <returns>An asynchronous operation.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction ReportFailedAsync();
  }
}
