// Decompiled with JetBrains decompiler
// Type: Windows.Media.Effects.IVideoCompositor
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Graphics.DirectX.Direct3D11;
using Windows.Media.MediaProperties;

namespace Windows.Media.Effects
{
  /// <summary>The interface you implement to create a custom video compositor.</summary>
  [Guid(2232464446, 16908, 16911, 150, 199, 124, 152, 187, 161, 252, 85)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public interface IVideoCompositor : IMediaExtension
  {
    /// <summary>Gets a value that indicates whether the custom video effect is time independent.</summary>
    /// <returns>True, if the video effect is time independent; otherwise, false.</returns>
    bool TimeIndependent { get; }

    /// <summary>Called to set the encoding properties of a custom video compositor.</summary>
    /// <param name="backgroundProperties">The encoding properties.</param>
    /// <param name="device">The Microsoft Direct3D device that can be used to create resources based on the media format described by the encoding properties.</param>
    void SetEncodingProperties(VideoEncodingProperties backgroundProperties, IDirect3DDevice device);

    /// <summary>Called when frames are available for composition by a custom video compositor.</summary>
    /// <param name="context">The context object that provides the input and output frames for the composition operation.</param>
    void CompositeFrame(CompositeVideoFrameContext context);

    /// <summary>Called when the video compositor should close and clean up allocated resources.</summary>
    /// <param name="reason">The reason the compositor was closed.</param>
    void Close(MediaEffectClosedReason reason);

    /// <summary>Called to allow video compositor implementations optionally discard any stored state related to frames that have already been received.</summary>
    void DiscardQueuedFrames();
  }
}
