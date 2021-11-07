// Decompiled with JetBrains decompiler
// Type: Windows.Media.Core.AudioTrackSupportInfo
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Core
{
  /// <summary>Provides support information for an AudioTrack. This information includes the status of the audio decoder, information about any audio degradation applied by the decoder, and the status of the MediaSource with which the audio track is associated.</summary>
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [DualApiPartition(version = 167772160)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  public sealed class AudioTrackSupportInfo : IAudioTrackSupportInfo
  {
    /// <summary>Gets the status of the audio decoder that is decoding the AudioTrack, including whether the encoding for the audio track is fully or partially supported and whether the decoder will degrade the audio.</summary>
    /// <returns>The status of the audio decoder that is decoding the AudioTrack.</returns>
    public extern MediaDecoderStatus DecoderStatus { [MethodImpl] get; }

    /// <summary>Gets a value indicating the type of degradation, if any, that is applied to the AudioTrack by the audio decoder.</summary>
    /// <returns>The type of degradation, if any, that is applied to the AudioTrack by the audio decoder.</returns>
    public extern AudioDecoderDegradation Degradation { [MethodImpl] get; }

    /// <summary>Gets a value indicating the reason that the audio decoder is degrading the AudioTrack, if the audio is degraded.</summary>
    /// <returns>The reason that the audio decoder is degrading the **AudioTrack**.</returns>
    public extern AudioDecoderDegradationReason DegradationReason { [MethodImpl] get; }

    /// <summary>Gets the status of the MediaSource with which the AudioTrack is associated.</summary>
    /// <returns>The status of the MediaSource with which the AudioTrack is associated.</returns>
    public extern MediaSourceStatus MediaSourceStatus { [MethodImpl] get; }
  }
}
