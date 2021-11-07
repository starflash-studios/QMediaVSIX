// Decompiled with JetBrains decompiler
// Type: Windows.Graphics.Printing.Workflow.PrintWorkflowSessionStatus
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Graphics.Printing.Workflow
{
  /// <summary>Contains values that describe the status of the current print workflow session.</summary>
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  public enum PrintWorkflowSessionStatus
  {
    /// <summary>The current session has started.</summary>
    Started,
    /// <summary>The current session has completed.</summary>
    Completed,
    /// <summary>The current session has been aborted.</summary>
    Aborted,
    /// <summary>The current session has been closed.</summary>
    Closed,
    [ContractVersion("Windows.Foundation.UniversalApiContract", 851968)] PdlDataAvailableForModification,
  }
}
