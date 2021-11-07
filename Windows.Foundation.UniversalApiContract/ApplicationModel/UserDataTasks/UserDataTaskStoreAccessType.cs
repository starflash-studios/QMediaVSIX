// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.UserDataTasks.UserDataTaskStoreAccessType
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.UserDataTasks
{
  /// <summary>Defines the type of access the app has to the UserDataTaskStore.</summary>
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  public enum UserDataTaskStoreAccessType
  {
    /// <summary>Read and write tasks that belong to the app only.</summary>
    AppTasksReadWrite,
    /// <summary>Read and write access limited to operations available in the UserDataTaskListLimitedWriteOperations class.</summary>
    AllTasksLimitedReadWrite,
  }
}
