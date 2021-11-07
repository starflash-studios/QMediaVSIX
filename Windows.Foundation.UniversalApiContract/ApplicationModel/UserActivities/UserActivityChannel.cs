// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.UserActivities.UserActivityChannel
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Security.Credentials;
using Windows.System;

namespace Windows.ApplicationModel.UserActivities
{
  /// <summary>Creates or gets UserActivity objects created on this or another device.</summary>
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  [Threading(ThreadingModel.Both)]
  [Static(typeof (IUserActivityChannelStatics3), 524288, "Windows.Foundation.UniversalApiContract")]
  [Static(typeof (IUserActivityChannelStatics2), 393216, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Static(typeof (IUserActivityChannelStatics), 327680, "Windows.Foundation.UniversalApiContract")]
  public sealed class UserActivityChannel : IUserActivityChannel, IUserActivityChannel2
  {
    /// <summary>Create (or get) a UserActivity with the specified id.</summary>
    /// <param name="activityId">The identifier for the **UserActivity**.</param>
    /// <returns>An existing **UserActivity** if the **activityId** matches; otherwise a new **UserActivity** that is given the specified id.</returns>
    [RemoteAsync]
    [Overload("GetOrCreateUserActivityAsync")]
    [MethodImpl]
    public extern IAsyncOperation<UserActivity> GetOrCreateUserActivityAsync(
      string activityId);

    /// <summary>Delete a specific user activity.</summary>
    /// <param name="activityId">The identifier of the user activity to delete.</param>
    /// <returns>An asynchronous action.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction DeleteActivityAsync(string activityId);

    /// <summary>Deletes all of the user activities registered by this app.</summary>
    /// <returns>An asynchronous action.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction DeleteAllActivitiesAsync();

    /// <summary>Get up to the specified number of the most recently engaged user activities, sorted by the time each user activity ended.</summary>
    /// <param name="maxUniqueActivities">The maximum number of user activities to get. Fewer may be returned if there aren't as many user activities as requested.</param>
    /// <returns>A list of user activities, sorted by when the activities ended.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<IVector<UserActivitySessionHistoryItem>> GetRecentUserActivitiesAsync(
      int maxUniqueActivities);

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<IVector<UserActivitySessionHistoryItem>> GetSessionHistoryItemsForUserActivityAsync(
      string activityId,
      DateTime startTime);

    /// <summary>Gets a UserActivityChannel object that can be used to get or create UserActivity objects for the specified user in the context of the current app.</summary>
    /// <param name="user">The User that you want to get or create UserActivity objects for.</param>
    /// <returns>The UserActivityChannel object for the specified user.</returns>
    [MethodImpl]
    public static extern UserActivityChannel GetForUser(User user);

    /// <summary>Disable the automatic creation of a session when a new UserActivity is created.</summary>
    [MethodImpl]
    public static extern void DisableAutoSessionCreation();

    /// <summary>Get a channel, specific to a specified web account, to use to record user activity.</summary>
    /// <param name="account">The web account to associate user activity with.</param>
    /// <returns>The channel to use to record user activity. The channel will be associated with the web account.</returns>
    [MethodImpl]
    public static extern UserActivityChannel TryGetForWebAccount(
      WebAccount account);

    /// <summary>Provides access to the User Activities associated with the user's Managed Service Account (MSA).</summary>
    /// <returns>A channel that can be used to create or get User Activity objects.</returns>
    [MethodImpl]
    public static extern UserActivityChannel GetDefault();
  }
}
