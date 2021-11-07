// Decompiled with JetBrains decompiler
// Type: Windows.Media.Core.AudioDecoderDegradationReason
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Core
{
  /// <summary>Specifies the reason that the audio decoder degraded an AudioTrack.</summary>
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  public enum AudioDecoderDegradationReason
  {
    /// <summary>No reason is specified or no audio degradation has been applied to the track.</summary>
    None,
    /// <summary>The audio track was degraded due to a licensing requirement.</summary>
    LicensingRequirement,
    /// <summary>The audio track was degraded because the device does not support spatial audio.</summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 262144)] SpatialAudioNotSupported,
  }
}
