// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.UserDataTasks.UserDataTaskRegenerationUnit
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.UserDataTasks
{
  /// <summary>Specifies the frequency for which a task occurs.</summary>
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  public enum UserDataTaskRegenerationUnit
  {
    /// <summary>Task occurs daily.</summary>
    Daily = 0,
    /// <summary>Task occurs weekly.</summary>
    Weekly = 1,
    /// <summary>Task occurs monthly.</summary>
    Monthly = 2,
    /// <summary>Task occurs yearly.</summary>
    Yearly = 4,
  }
}
