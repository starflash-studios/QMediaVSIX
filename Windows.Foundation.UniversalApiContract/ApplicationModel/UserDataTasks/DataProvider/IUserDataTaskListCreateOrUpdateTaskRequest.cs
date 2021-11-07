// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.UserDataTasks.DataProvider.IUserDataTaskListCreateOrUpdateTaskRequest
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.UserDataTasks.DataProvider
{
  [Guid(557020972, 21954, 17152, 130, 121, 4, 50, 110, 7, 204, 228)]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [ExclusiveTo(typeof (UserDataTaskListCreateOrUpdateTaskRequest))]
  internal interface IUserDataTaskListCreateOrUpdateTaskRequest
  {
    string TaskListId { get; }

    UserDataTask Task { get; }

    [RemoteAsync]
    IAsyncAction ReportCompletedAsync(UserDataTask createdOrUpdatedUserDataTask);

    [RemoteAsync]
    IAsyncAction ReportFailedAsync();
  }
}
