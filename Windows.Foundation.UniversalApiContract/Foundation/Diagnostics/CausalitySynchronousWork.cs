// Decompiled with JetBrains decompiler
// Type: Windows.Foundation.Diagnostics.CausalitySynchronousWork
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation.Metadata;

namespace Windows.Foundation.Diagnostics
{
  /// <summary>Indicates the relationship between a work item and an asynchronous operation.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum CausalitySynchronousWork
  {
    /// <summary>The work item being scheduled is running due to the completion of the asynchronous operation.</summary>
    CompletionNotification,
    /// <summary>The work item being scheduled is running due to reaching a milestone within the asynchronous operation.</summary>
    ProgressNotification,
    /// <summary>The work item being scheduled is part of the actual work of the asynchronous operation, like opening a file.</summary>
    Execution,
  }
}
