// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Display.Core.DisplayTask
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Display.Core
{
  /// <summary>Represents a set of operations that can be queued and executed atomically by display hardware.</summary>
  [ContractVersion(typeof (UniversalApiContract), 458752)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class DisplayTask : IDisplayTask, IDisplayTask2
  {
    /// <summary>Sets this DisplayTask to present content to a source using the parameters specified by a DisplayScanout when executed.</summary>
    /// <param name="scanout">
    /// </param>
    [MethodImpl]
    public extern void SetScanout(DisplayScanout scanout);

    /// <summary>Sets the operations for this DisplayTask to occur once the specified GPU fence is signaled with the specified value.</summary>
    /// <param name="readyFence">A DisplayFence object representing the GPU fence to wait on before performing this task's operations.</param>
    /// <param name="readyFenceValue">The value of the GPU fence to wait on.</param>
    [MethodImpl]
    public extern void SetWait(DisplayFence readyFence, ulong readyFenceValue);

    [MethodImpl]
    public extern void SetSignal(DisplayTaskSignalKind signalKind, DisplayFence fence);
  }
}
