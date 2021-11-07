// Decompiled with JetBrains decompiler
// Type: Windows.Media.Audio.AudioNodeListener
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Foundation.Numerics;

namespace Windows.Media.Audio
{
  /// <summary>Describes the position and other physical characteristics of a listener from which the audio output of an AudioGraph node is heard when spatial audio processing is used.</summary>
  [Activatable(196608, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  [DualApiPartition(version = 167772160)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  public sealed class AudioNodeListener : IAudioNodeListener
  {
    /// <summary>Creates a new instance of the AudioNodeListener class.</summary>
    [MethodImpl]
    public extern AudioNodeListener();

    /// <summary>Gets or sets a vector representing the position of the emitter in 3D space, expressed in meters.</summary>
    /// <returns>A vector representing the position of the emitter in 3D space.</returns>
    public extern Vector3 Position { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a Quaternion expressing the rotation of the listener in 3D space.</summary>
    /// <returns>The rotation of the listener in 3D space.</returns>
    public extern Quaternion Orientation { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the speed of sound used for computing spatial audio, expressed in meters per second.</summary>
    /// <returns>The speed of sound used for computing spatial audio.</returns>
    public extern double SpeedOfSound { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a Vector3 expressing the velocity at which the listener is moving in 3D space, expressed in meters per second.</summary>
    /// <returns>The velocity at which the listener is moving.</returns>
    public extern Vector3 DopplerVelocity { [MethodImpl] get; [MethodImpl] set; }
  }
}
