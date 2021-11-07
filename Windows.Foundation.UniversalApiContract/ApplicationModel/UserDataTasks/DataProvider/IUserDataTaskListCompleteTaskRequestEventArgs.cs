// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.UserDataTasks.DataProvider.IUserDataTaskListCompleteTaskRequestEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.UserDataTasks.DataProvider
{
  [ExclusiveTo(typeof (UserDataTaskListCompleteTaskRequestEventArgs))]
  [Guid(3615242557, 19698, 18605, 135, 253, 150, 63, 14, 170, 122, 149)]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  internal interface IUserDataTaskListCompleteTaskRequestEventArgs
  {
    UserDataTaskListCompleteTaskRequest Request { get; }

    Deferral GetDeferral();
  }
}
