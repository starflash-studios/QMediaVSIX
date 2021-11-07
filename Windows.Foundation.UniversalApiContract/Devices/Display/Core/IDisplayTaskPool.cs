// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Display.Core.IDisplayTaskPool
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Display.Core
{
  [Guid(3329631549, 9085, 21832, 170, 250, 62, 81, 127, 239, 239, 28)]
  [ExclusiveTo(typeof (DisplayTaskPool))]
  [ContractVersion(typeof (UniversalApiContract), 458752)]
  internal interface IDisplayTaskPool
  {
    DisplayTask CreateTask();

    [Deprecated("Use TryExecuteTask instead of ExecuteTask. For more info see MSDN", DeprecationType.Deprecate, 851968, "Windows.Foundation.UniversalApiContract")]
    void ExecuteTask(DisplayTask task);
  }
}
