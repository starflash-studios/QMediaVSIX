// Decompiled with JetBrains decompiler
// Type: Windows.Graphics.Holographic.HolographicFrame
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Graphics.Holographic
{
  /// <summary>Represents a frame of holographic content that an app must render to all cameras.</summary>
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class HolographicFrame : IHolographicFrame, IHolographicFrame2, IHolographicFrame3
  {
    /// <summary>Gets the list of HolographicCamera objects that were added since last frame.</summary>
    /// <returns>A collection of HolographicCamera objects that were added.</returns>
    public extern IVectorView<HolographicCamera> AddedCameras { [MethodImpl] get; }

    /// <summary>Gets the list of HolographicCamera objects that were removed since last frame.</summary>
    /// <returns>A collection of HolographicCamera objects that were removed.</returns>
    public extern IVectorView<HolographicCamera> RemovedCameras { [MethodImpl] get; }

    /// <summary>Gets the parameters needed to render the current frame with the specified camera pose.</summary>
    /// <param name="cameraPose">The camera pose.</param>
    /// <returns>The rendering parameters.</returns>
    [MethodImpl]
    public extern HolographicCameraRenderingParameters GetRenderingParameters(
      HolographicCameraPose cameraPose);

    /// <summary>Gets the duration of time that the frame will be on the screen.</summary>
    /// <returns>The time span.</returns>
    public extern TimeSpan Duration { [MethodImpl] get; }

    /// <summary>Gets the most recent camera location prediction for the current HolographicFrame.</summary>
    /// <returns>The prediction.</returns>
    public extern HolographicFramePrediction CurrentPrediction { [MethodImpl] get; }

    /// <summary>Computes an updated prediction for the CurrentPrediction property.</summary>
    [MethodImpl]
    public extern void UpdateCurrentPrediction();

    /// <summary>Present the current frame for all cameras and then wait until the next frame.</summary>
    /// <returns>The result of the Present call.</returns>
    [Overload("PresentUsingCurrentPrediction")]
    [MethodImpl]
    public extern HolographicFramePresentResult PresentUsingCurrentPrediction();

    /// <summary>Presents the current frame for all cameras with the specified waiting behavior.</summary>
    /// <param name="waitBehavior">The wait behavior.</param>
    /// <returns>The result of the Present call.</returns>
    [Overload("PresentUsingCurrentPredictionWithBehavior")]
    [MethodImpl]
    public extern HolographicFramePresentResult PresentUsingCurrentPrediction(
      HolographicFramePresentWaitBehavior waitBehavior);

    /// <summary>Blocks the current thread until this frame has finished and is showing on the displays.</summary>
    [MethodImpl]
    public extern void WaitForFrameToFinish();

    /// <summary>Gets an update payload that lets an application configure a specific quad layer's parameters from this frame forward.</summary>
    /// <param name="layer">The quad layer to update.</param>
    /// <returns>The update parameters.</returns>
    [MethodImpl]
    public extern HolographicQuadLayerUpdateParameters GetQuadLayerUpdateParameters(
      HolographicQuadLayer layer);

    /// <summary>Gets the unique identifier for the HolographicFrame within its parent HolographicSpace.</summary>
    /// <returns>A HolographicFrameId representing the unique identifier for the HolographicFrame.</returns>
    public extern HolographicFrameId Id { [MethodImpl] get; }
  }
}
