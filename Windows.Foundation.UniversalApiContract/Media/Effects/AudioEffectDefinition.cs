// Decompiled with JetBrains decompiler
// Type: Windows.Media.Effects.AudioEffectDefinition
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Media.Effects
{
  /// <summary>Represents an audio effect definition.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Activatable(typeof (IAudioEffectDefinitionFactory), 65536, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  public sealed class AudioEffectDefinition : IAudioEffectDefinition
  {
    /// <summary>Creates a new AudioEffectDefinition object with the specified activatable class ID.</summary>
    /// <param name="activatableClassId">The activatable class ID of the audio effect definition.</param>
    [MethodImpl]
    public extern AudioEffectDefinition(string activatableClassId);

    /// <summary>Creates a new AudioEffectDefinition object with the specified activatable class ID, configuring the object with the specified settings.</summary>
    /// <param name="activatableClassId">The activatable class ID of the audio effect definition.</param>
    /// <param name="props">Configuration properties for the specified audio effect definition.</param>
    [MethodImpl]
    public extern AudioEffectDefinition(string activatableClassId, IPropertySet props);

    /// <summary>The activatable class ID of the audio effect definition.</summary>
    /// <returns>The activatable class ID of the audio effect definition, such as "AudioClipEffect".</returns>
    public extern string ActivatableClassId { [MethodImpl] get; }

    /// <summary>The set of properties for configuring an AudioEffectDefinition object.</summary>
    /// <returns>The set of properties for the audio effect definition, represented as tuples.</returns>
    public extern IPropertySet Properties { [MethodImpl] get; }
  }
}
