// Decompiled with JetBrains decompiler
// Type: Windows.UI.Composition.IDelegatedInkTrailVisualStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Composition
{
  [ExclusiveTo(typeof (DelegatedInkTrailVisual))]
  [Guid(229600213, 17094, 21852, 146, 103, 224, 172, 102, 58, 248, 54)]
  [ContractVersion(typeof (UniversalApiContract), 786432)]
  [WebHostHidden]
  internal interface IDelegatedInkTrailVisualStatics
  {
    DelegatedInkTrailVisual Create(Compositor compositor);

    DelegatedInkTrailVisual CreateForSwapChain(
      Compositor compositor,
      ICompositionSurface swapChain);
  }
}
