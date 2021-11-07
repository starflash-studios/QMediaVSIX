// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.UserDataTasks.DataProvider.UserDataTaskDataProviderConnection
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.UserDataTasks.DataProvider
{
  /// <summary>Represents a connection to a data provider client.</summary>
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class UserDataTaskDataProviderConnection : IUserDataTaskDataProviderConnection
  {
    /// <summary>Raised when the client app attempts to create or update a task.</summary>
    public extern event TypedEventHandler<UserDataTaskDataProviderConnection, UserDataTaskListCreateOrUpdateTaskRequestEventArgs> CreateOrUpdateTaskRequested;

    /// <summary>Raised when the client app attempts to sync all calendar appointments with the server.</summary>
    public extern event TypedEventHandler<UserDataTaskDataProviderConnection, UserDataTaskListSyncManagerSyncRequestEventArgs> SyncRequested;

    /// <summary>Raised when the client app attempts to skip the current instance of a reoccurring task and move to the next instance.</summary>
    public extern event TypedEventHandler<UserDataTaskDataProviderConnection, UserDataTaskListSkipOccurrenceRequestEventArgs> SkipOccurrenceRequested;

    /// <summary>Raised when the client app attempts to mark a task as completed.</summary>
    public extern event TypedEventHandler<UserDataTaskDataProviderConnection, UserDataTaskListCompleteTaskRequestEventArgs> CompleteTaskRequested;

    /// <summary>Raised when the client app attempts to delete a task.</summary>
    public extern event TypedEventHandler<UserDataTaskDataProviderConnection, UserDataTaskListDeleteTaskRequestEventArgs> DeleteTaskRequested;

    /// <summary>Call this method to indicate that all event handlers have been set and the data provider is ready to start handling requests.</summary>
    [MethodImpl]
    public extern void Start();
  }
}
