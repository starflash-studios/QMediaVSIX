// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.UserActivities.Core.CoreUserActivityManager
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.UserActivities.Core
{
  /// <summary>Manages the creation and deletion of user activities.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  [Static(typeof (ICoreUserActivityManagerStatics), 327680, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  public static class CoreUserActivityManager
  {
    /// <summary>Creates a user activity session.</summary>
    /// <param name="activity">
    /// </param>
    /// <returns>
    /// </returns>
    [MethodImpl]
    public static extern UserActivitySession CreateUserActivitySessionInBackground(
      UserActivity activity);

    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncAction DeleteUserActivitySessionsInTimeRangeAsync(
      UserActivityChannel channel,
      DateTime startTime,
      DateTime endTime);
  }
}
