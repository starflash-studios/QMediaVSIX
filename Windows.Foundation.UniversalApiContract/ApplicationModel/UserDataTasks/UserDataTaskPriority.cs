// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.UserDataTasks.UserDataTaskPriority
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.UserDataTasks
{
  /// <summary>Specifies the priority of the task.</summary>
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  public enum UserDataTaskPriority
  {
    /// <summary>The task is a low priority.</summary>
    Low = -1, // 0xFFFFFFFF
    /// <summary>The task has the normal priority.</summary>
    Normal = 0,
    /// <summary>The task is a high priority.</summary>
    High = 1,
  }
}
