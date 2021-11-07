// Decompiled with JetBrains decompiler
// Type: Windows.Media.Protection.PlayReady.NDStreamParserNotifier
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System;
using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Media.Core;

namespace Windows.Media.Protection.PlayReady
{
  /// <summary>Contains methods that a stream parser plug-in uses to send notifications to a PlayReady-ND client.</summary>
  /// <deprecated type="deprecate">NDStreamParserNotifier is deprecated and might not work on all platforms. For more info, see MSDN.</deprecated>
  [Deprecated("NDStreamParserNotifier is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 196608, "Windows.Foundation.UniversalApiContract")]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class NDStreamParserNotifier : INDStreamParserNotifier
  {
    /// <summary>Creates a new instance of the NDStreamParserNotifier class.</summary>
    [MethodImpl]
    public extern NDStreamParserNotifier();

    /// <summary>Called by a stream parser when it receives the content identifier.</summary>
    /// <deprecated type="deprecate">INDStreamParserNotifier is deprecated and might not work on all platforms. For more info, see MSDN.</deprecated>
    /// <param name="licenseFetchDescriptor">The license fetch descriptor containing the content identifier.</param>
    [Deprecated("INDStreamParserNotifier is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 196608, "Windows.Foundation.UniversalApiContract")]
    [MethodImpl]
    public extern void OnContentIDReceived(INDLicenseFetchDescriptor licenseFetchDescriptor);

    [Deprecated("INDStreamParserNotifier is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 196608, "Windows.Foundation.UniversalApiContract")]
    [MethodImpl]
    public extern void OnMediaStreamDescriptorCreated(
      IVector<AudioStreamDescriptor> audioStreamDescriptors,
      IVector<VideoStreamDescriptor> videoStreamDescriptors);

    /// <summary>Called when the stream parser parses a sample from the media stream.</summary>
    /// <deprecated type="deprecate">INDStreamParserNotifier is deprecated and might not work on all platforms. For more info, see MSDN.</deprecated>
    /// <param name="streamID">The identifier for the media stream that is being parsed.</param>
    /// <param name="streamType">The type of the media stream. This value can be **Audio** or **Video**.</param>
    /// <param name="streamSample">The array of stream samples.</param>
    /// <param name="pts">The presentation timestamp that indicates when to play the sample, in milliseconds. This value is relative to previous samples in the presentation. For example, if a given sample has a presentation time stamp of 1000 and some later sample has a presentation time stamp of 2000, the later sample occurs one second (1000ms) after the given sample.</param>
    /// <param name="ccFormat">The closed caption format. This value can be **ATSC**, **SCTE20**, or **Unknown**.</param>
    /// <param name="ccDataBytes">An array that contains the closed caption data.</param>
    [Deprecated("INDStreamParserNotifier is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 196608, "Windows.Foundation.UniversalApiContract")]
    [MethodImpl]
    public extern void OnSampleParsed(
      uint streamID,
      NDMediaStreamType streamType,
      MediaStreamSample streamSample,
      long pts,
      NDClosedCaptionFormat ccFormat,
      byte[] ccDataBytes);

    /// <summary>Called by the stream parser when it requests a setup decryptor.</summary>
    /// <deprecated type="deprecate">INDStreamParserNotifier is deprecated and might not work on all platforms. For more info, see MSDN.</deprecated>
    /// <param name="descriptor">The descriptor of the media stream being decrypted.</param>
    /// <param name="keyID">The key identifier used for decryption.</param>
    /// <param name="proBytes">The data for the setup decryptor.</param>
    [Deprecated("INDStreamParserNotifier is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 196608, "Windows.Foundation.UniversalApiContract")]
    [MethodImpl]
    public extern void OnBeginSetupDecryptor(
      IMediaStreamDescriptor descriptor,
      Guid keyID,
      byte[] proBytes);
  }
}
