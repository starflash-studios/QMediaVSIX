// Decompiled with JetBrains decompiler
// Type: Windows.Media.Effects.IBasicAudioEffect
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Media.MediaProperties;

namespace Windows.Media.Effects
{
  /// <summary>The interface you implement to create a custom audio effect.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(2349214803, 27584, 18616, 169, 154, 75, 65, 85, 15, 19, 89)]
  public interface IBasicAudioEffect : IMediaExtension
  {
    /// <summary>Gets a value that indicates whether the input frame is used for the output of the audio effect.</summary>
    /// <returns>True if the input frame is used for output; otherwise, false.</returns>
    bool UseInputFrameForOutput { get; }

    /// <summary>Gets the encoding properties supported by the custom audio effect.</summary>
    /// <returns>A list of supported encoding properties.</returns>
    IVectorView<AudioEncodingProperties> SupportedEncodingProperties { get; }

    /// <summary>Called to set the encoding properties of a custom audio effect.</summary>
    /// <param name="encodingProperties">The encoding properties.</param>
    void SetEncodingProperties(AudioEncodingProperties encodingProperties);

    /// <summary>Called when samples are available for processing by a custom audio effect.</summary>
    /// <param name="context">The context object that provides the input and output frames for the process operation.</param>
    void ProcessFrame(ProcessAudioFrameContext context);

    /// <summary>Called when the audio effect should close and clean up allocated resources.</summary>
    /// <param name="reason">The reason the effect was closed.</param>
    void Close(MediaEffectClosedReason reason);

    /// <summary>Called to allow audio effect implementations optionally discard any stored state related to samples that have already been received.</summary>
    void DiscardQueuedFrames();
  }
}
