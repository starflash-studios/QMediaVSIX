// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.UserDataTasks.IUserDataTaskManager
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.System;

namespace Windows.ApplicationModel.UserDataTasks
{
  [ExclusiveTo(typeof (UserDataTaskManager))]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [Guid(2219952404, 58891, 18601, 146, 17, 127, 184, 165, 108, 184, 76)]
  internal interface IUserDataTaskManager
  {
    [RemoteAsync]
    IAsyncOperation<UserDataTaskStore> RequestStoreAsync(
      UserDataTaskStoreAccessType accessType);

    User User { get; }
  }
}
