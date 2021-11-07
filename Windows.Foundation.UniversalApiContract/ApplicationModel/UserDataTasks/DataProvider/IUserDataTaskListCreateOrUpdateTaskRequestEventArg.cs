// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.UserDataTasks.DataProvider.IUserDataTaskListCreateOrUpdateTaskRequestEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.UserDataTasks.DataProvider
{
  [Guid(314923602, 58232, 16795, 174, 56, 165, 233, 230, 4, 71, 110)]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [ExclusiveTo(typeof (UserDataTaskListCreateOrUpdateTaskRequestEventArgs))]
  internal interface IUserDataTaskListCreateOrUpdateTaskRequestEventArgs
  {
    UserDataTaskListCreateOrUpdateTaskRequest Request { get; }

    Deferral GetDeferral();
  }
}
