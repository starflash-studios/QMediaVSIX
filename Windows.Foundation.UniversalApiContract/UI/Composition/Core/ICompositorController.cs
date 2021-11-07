// Decompiled with JetBrains decompiler
// Type: Windows.UI.Composition.Core.ICompositorController
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Composition.Core
{
  [Guid(762704730, 28839, 17301, 186, 45, 206, 240, 177, 131, 153, 249)]
  [ExclusiveTo(typeof (CompositorController))]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 393216)]
  internal interface ICompositorController
  {
    Compositor Compositor { get; }

    void Commit();

    [RemoteAsync]
    IAsyncAction EnsurePreviousCommitCompletedAsync();

    event TypedEventHandler<CompositorController, object> CommitNeeded;
  }
}
