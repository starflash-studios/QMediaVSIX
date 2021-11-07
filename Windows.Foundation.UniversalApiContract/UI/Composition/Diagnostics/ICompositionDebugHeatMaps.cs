// Decompiled with JetBrains decompiler
// Type: Windows.UI.Composition.Diagnostics.ICompositionDebugHeatMaps
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Composition.Diagnostics
{
  [ContractVersion(typeof (UniversalApiContract), 393216)]
  [Guid(3835465900, 12275, 22533, 113, 140, 183, 37, 238, 7, 101, 15)]
  [WebHostHidden]
  [ExclusiveTo(typeof (CompositionDebugHeatMaps))]
  internal interface ICompositionDebugHeatMaps
  {
    void Hide(Visual subtree);

    void ShowMemoryUsage(Visual subtree);

    void ShowOverdraw(Visual subtree, CompositionDebugOverdrawContentKinds contentKinds);

    void ShowRedraw(Visual subtree);
  }
}
