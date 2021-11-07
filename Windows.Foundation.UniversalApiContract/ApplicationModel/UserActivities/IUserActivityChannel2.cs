// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.UserActivities.IUserActivityChannel2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.UserActivities
{
  [ExclusiveTo(typeof (UserActivityChannel))]
  [Guid(379118427, 60286, 20128, 191, 23, 164, 89, 232, 190, 112, 108)]
  [ContractVersion(typeof (UniversalApiContract), 393216)]
  internal interface IUserActivityChannel2
  {
    [RemoteAsync]
    IAsyncOperation<IVector<UserActivitySessionHistoryItem>> GetRecentUserActivitiesAsync(
      int maxUniqueActivities);

    [RemoteAsync]
    IAsyncOperation<IVector<UserActivitySessionHistoryItem>> GetSessionHistoryItemsForUserActivityAsync(
      string activityId,
      DateTime startTime);
  }
}
