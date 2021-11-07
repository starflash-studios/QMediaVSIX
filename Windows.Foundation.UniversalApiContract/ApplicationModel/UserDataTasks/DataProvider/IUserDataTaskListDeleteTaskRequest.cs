// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.UserDataTasks.DataProvider.IUserDataTaskListDeleteTaskRequest
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.UserDataTasks.DataProvider
{
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [ExclusiveTo(typeof (UserDataTaskListDeleteTaskRequest))]
  [Guid(1267088488, 30295, 20285, 176, 116, 212, 126, 200, 223, 7, 231)]
  internal interface IUserDataTaskListDeleteTaskRequest
  {
    string TaskListId { get; }

    string TaskId { get; }

    [RemoteAsync]
    IAsyncAction ReportCompletedAsync();

    [RemoteAsync]
    IAsyncAction ReportFailedAsync();
  }
}
