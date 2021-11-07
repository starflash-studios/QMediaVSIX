// Decompiled with JetBrains decompiler
// Type: Windows.Foundation.Diagnostics.CausalityRelation
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation.Metadata;

namespace Windows.Foundation.Diagnostics
{
  /// <summary>Tracks ways that synchronous work items may interact with asynchronous operations.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum CausalityRelation
  {
    /// <summary>Indicates that a synchronous work items has assigned a callback or continuation to be run by an asynchronous operation.</summary>
    AssignDelegate,
    /// <summary>Indicates that a synchronous work item has satisfied part of a join asynchronous operation.</summary>
    Join,
    /// <summary>Indicates that a synchronous work item has satisfied a choice asynchronous operation.</summary>
    Choice,
    /// <summary>Indicates that a synchronous work item was canceled.</summary>
    Cancel,
    /// <summary>Indicates that a synchronous work item caused an error in an asynchronous operation.</summary>
    Error,
  }
}
