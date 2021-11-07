// Decompiled with JetBrains decompiler
// Type: Windows.Media.Audio.IAudioNode
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Media.Effects;
using Windows.Media.MediaProperties;

namespace Windows.Media.Audio
{
  /// <summary>Defines an audio node.</summary>
  [Guid(356031871, 56280, 18457, 191, 3, 102, 142, 147, 87, 205, 109)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public interface IAudioNode : IClosable
  {
    /// <summary>Gets the list of effect definitions for the audio node.</summary>
    /// <returns>The list of effect definitions for the node.</returns>
    IVector<IAudioEffectDefinition> EffectDefinitions { get; }

    /// <summary>Gets or sets the outgoing gain for the audio node.</summary>
    /// <returns>The outgoing gain value.</returns>
    double OutgoingGain { set; get; }

    /// <summary>Gets the encoding properties for the audio node.</summary>
    /// <returns>The encoding properties for the node.</returns>
    AudioEncodingProperties EncodingProperties { get; }

    /// <summary>Gets or sets a value indicating if the audio node consumes input.</summary>
    /// <returns>True if the audio node consumes input, and false otherwise.</returns>
    bool ConsumeInput { get; set; }

    /// <summary>Starts the audio node.</summary>
    void Start();

    /// <summary>Stops the audio node.</summary>
    void Stop();

    /// <summary>Resets the audio node.</summary>
    void Reset();

    /// <summary>Disables all effects in the EffectDefinitions list with the specified effect definition.</summary>
    /// <param name="definition">The effect definition of the effects to disable.</param>
    void DisableEffectsByDefinition(IAudioEffectDefinition definition);

    /// <summary>Enables all effects in the EffectDefinitions list with the specified effect definition.</summary>
    /// <param name="definition">The effect definition of the effects to enable.</param>
    void EnableEffectsByDefinition(IAudioEffectDefinition definition);
  }
}
