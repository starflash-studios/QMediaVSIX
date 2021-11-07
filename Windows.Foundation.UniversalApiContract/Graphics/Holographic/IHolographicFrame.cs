// Decompiled with JetBrains decompiler
// Type: Windows.Graphics.Holographic.IHolographicFrame
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Graphics.Holographic
{
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  [Guid(3331886774, 43193, 12372, 166, 235, 214, 36, 182, 83, 99, 117)]
  [ExclusiveTo(typeof (HolographicFrame))]
  internal interface IHolographicFrame
  {
    IVectorView<HolographicCamera> AddedCameras { get; }

    IVectorView<HolographicCamera> RemovedCameras { get; }

    HolographicCameraRenderingParameters GetRenderingParameters(
      HolographicCameraPose cameraPose);

    TimeSpan Duration { get; }

    HolographicFramePrediction CurrentPrediction { get; }

    void UpdateCurrentPrediction();

    [Overload("PresentUsingCurrentPrediction")]
    HolographicFramePresentResult PresentUsingCurrentPrediction();

    [Overload("PresentUsingCurrentPredictionWithBehavior")]
    HolographicFramePresentResult PresentUsingCurrentPrediction(
      HolographicFramePresentWaitBehavior waitBehavior);

    void WaitForFrameToFinish();
  }
}
