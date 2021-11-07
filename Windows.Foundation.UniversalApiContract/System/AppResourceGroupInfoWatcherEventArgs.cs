// Decompiled with JetBrains decompiler
// Type: Windows.System.AppResourceGroupInfoWatcherEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.System
{
  /// <summary>Provides information about app resource groups.</summary>
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [DualApiPartition(version = 167772164)]
  [Threading(ThreadingModel.Both)]
  public sealed class AppResourceGroupInfoWatcherEventArgs : IAppResourceGroupInfoWatcherEventArgs
  {
    /// <summary>Gets diagnostic info for the resource group.</summary>
    /// <returns>The diagnostic info for the apps associated with the  AppResourceGroupInfo for the current event.</returns>
    public extern IVectorView<AppDiagnosticInfo> AppDiagnosticInfos { [MethodImpl] get; }

    /// <summary>Gets diagnostic info, such as memory usage, and energy use.</summary>
    /// <returns>The **AppResourceGroupInfo** that was added or removed.</returns>
    public extern AppResourceGroupInfo AppResourceGroupInfo { [MethodImpl] get; }
  }
}
