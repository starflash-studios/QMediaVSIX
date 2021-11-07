// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.UserDataAccounts.IUserDataAccount4
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.ApplicationModel.Contacts;
using Windows.ApplicationModel.UserDataTasks;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.ApplicationModel.UserDataAccounts
{
  [ExclusiveTo(typeof (UserDataAccount))]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [Guid(3291566608, 60133, 20234, 168, 178, 28, 202, 17, 94, 0, 143)]
  internal interface IUserDataAccount4
  {
    bool CanShowCreateContactGroup { get; set; }

    IPropertySet ProviderProperties { get; }

    [RemoteAsync]
    IAsyncOperation<IVectorView<UserDataTaskList>> FindUserDataTaskListsAsync();

    [RemoteAsync]
    IAsyncOperation<IVectorView<ContactGroup>> FindContactGroupsAsync();

    [RemoteAsync]
    IAsyncOperation<string> TryShowCreateContactGroupAsync();

    bool IsProtectedUnderLock { set; }

    IRandomAccessStreamReference Icon { set; }
  }
}
