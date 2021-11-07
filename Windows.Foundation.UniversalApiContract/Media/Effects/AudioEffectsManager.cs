// Decompiled with JetBrains decompiler
// Type: Windows.Media.Effects.AudioEffectsManager
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Media.Capture;
using Windows.Media.Render;

namespace Windows.Media.Effects
{
  /// <summary>Provides functionality for creating audio capture and render effects manager objects.</summary>
  [Static(typeof (IAudioEffectsManagerStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.MTA)]
  public static class AudioEffectsManager
  {
    /// <summary>Creates a AudioRenderEffectsManager object for the specified device for a specific media category and audio processing mode.</summary>
    /// <param name="deviceId">The device id.</param>
    /// <param name="category">The audio render category.</param>
    /// <returns>The new audio render effects manager.</returns>
    [Overload("CreateAudioRenderEffectsManager")]
    [MethodImpl]
    public static extern AudioRenderEffectsManager CreateAudioRenderEffectsManager(
      string deviceId,
      AudioRenderCategory category);

    /// <summary>Creates a AudioRenderEffectsManager object for the specified device for a specific media category.</summary>
    /// <param name="deviceId">The device id.</param>
    /// <param name="category">The audio render category.</param>
    /// <param name="mode">The audio precessing mode.</param>
    /// <returns>The new audio render effects manager.</returns>
    [Overload("CreateAudioRenderEffectsManagerWithMode")]
    [MethodImpl]
    public static extern AudioRenderEffectsManager CreateAudioRenderEffectsManager(
      string deviceId,
      AudioRenderCategory category,
      AudioProcessing mode);

    /// <summary>Creates a AudioCaptureEffectsManager object for the specified device for a specific media category.</summary>
    /// <param name="deviceId">The device id.</param>
    /// <param name="category">The media category.</param>
    /// <returns>The new audio capture effects manager.</returns>
    [Overload("CreateAudioCaptureEffectsManager")]
    [MethodImpl]
    public static extern AudioCaptureEffectsManager CreateAudioCaptureEffectsManager(
      string deviceId,
      MediaCategory category);

    /// <summary>Creates a AudioCaptureEffectsManager object for the specified device for a specific media category and audio processing mode.</summary>
    /// <param name="deviceId">The device id.</param>
    /// <param name="category">The media category.</param>
    /// <param name="mode">The audio processing mode.</param>
    /// <returns>The new audio capture effects manager.</returns>
    [Overload("CreateAudioCaptureEffectsManagerWithMode")]
    [MethodImpl]
    public static extern AudioCaptureEffectsManager CreateAudioCaptureEffectsManager(
      string deviceId,
      MediaCategory category,
      AudioProcessing mode);
  }
}
