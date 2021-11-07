// Decompiled with JetBrains decompiler
// Type: Windows.Media.Audio.AudioNodeEmitter
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Foundation.Numerics;

namespace Windows.Media.Audio
{
  /// <summary>Describes the position and other physical characteristics of an emitter from which the audio of an AudioGraph node is emitted when spatial audio processing is used.</summary>
  [DualApiPartition(version = 167772160)]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Activatable(typeof (IAudioNodeEmitterFactory), 196608, "Windows.Foundation.UniversalApiContract")]
  [Activatable(196608, "Windows.Foundation.UniversalApiContract")]
  public sealed class AudioNodeEmitter : IAudioNodeEmitter, IAudioNodeEmitter2
  {
    /// <summary>Initializes a new instance of the AudioNodeEmitter class with the specified emitter characteristics.</summary>
    /// <param name="shape">An object describing the shape in which audio is emitted.</param>
    /// <param name="decayModel">An object describing the decay model for emitted audio.</param>
    /// <param name="settings">Flags specifying additional settings for the emitter.</param>
    [MethodImpl]
    public extern AudioNodeEmitter(
      AudioNodeEmitterShape shape,
      AudioNodeEmitterDecayModel decayModel,
      AudioNodeEmitterSettings settings);

    /// <summary>Initializes a new instance of the AudioNodeEmitter class.</summary>
    [MethodImpl]
    public extern AudioNodeEmitter();

    /// <summary>Gets or sets a vector representing the position of the emitter in 3D space, expressed in meters.</summary>
    /// <returns>A vector representing the position of the emitter in 3D space</returns>
    public extern Vector3 Position { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>A vector expressing the direction in which audio is emitted from the AudioNodeEmitter.</summary>
    /// <returns>The direction in which audio is emitted from the emitter.</returns>
    public extern Vector3 Direction { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets an object describing the shape in which the emitter emits audio.</summary>
    /// <returns>An object describing the shape in which the emitter emits audio.</returns>
    public extern AudioNodeEmitterShape Shape { [MethodImpl] get; }

    /// <summary>Gets an object describing the decay model for the AudioNodeEmitter.</summary>
    /// <returns>An object describing the decay model for the emitter.</returns>
    public extern AudioNodeEmitterDecayModel DecayModel { [MethodImpl] get; }

    /// <summary>Gets or sets a value indicating the gain applied to the signal by the emitter.</summary>
    /// <returns>A value indicating the gain applied to the signal by the emitter.</returns>
    public extern double Gain { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the scale of the position of the emitter. All distances used when calculating spatial audio effects are expressed in meters. Setting this value allows you to automatically scale the calculations to use some other unit.</summary>
    /// <returns>The scale of the position of the emitter.</returns>
    public extern double DistanceScale { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the scale of the doppler velocity of the emitter. The DopplerVelocity of an emitter is expressed in meters per second. Setting this value allows you to automatically scale the velocity to some other unit.</summary>
    /// <returns>The scale of the doppler velocity of the emitter.</returns>
    public extern double DopplerScale { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a Vector3 expressing the velocity at which the emitter is moving in 3D space, expressed in meters per second.</summary>
    /// <returns>A Vector3 expressing the velocity at which the emitter is moving.</returns>
    public extern Vector3 DopplerVelocity { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets a value indicating whether Doppler processing is disabled for the emitter.</summary>
    /// <returns>True if Doppler processing is disabled; otherwise, false.</returns>
    public extern bool IsDopplerDisabled { [MethodImpl] get; }

    /// <summary>Gets or sets a value that specifies the spatial audio processing model used by the emitter.</summary>
    /// <returns>A value that specifies the spatial audio processing model used by the emitter.</returns>
    public extern SpatialAudioModel SpatialAudioModel { [MethodImpl] get; [MethodImpl] set; }
  }
}
