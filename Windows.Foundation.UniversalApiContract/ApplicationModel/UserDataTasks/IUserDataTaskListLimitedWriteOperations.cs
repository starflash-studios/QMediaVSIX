// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.UserDataTasks.IUserDataTaskListLimitedWriteOperations
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.UserDataTasks
{
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [Guid(2057463794, 24696, 16771, 145, 158, 79, 41, 241, 156, 250, 233)]
  [ExclusiveTo(typeof (UserDataTaskListLimitedWriteOperations))]
  internal interface IUserDataTaskListLimitedWriteOperations
  {
    [RemoteAsync]
    IAsyncOperation<string> TryCompleteTaskAsync(string userDataTaskId);

    [RemoteAsync]
    IAsyncOperation<bool> TryCreateOrUpdateTaskAsync(UserDataTask userDataTask);

    [RemoteAsync]
    IAsyncOperation<bool> TryDeleteTaskAsync(string userDataTaskId);

    [RemoteAsync]
    IAsyncOperation<bool> TrySkipOccurrenceAsync(string userDataTaskId);
  }
}
