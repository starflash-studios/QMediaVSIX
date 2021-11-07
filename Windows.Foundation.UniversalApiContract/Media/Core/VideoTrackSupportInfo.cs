// Decompiled with JetBrains decompiler
// Type: Windows.Media.Core.VideoTrackSupportInfo
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Core
{
  /// <summary>Provides support information for a VideoTrack. This information includes the status of the video decoder and the status of the MediaSource with which the video track is associated.</summary>
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [DualApiPartition(version = 167772160)]
  public sealed class VideoTrackSupportInfo : IVideoTrackSupportInfo
  {
    /// <summary>Gets the status of the video decoder that is decoding the VideoTrack, including whether the encoding for the video track is fully or partially supported.</summary>
    /// <returns>The status of the video decoder that is decoding the VideoTrack.</returns>
    public extern MediaDecoderStatus DecoderStatus { [MethodImpl] get; }

    /// <summary>Gets the status of the MediaSource with which the VideoTrack is associated.</summary>
    /// <returns>The status of the MediaSource with which the VideoTrack is associated.</returns>
    public extern MediaSourceStatus MediaSourceStatus { [MethodImpl] get; }
  }
}
