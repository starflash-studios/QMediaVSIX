// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.UserDataTasks.UserDataTaskWeekOfMonth
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.UserDataTasks
{
  /// <summary>Specifies the week of the month for which the task occurs.</summary>
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  public enum UserDataTaskWeekOfMonth
  {
    /// <summary>The task occurs on the first week of the month.</summary>
    First,
    /// <summary>The task occurs on the second week of the month.</summary>
    Second,
    /// <summary>The task occurs on the third week of the month.</summary>
    Third,
    /// <summary>The task occurs on the fourth week of the month.</summary>
    Fourth,
    /// <summary>The appointment occurs on the last week of the month.</summary>
    Last,
  }
}
