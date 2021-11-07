// Decompiled with JetBrains decompiler
// Type: Windows.Media.Effects.IBasicVideoEffect
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Graphics.DirectX.Direct3D11;
using Windows.Media.MediaProperties;

namespace Windows.Media.Effects
{
  /// <summary>The interface you implement to create a custom video effect.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(2187511791, 45920, 16574, 148, 155, 47, 244, 47, 243, 86, 147)]
  public interface IBasicVideoEffect : IMediaExtension
  {
    /// <summary>Gets a value indicating whether the video effect will modify the contents of the input frame.</summary>
    /// <returns>True, if the effect will not modify the input frame; otherwise, false.</returns>
    bool IsReadOnly { get; }

    /// <summary>Gets a value that indicates whether the custom video effect supports the use of GPU memory or CPU memory.</summary>
    /// <returns>A value that indicates the custom video effect's supported memory types.</returns>
    MediaMemoryTypes SupportedMemoryTypes { get; }

    /// <summary>Gets a value that indicates whether the custom video effect is time independent.</summary>
    /// <returns>True, if the video effect is time independent; otherwise, false.</returns>
    bool TimeIndependent { get; }

    /// <summary>Gets the encoding properties supported by the custom video effect.</summary>
    /// <returns>A list of supported encoding properties.</returns>
    IVectorView<VideoEncodingProperties> SupportedEncodingProperties { get; }

    /// <summary>Called to set the encoding properties of a custom video effect.</summary>
    /// <param name="encodingProperties">The encoding properties.</param>
    /// <param name="device">The Microsoft Direct3D device that can be used to create resources based on the media format described by the encoding properties.</param>
    void SetEncodingProperties(VideoEncodingProperties encodingProperties, IDirect3DDevice device);

    /// <summary>Called when frames are available for processing by a custom video effect.</summary>
    /// <param name="context">The context object that provides the input and output frames for the process operation.</param>
    void ProcessFrame(ProcessVideoFrameContext context);

    /// <summary>Called when the video effect should close and clean up allocated resources.</summary>
    /// <param name="reason">The reason the effect was closed.</param>
    void Close(MediaEffectClosedReason reason);

    /// <summary>Called to allow video effect implementations optionally discard any stored state related to frames that have already been received.</summary>
    void DiscardQueuedFrames();
  }
}
