// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.UserDataTasks.UserDataTaskStore
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.UserDataTasks
{
  /// <summary>Represents a database that contains tasks.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [Threading(ThreadingModel.Both)]
  public sealed class UserDataTaskStore : IUserDataTaskStore
  {
    /// <summary>Asynchronously creates a UserDataTaskList with the specified name.</summary>
    /// <param name="name">A name for the new UserDataTaskList.</param>
    /// <returns>The newly created UserDataTaskList.</returns>
    [Overload("CreateListAsync")]
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<UserDataTaskList> CreateListAsync(
      string name);

    /// <summary>Asynchronously creates a UserDataTaskList with the specified name.</summary>
    /// <param name="name">A name for the new UserDataTaskList.</param>
    /// <param name="userDataAccountId">The ID for the UserDataAccount to use when creating the UserDataTaskList.</param>
    /// <returns>
    /// </returns>
    [RemoteAsync]
    [Overload("CreateListInAccountAsync")]
    [MethodImpl]
    public extern IAsyncOperation<UserDataTaskList> CreateListAsync(
      string name,
      string userDataAccountId);

    /// <summary>Asynchronously returns the list of UserDataTaskList objects.</summary>
    /// <returns>The list of UserDataTaskList objects.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<IVectorView<UserDataTaskList>> FindListsAsync();

    /// <summary>Asynchronously gets the UserDataTaskList with the specified ID.</summary>
    /// <param name="taskListId">The ID of the UserDataTaskList to retrieve.</param>
    /// <returns>The UserDataTaskList with the specified ID or null if the list is not found.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<UserDataTaskList> GetListAsync(
      string taskListId);
  }
}
