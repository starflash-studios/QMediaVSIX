// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.UserDataTasks.DataProvider.IUserDataTaskListCompleteTaskRequest
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.UserDataTasks.DataProvider
{
  [Guid(4133360803, 6722, 18906, 133, 82, 40, 115, 229, 44, 85, 235)]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [ExclusiveTo(typeof (UserDataTaskListCompleteTaskRequest))]
  internal interface IUserDataTaskListCompleteTaskRequest
  {
    string TaskListId { get; }

    string TaskId { get; }

    [RemoteAsync]
    IAsyncAction ReportCompletedAsync(string completedTaskId);

    [RemoteAsync]
    IAsyncAction ReportFailedAsync();
  }
}
