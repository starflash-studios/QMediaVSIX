// Decompiled with JetBrains decompiler
// Type: Windows.UI.Composition.CompositionScopedBatch
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Composition
{
  /// <summary>An explicitly created group of active animations or effects.</summary>
  [DualApiPartition(version = 167772164)]
  [WebHostHidden]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  [Threading(ThreadingModel.Both)]
  public sealed class CompositionScopedBatch : CompositionObject, ICompositionScopedBatch
  {
    /// <summary>Indicates whether the CompositionScopedBatch is currently opened for objects to be aggregated.</summary>
    /// <returns>Boolean indicating whether the CompositionScopedBatch is currently opened for objects to be aggregated.</returns>
    public extern bool IsActive { [MethodImpl] get; }

    /// <summary>Indicates whether the CompositionScopedBatch has been closed and can no longer accept changes.</summary>
    /// <returns>Boolean indicating whether the CompositionScopedBatch has been closed and can no longer accept changes.</returns>
    public extern bool IsEnded { [MethodImpl] get; }

    /// <summary>Closes the CompositionScopedBatch. Once the CompositionScopedBatch has been closed it cannot be suspended or resumed again.</summary>
    [MethodImpl]
    public extern void End();

    /// <summary>Resumes aggregating objects in the CompositionScopedBatch.</summary>
    [MethodImpl]
    public extern void Resume();

    /// <summary>Suspends aggregating objects in the CompositionScopedBatch.</summary>
    [MethodImpl]
    public extern void Suspend();

    /// <summary>Event triggered once all animations and effects in the CompositionScopedBatch have completed.</summary>
    public extern event TypedEventHandler<object, CompositionBatchCompletedEventArgs> Completed;
  }
}
