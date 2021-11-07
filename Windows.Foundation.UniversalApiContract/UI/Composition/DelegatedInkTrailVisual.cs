// Decompiled with JetBrains decompiler
// Type: Windows.UI.Composition.DelegatedInkTrailVisual
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Composition
{
  [MarshalingBehavior(MarshalingType.Agile)]
  [WebHostHidden]
  [Threading(ThreadingModel.Both)]
  [Static(typeof (IDelegatedInkTrailVisualStatics), 786432, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 786432)]
  public sealed class DelegatedInkTrailVisual : Visual, IDelegatedInkTrailVisual
  {
    [MethodImpl]
    public extern uint AddTrailPoints(InkTrailPoint[] inkPoints);

    [MethodImpl]
    public extern uint AddTrailPointsWithPrediction(
      InkTrailPoint[] inkPoints,
      InkTrailPoint[] predictedInkPoints);

    [MethodImpl]
    public extern void RemoveTrailPoints(uint generationId);

    [MethodImpl]
    public extern void StartNewTrail(Color color);

    [MethodImpl]
    public static extern DelegatedInkTrailVisual Create(Compositor compositor);

    [MethodImpl]
    public static extern DelegatedInkTrailVisual CreateForSwapChain(
      Compositor compositor,
      ICompositionSurface swapChain);
  }
}
