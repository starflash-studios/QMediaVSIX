// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Display.Core.DisplayTaskPool
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Display.Core
{
  /// <summary>Provides methods to allocate and execute tasks on a DisplayDevice.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 458752)]
  public sealed class DisplayTaskPool : IDisplayTaskPool, IDisplayTaskPool2
  {
    /// <summary>Creates a DisplayTask object.</summary>
    /// <returns>A DisplayTask value.</returns>
    [MethodImpl]
    public extern DisplayTask CreateTask();

    /// <summary>Queues a DisplayTask for execution on the device. Tasks are executed asynchronously, so this method returns immediately.</summary>
    /// <param name="task">
    /// </param>
    [Deprecated("Use TryExecuteTask instead of ExecuteTask. For more info see MSDN", DeprecationType.Deprecate, 851968, "Windows.Foundation.UniversalApiContract")]
    [MethodImpl]
    public extern void ExecuteTask(DisplayTask task);

    [MethodImpl]
    public extern DisplayTaskResult TryExecuteTask(DisplayTask task);
  }
}
