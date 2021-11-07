// Decompiled with JetBrains decompiler
// Type: Windows.Media.Effects.IAudioEffectDefinition
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Media.Effects
{
  /// <summary>Exposes the methods and properties of an AudioEffectDefinition object. Implement this interface when you create a custom audio effect definition.</summary>
  [Guid(3839359348, 32128, 20339, 144, 137, 227, 28, 157, 185, 194, 148)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public interface IAudioEffectDefinition
  {
    /// <summary>The activatable class ID of the audio effect definition.</summary>
    /// <returns>The activatable class ID of the audio effect definition, such as "AudioClipEffect".</returns>
    string ActivatableClassId { get; }

    /// <summary>The set of properties for configuring an AudioEffectDefinition object.</summary>
    /// <returns>The set of properties for the audio effect definition, represented as tuples.</returns>
    IPropertySet Properties { get; }
  }
}
