// Decompiled with JetBrains decompiler
// Type: Windows.Foundation.Diagnostics.LogFileGeneratedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation.Metadata;
using Windows.Storage;

namespace Windows.Foundation.Diagnostics
{
  /// <summary>Provides data for the LogFileGenerated event.</summary>
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class LogFileGeneratedEventArgs : ILogFileGeneratedEventArgs
  {
    /// <summary>Gets the log file.</summary>
    /// <returns>The log file.</returns>
    public extern StorageFile File { [MethodImpl] get; }
  }
}
