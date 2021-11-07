// Decompiled with JetBrains decompiler
// Type: Windows.System.Threading.WorkItemOptions
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.System.Threading
{
  /// <summary>Specifies how work items should be run.</summary>
  [Flags]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  public enum WorkItemOptions : uint
  {
    /// <summary>The work item should be run when the thread pool has an available worker thread.</summary>
    None = 0,
    /// <summary>The work items should be run simultaneously with other work items sharing a processor.</summary>
    TimeSliced = 1,
  }
}
