// Decompiled with JetBrains decompiler
// Type: Windows.System.Threading.WorkItemHandler
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.System.Threading
{
  /// <summary>Represents a method that is called when a work item runs.</summary>
  /// <param name="operation">The work item to associate with the callback method.</param>
  [Guid(488278923, 64102, 16719, 156, 189, 182, 95, 201, 157, 23, 250)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  public delegate void WorkItemHandler(IAsyncAction operation);
}
