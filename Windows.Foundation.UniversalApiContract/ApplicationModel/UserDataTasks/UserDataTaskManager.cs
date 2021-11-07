// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.UserDataTasks.UserDataTaskManager
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.System;

namespace Windows.ApplicationModel.UserDataTasks
{
  /// <summary>Represents a service that source apps can call to access task data.</summary>
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  [Static(typeof (IUserDataTaskManagerStatics), 262144, "Windows.Foundation.UniversalApiContract")]
  public sealed class UserDataTaskManager : IUserDataTaskManager
  {
    /// <summary>Retrieves a UserDataTaskStore object that enables searching or retrieving contacts on the device.</summary>
    /// <param name="accessType">Specifies the type of read/write access requested.</param>
    /// <returns>An asynchronous operation that returns a UserDataTaskStore object on successful completion.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<UserDataTaskStore> RequestStoreAsync(
      UserDataTaskStoreAccessType accessType);

    /// <summary>Gets the user associated with this UserDataTaskManager.</summary>
    /// <returns>The user associated with this UserDataTaskManager.</returns>
    public extern User User { [MethodImpl] get; }

    /// <summary>Gets the default UserTaskManager object.</summary>
    /// <returns>Gets the default UserTaskManager object.</returns>
    [MethodImpl]
    public static extern UserDataTaskManager GetDefault();

    /// <summary>Gets the UserTaskManager object for the specified user.</summary>
    /// <param name="user">The user account to use to get the UserTaskManager object.</param>
    /// <returns>The UserTaskManager object for the specified user.</returns>
    [MethodImpl]
    public static extern UserDataTaskManager GetForUser(User user);
  }
}
