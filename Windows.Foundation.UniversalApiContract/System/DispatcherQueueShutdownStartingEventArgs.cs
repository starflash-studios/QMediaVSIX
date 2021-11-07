// Decompiled with JetBrains decompiler
// Type: Windows.System.DispatcherQueueShutdownStartingEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.System
{
  /// <summary>Provides the arguments for the ShutdownStarting event.</summary>
  [DualApiPartition(version = 167772164)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  [WebHostHidden]
  public sealed class DispatcherQueueShutdownStartingEventArgs : 
    IDispatcherQueueShutdownStartingEventArgs
  {
    /// <summary>Gets a deferral object so that you can use to continue to post work to the **DisbpatcherQueue** until you mark the deferral complete.</summary>
    /// <returns>The deferral object.</returns>
    [MethodImpl]
    public extern Deferral GetDeferral();
  }
}
