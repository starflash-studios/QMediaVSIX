// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.UserActivities.IUserActivityChannel
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.UserActivities
{
  [Guid(3133208760, 41188, 18491, 185, 72, 156, 186, 189, 6, 7, 12)]
  [ExclusiveTo(typeof (UserActivityChannel))]
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  internal interface IUserActivityChannel
  {
    [Overload("GetOrCreateUserActivityAsync")]
    [RemoteAsync]
    IAsyncOperation<UserActivity> GetOrCreateUserActivityAsync(
      string activityId);

    [RemoteAsync]
    IAsyncAction DeleteActivityAsync(string activityId);

    [RemoteAsync]
    IAsyncAction DeleteAllActivitiesAsync();
  }
}
