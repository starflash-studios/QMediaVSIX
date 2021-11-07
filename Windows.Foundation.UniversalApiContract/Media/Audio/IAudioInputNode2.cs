// Decompiled with JetBrains decompiler
// Type: Windows.Media.Audio.IAudioInputNode2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Audio
{
  /// <summary>The interface implemented by audio input nodes that support spatial audio.</summary>
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [Guid(2421249719, 51816, 19565, 168, 188, 227, 238, 23, 254, 63, 210)]
  public interface IAudioInputNode2 : IAudioNode, IClosable, IAudioInputNode
  {
    /// <summary>Gets the AudioNodeEmitter that describes the position and other physical characteristics of the emitter from which the audio input node audio is emitted when spatial audio processing is used.</summary>
    /// <returns>The emitter for the audio input node.</returns>
    AudioNodeEmitter Emitter { get; }
  }
}
