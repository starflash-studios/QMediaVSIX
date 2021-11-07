// Decompiled with JetBrains decompiler
// Type: Windows.Media.Effects.AudioRenderEffectsManager
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Media.Effects
{
  /// <summary>Represent an audio render effects manager which can be used to discover the audio processing chain on a device for a specific media category and audio processing mode.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Threading(ThreadingModel.MTA)]
  public sealed class AudioRenderEffectsManager : 
    IAudioRenderEffectsManager,
    IAudioRenderEffectsManager2
  {
    /// <summary>Occurs when audio process chain changes.</summary>
    public extern event TypedEventHandler<AudioRenderEffectsManager, object> AudioRenderEffectsChanged;

    /// <summary>Gets the list of audio effects on the device.</summary>
    /// <returns>The list of audio effects.</returns>
    [MethodImpl]
    public extern IVectorView<AudioEffect> GetAudioRenderEffects();

    /// <summary>Gets the thumbnail image that is associated with this audio effects provider.</summary>
    /// <returns>The thumbnail image for the audio effects provider.</returns>
    public extern IRandomAccessStreamWithContentType EffectsProviderThumbnail { [Deprecated("Not supported starting in windows 10", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract"), MethodImpl] get; }

    /// <summary>Gets the label that is associated with this audio effects provider setting.</summary>
    /// <returns>The string to use as the label for the audio effects provider setting.</returns>
    public extern string EffectsProviderSettingsLabel { [Deprecated("Not supported starting in windows 10", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract"), MethodImpl] get; }

    /// <summary>Displays the audio effect settings page.</summary>
    /// <deprecated type="deprecate">Not supported starting in windows 10</deprecated>
    [Deprecated("Not supported starting in windows 10", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract")]
    [MethodImpl]
    public extern void ShowSettingsUI();
  }
}
