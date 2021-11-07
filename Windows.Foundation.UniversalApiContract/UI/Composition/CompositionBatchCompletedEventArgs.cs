// Decompiled with JetBrains decompiler
// Type: Windows.UI.Composition.CompositionBatchCompletedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Composition
{
  /// <summary>Arguments for the CompositionCommitBatch.Completed or CompositionScopedBatch.Completed events.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [WebHostHidden]
  [Threading(ThreadingModel.Both)]
  [DualApiPartition(version = 167772164)]
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  public sealed class CompositionBatchCompletedEventArgs : 
    CompositionObject,
    ICompositionBatchCompletedEventArgs
  {
  }
}
