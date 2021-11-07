// Decompiled with JetBrains decompiler
// Type: Windows.Media.Effects.AudioEffectType
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Effects
{
  /// <summary>Defines values for audio effect types.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum AudioEffectType
  {
    /// <summary>Other.</summary>
    Other,
    /// <summary>An acoustic echo cancellation effect.</summary>
    AcousticEchoCancellation,
    /// <summary>A noise suppression effect.</summary>
    NoiseSuppression,
    /// <summary>A automatic gain control effect.</summary>
    AutomaticGainControl,
    /// <summary>A beam forming effect.</summary>
    BeamForming,
    /// <summary>A constant tone removal effect.</summary>
    ConstantToneRemoval,
    /// <summary>A equalizer effect.</summary>
    Equalizer,
    /// <summary>A loudness equalizer effect.</summary>
    LoudnessEqualizer,
    /// <summary>A bass boost effect.</summary>
    BassBoost,
    /// <summary>A virtual surround sound effect.</summary>
    VirtualSurround,
    /// <summary>A virtual headphones effect.</summary>
    VirtualHeadphones,
    /// <summary>A speaker fill effect.</summary>
    SpeakerFill,
    /// <summary>A room correction effect.</summary>
    RoomCorrection,
    /// <summary>A bass management effect.</summary>
    BassManagement,
    /// <summary>An environmental effect.</summary>
    EnvironmentalEffects,
    /// <summary>A speaker protection effect.</summary>
    SpeakerProtection,
    /// <summary>A speaker compensation effect.</summary>
    SpeakerCompensation,
    /// <summary>A dynamic range compression effect.</summary>
    DynamicRangeCompression,
    [ContractVersion("Windows.Foundation.UniversalApiContract", 786432)] FarFieldBeamForming,
    [ContractVersion("Windows.Foundation.UniversalApiContract", 851968)] DeepNoiseSuppression,
  }
}
