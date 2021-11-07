// Decompiled with JetBrains decompiler
// Type: Windows.System.AppDiagnosticInfoWatcherEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.System
{
  /// <summary>The data object passed to an **AppDiagnosticInfoWatcher ** event.</summary>
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  [DualApiPartition(version = 167772164)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  public sealed class AppDiagnosticInfoWatcherEventArgs : IAppDiagnosticInfoWatcherEventArgs
  {
    /// <summary>Gets diagnostic info for the app package.</summary>
    /// <returns>The AppDiagnosticInfo for the current event.</returns>
    public extern AppDiagnosticInfo AppDiagnosticInfo { [MethodImpl] get; }
  }
}
