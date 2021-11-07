// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.UserActivities.Core.ICoreUserActivityManagerStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.UserActivities.Core
{
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  [ExclusiveTo(typeof (CoreUserActivityManager))]
  [Guid(3392854786, 42174, 19789, 191, 168, 103, 149, 244, 38, 78, 251)]
  internal interface ICoreUserActivityManagerStatics
  {
    UserActivitySession CreateUserActivitySessionInBackground(
      UserActivity activity);

    [RemoteAsync]
    IAsyncAction DeleteUserActivitySessionsInTimeRangeAsync(
      UserActivityChannel channel,
      DateTime startTime,
      DateTime endTime);
  }
}
