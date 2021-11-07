// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.UserDataTasks.DataProvider.IUserDataTaskListSyncManagerSyncRequestEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.UserDataTasks.DataProvider
{
  [Guid(2393709586, 30350, 17341, 131, 133, 92, 220, 53, 31, 253, 234)]
  [ExclusiveTo(typeof (UserDataTaskListSyncManagerSyncRequestEventArgs))]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  internal interface IUserDataTaskListSyncManagerSyncRequestEventArgs
  {
    UserDataTaskListSyncManagerSyncRequest Request { get; }

    Deferral GetDeferral();
  }
}
