// Decompiled with JetBrains decompiler
// Type: Windows.Media.Effects.IAudioEffectsManagerStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Media.Capture;
using Windows.Media.Render;

namespace Windows.Media.Effects
{
  [ExclusiveTo(typeof (AudioEffectsManager))]
  [Guid(1715497988, 34554, 18380, 163, 21, 244, 137, 216, 195, 254, 16)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IAudioEffectsManagerStatics
  {
    [Overload("CreateAudioRenderEffectsManager")]
    AudioRenderEffectsManager CreateAudioRenderEffectsManager(
      string deviceId,
      AudioRenderCategory category);

    [Overload("CreateAudioRenderEffectsManagerWithMode")]
    AudioRenderEffectsManager CreateAudioRenderEffectsManager(
      string deviceId,
      AudioRenderCategory category,
      AudioProcessing mode);

    [Overload("CreateAudioCaptureEffectsManager")]
    AudioCaptureEffectsManager CreateAudioCaptureEffectsManager(
      string deviceId,
      MediaCategory category);

    [Overload("CreateAudioCaptureEffectsManagerWithMode")]
    AudioCaptureEffectsManager CreateAudioCaptureEffectsManager(
      string deviceId,
      MediaCategory category,
      AudioProcessing mode);
  }
}
