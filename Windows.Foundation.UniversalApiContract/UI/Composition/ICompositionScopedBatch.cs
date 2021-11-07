// Decompiled with JetBrains decompiler
// Type: Windows.UI.Composition.ICompositionScopedBatch
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Composition
{
  [Guid(218159824, 64263, 18173, 140, 114, 98, 128, 209, 163, 209, 221)]
  [WebHostHidden]
  [ExclusiveTo(typeof (CompositionScopedBatch))]
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  internal interface ICompositionScopedBatch
  {
    bool IsActive { get; }

    bool IsEnded { get; }

    void End();

    void Resume();

    void Suspend();

    event TypedEventHandler<object, CompositionBatchCompletedEventArgs> Completed;
  }
}
