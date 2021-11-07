// Decompiled with JetBrains decompiler
// Type: Windows.System.AppResourceGroupInfoWatcherExecutionStateChangedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.System
{
  /// <summary>Provides info about the execution state of this resource group when the state changes.</summary>
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [DualApiPartition(version = 167772164)]
  public sealed class AppResourceGroupInfoWatcherExecutionStateChangedEventArgs : 
    IAppResourceGroupInfoWatcherExecutionStateChangedEventArgs
  {
    /// <summary>Gets diagnostic info for the resource group.</summary>
    /// <returns>The diagnostic info for each resource group associated with this app.</returns>
    public extern IVectorView<AppDiagnosticInfo> AppDiagnosticInfos { [MethodImpl] get; }

    /// <summary>Gets diagnostic info, such as memory usage over time, energy use over time, and so on.</summary>
    /// <returns>The diagnostic info for this app.</returns>
    public extern AppResourceGroupInfo AppResourceGroupInfo { [MethodImpl] get; }
  }
}
