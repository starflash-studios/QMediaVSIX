// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.UserDataTasks.IUserDataTaskStore
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.UserDataTasks
{
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [Guid(4033518768, 61915, 17850, 138, 98, 8, 96, 4, 192, 33, 61)]
  [ExclusiveTo(typeof (UserDataTaskStore))]
  internal interface IUserDataTaskStore
  {
    [Overload("CreateListAsync")]
    [RemoteAsync]
    IAsyncOperation<UserDataTaskList> CreateListAsync(string name);

    [Overload("CreateListInAccountAsync")]
    [RemoteAsync]
    IAsyncOperation<UserDataTaskList> CreateListAsync(
      string name,
      string userDataAccountId);

    [RemoteAsync]
    IAsyncOperation<IVectorView<UserDataTaskList>> FindListsAsync();

    [RemoteAsync]
    IAsyncOperation<UserDataTaskList> GetListAsync(string taskListId);
  }
}
