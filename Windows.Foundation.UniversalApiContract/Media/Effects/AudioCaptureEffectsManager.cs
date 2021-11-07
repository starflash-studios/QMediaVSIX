// Decompiled with JetBrains decompiler
// Type: Windows.Media.Effects.AudioCaptureEffectsManager
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Media.Effects
{
  /// <summary>Represent an audio capture effects manager which can be used to discover the audio processing chain on a device for a specific media category and audio processing mode.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [DualApiPartition(version = 1)]
  [Threading(ThreadingModel.MTA)]
  public sealed class AudioCaptureEffectsManager : IAudioCaptureEffectsManager
  {
    /// <summary>Occurs when audio process chain changes.</summary>
    public extern event TypedEventHandler<AudioCaptureEffectsManager, object> AudioCaptureEffectsChanged;

    /// <summary>Gets the list of audio effects on the device.</summary>
    /// <returns>The list of audio effects.</returns>
    [MethodImpl]
    public extern IVectorView<AudioEffect> GetAudioCaptureEffects();
  }
}
