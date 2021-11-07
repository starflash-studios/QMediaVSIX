// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.UserDataTasks.UserDataTaskKind
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.UserDataTasks
{
  /// <summary>Defines the type of task.</summary>
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  public enum UserDataTaskKind
  {
    /// <summary>A task with no special conditions that cause it to reoccur.</summary>
    Single,
    /// <summary>A task that reoccurs at specific date and at some regular interval.</summary>
    Recurring,
    /// <summary>A task that reoccurs at some regular interval.</summary>
    Regenerating,
  }
}
