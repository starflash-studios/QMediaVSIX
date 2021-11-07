// Decompiled with JetBrains decompiler
// Type: Windows.Media.Audio.AudioNodeEmitterConeProperties
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Audio
{
  /// <summary>Describes the cone shape used by an AudioNodeEmitterShape. At the inner angle of the cone, audio is not attenuated at all. At the outer angle of the cone, audio is fully attenuated.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [DualApiPartition(version = 167772160)]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [Threading(ThreadingModel.Both)]
  public sealed class AudioNodeEmitterConeProperties : IAudioNodeEmitterConeProperties
  {
    /// <summary>Gets the inner angle of an audio node emitter cone shape. This is the angle at which the audio is not attenuated at all.</summary>
    /// <returns>The inner angle of a an audio node emitter cone shape.</returns>
    public extern double InnerAngle { [MethodImpl] get; }

    /// <summary>Gets the outer angle of a an audio node emitter cone shape, expressed in radians. This is the angle at which the audio is fully attenuated.</summary>
    /// <returns>The outer angle of a an audio node emitter cone shape</returns>
    public extern double OuterAngle { [MethodImpl] get; }

    /// <summary>Gets a value indicating the gain applied at the outer angle of the cone.</summary>
    /// <returns>A value indicating the gain applied at the outer angle of the cone.</returns>
    public extern double OuterAngleGain { [MethodImpl] get; }
  }
}
