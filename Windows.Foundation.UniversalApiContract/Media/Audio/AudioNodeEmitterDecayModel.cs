// Decompiled with JetBrains decompiler
// Type: Windows.Media.Audio.AudioNodeEmitterDecayModel
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Audio
{
  /// <summary>Represents the model used to compute the distance-based attenuation of a signal from an AudioNodeEmitter.</summary>
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [Static(typeof (IAudioNodeEmitterDecayModelStatics), 196608, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [DualApiPartition(version = 167772160)]
  [Threading(ThreadingModel.Both)]
  public sealed class AudioNodeEmitterDecayModel : IAudioNodeEmitterDecayModel
  {
    /// <summary>Gets a value indicating the type of the decay model.</summary>
    /// <returns>A value indicating the type of the decay model.</returns>
    public extern AudioNodeEmitterDecayKind Kind { [MethodImpl] get; }

    /// <summary>Gets the minimum gain applied to the signal as a result of the decay model.</summary>
    /// <returns>The minimum gain applied to the signal as a result of the decay model.</returns>
    public extern double MinGain { [MethodImpl] get; }

    /// <summary>Gets the maximum gain applied to the signal as a result of the decay model.</summary>
    /// <returns>The maximum gain applied to the signal as a result of the decay model.</returns>
    public extern double MaxGain { [MethodImpl] get; }

    /// <summary>Gets the properties of a natural AudioNodeEmitterDecayModel.</summary>
    /// <returns>The properties of a natural decay model.</returns>
    public extern AudioNodeEmitterNaturalDecayModelProperties NaturalProperties { [MethodImpl] get; }

    /// <summary>Creates an AudioNodeEmitterDecayModel with a natural roll-off model using a distance-squared formula.</summary>
    /// <param name="minGain">The minimum gain applied to the signal.</param>
    /// <param name="maxGain">The maximum gain applied to the signal.</param>
    /// <param name="unityGainDistance">The distance at which the gain of the signal is unaffected by decay.</param>
    /// <param name="cutoffDistance">The distance at which the gain is *minGain*.</param>
    /// <returns>The created decay model.</returns>
    [MethodImpl]
    public static extern AudioNodeEmitterDecayModel CreateNatural(
      double minGain,
      double maxGain,
      double unityGainDistance,
      double cutoffDistance);

    /// <summary>Creates a new AudioNodeEmitterDecayModel that uses the specified minimum and maximum gain values to compute distance-based attenuation of a signal from an AudioNodeEmitter.</summary>
    /// <param name="minGain">The minimum gain level for the signal.</param>
    /// <param name="maxGain">The maximum gain level for the signal.</param>
    /// <returns>The created decay model.</returns>
    [MethodImpl]
    public static extern AudioNodeEmitterDecayModel CreateCustom(
      double minGain,
      double maxGain);
  }
}
