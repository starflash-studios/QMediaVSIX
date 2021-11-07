// Decompiled with JetBrains decompiler
// Type: Windows.Media.Audio.SpatialAudioModel
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Audio
{
  /// <summary>Specifies the spatial audio processing model used by an AudioNodeEmitter.</summary>
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  public enum SpatialAudioModel
  {
    /// <summary>Spatial audio is processed using the Microsoft head-relative transfer function (HRTF) algorithm. This provides a more realistic spatial sound that preserves X, Y, and Z coordinates of the emitter, but at a higher CPU and memory cost than fold-down processing.</summary>
    ObjectBased,
    /// <summary>Spatial audio is processed using non-spatial methods, such as panning between stereo channels. This provides less realistic spatial sound that preserves the X and Z coordinates of the emitter, but effectively ignores the Y coordinate. This model has a lower CPU and memory cost than object-based processing.</summary>
    FoldDown,
  }
}
