// Decompiled with JetBrains decompiler
// Type: Windows.System.AppExecutionStateChangeResult
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.System
{
  /// <summary>Provides the result of an attempt to change an app's execution state (such as from running to suspended).</summary>
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 393216)]
  [DualApiPartition(version = 167772165)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class AppExecutionStateChangeResult : IAppExecutionStateChangeResult
  {
    /// <summary>Gets the error information, if any, that may have resulted from trying to change the apps execution state.</summary>
    /// <returns>The exception information.</returns>
    public extern HResult ExtendedError { [MethodImpl] get; }
  }
}
