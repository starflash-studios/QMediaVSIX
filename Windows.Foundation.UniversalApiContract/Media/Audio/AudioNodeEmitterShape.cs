// Decompiled with JetBrains decompiler
// Type: Windows.Media.Audio.AudioNodeEmitterShape
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Audio
{
  /// <summary>Describes the shape in which an AudioNodeEmitter emits audio.</summary>
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [DualApiPartition(version = 167772160)]
  [Static(typeof (IAudioNodeEmitterShapeStatics), 196608, "Windows.Foundation.UniversalApiContract")]
  public sealed class AudioNodeEmitterShape : IAudioNodeEmitterShape
  {
    /// <summary>Gets a value indicating the kind of shape represented by the AudioNodeEmitterShape.</summary>
    /// <returns>A value indicating the kind of shape represented by the AudioNodeEmitterShape.</returns>
    public extern AudioNodeEmitterShapeKind Kind { [MethodImpl] get; }

    /// <summary>Gets an object that defines the characteristics of an emitter's cone shape, including the inner and outer angle of the cone and the gain applied to the signal at the outer angle.</summary>
    /// <returns>An object that defines the characteristics of the cone shape</returns>
    public extern AudioNodeEmitterConeProperties ConeProperties { [MethodImpl] get; }

    /// <summary>Creates an instance of AudioNodeEmitterShape representing a cone shape.</summary>
    /// <param name="innerAngle">The inner angle of an audio node emitter cone shape, where the audio signal is not attenuated at all, expressed in radians.</param>
    /// <param name="outerAngle">The outer angle of an audio node emitter cone shape, where the audio signal is fully attenuated, expressed in radians.</param>
    /// <param name="outerAngleGain">A value indicating the gain applied at the outer angle of the cone.</param>
    /// <returns>A cone-shaped AudioNodeEmitterShape.</returns>
    [MethodImpl]
    public static extern AudioNodeEmitterShape CreateCone(
      double innerAngle,
      double outerAngle,
      double outerAngleGain);

    /// <summary>Creates an instance of AudioNodeEmitterShape that is omnidirectional, meaning that the audio signal attenuation is the same regardless of the emitter's Direction.</summary>
    /// <returns>An omnidirectional AudioNodeEmitterShape.</returns>
    [MethodImpl]
    public static extern AudioNodeEmitterShape CreateOmnidirectional();
  }
}
