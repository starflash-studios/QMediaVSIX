// Decompiled with JetBrains decompiler
// Type: Windows.System.Threading.WorkItemPriority
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.System.Threading
{
  /// <summary>Specifies the priority of a work item relative to other work items in the thread pool.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  public enum WorkItemPriority
  {
    /// <summary>The work item should run at low priority.</summary>
    Low = -1, // 0xFFFFFFFF
    /// <summary>The work item should run at normal priority. This is the default value.</summary>
    Normal = 0,
    /// <summary>The work item should run at high priority.</summary>
    High = 1,
  }
}
