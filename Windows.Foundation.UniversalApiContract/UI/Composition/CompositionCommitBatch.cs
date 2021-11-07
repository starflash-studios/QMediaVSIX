// Decompiled with JetBrains decompiler
// Type: Windows.UI.Composition.CompositionCommitBatch
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Composition
{
  /// <summary>A group of active animations or effects.</summary>
  [DualApiPartition(version = 167772164)]
  [WebHostHidden]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  [Threading(ThreadingModel.Both)]
  public sealed class CompositionCommitBatch : CompositionObject, ICompositionCommitBatch
  {
    /// <summary>Indicates whether the CompositionCommitBatch is currently opened for objects to be aggregated.</summary>
    /// <returns>Boolean indicating whether the CompositionCommitBatch is currently opened for objects to be aggregated.</returns>
    public extern bool IsActive { [MethodImpl] get; }

    /// <summary>Indicates whether the CompositionCommitBatch has been closed and can no longer accept changes.</summary>
    /// <returns>Boolean indicating whether the CompositionCommitBatch has been closed and can no longer accept changes.</returns>
    public extern bool IsEnded { [MethodImpl] get; }

    /// <summary>Event that is triggered when all objects in a CompositionCommitBatch have completed.</summary>
    public extern event TypedEventHandler<object, CompositionBatchCompletedEventArgs> Completed;
  }
}
