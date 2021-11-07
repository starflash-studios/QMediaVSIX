// Decompiled with JetBrains decompiler
// Type: Windows.Media.Protection.PlayReady.INDStreamParserNotifier
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Media.Core;

namespace Windows.Media.Protection.PlayReady
{
  /// <summary>Contains methods that a stream parser plug-in uses to send notifications to a PlayReady-ND client.</summary>
  /// <deprecated type="deprecate">INDStreamParserNotifier is deprecated and might not work on all platforms. For more info, see MSDN.</deprecated>
  [Guid(3244797136, 11494, 17004, 172, 229, 94, 146, 117, 254, 167, 21)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Deprecated("INDStreamParserNotifier is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 196608, "Windows.Foundation.UniversalApiContract")]
  public interface INDStreamParserNotifier
  {
    /// <summary>Called by a stream parser when it receives the content identifier.</summary>
    /// <deprecated type="deprecate">INDStreamParserNotifier is deprecated and might not work on all platforms. For more info, see MSDN.</deprecated>
    /// <param name="licenseFetchDescriptor">The license fetch descriptor containing the content identifier.</param>
    [Deprecated("INDStreamParserNotifier is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 196608, "Windows.Foundation.UniversalApiContract")]
    void OnContentIDReceived(INDLicenseFetchDescriptor licenseFetchDescriptor);

    [Deprecated("INDStreamParserNotifier is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 196608, "Windows.Foundation.UniversalApiContract")]
    void OnMediaStreamDescriptorCreated(
      IVector<AudioStreamDescriptor> audioStreamDescriptors,
      IVector<VideoStreamDescriptor> videoStreamDescriptors);

    /// <summary>Called when the stream parser parses a sample from the media stream.</summary>
    /// <deprecated type="deprecate">INDStreamParserNotifier is deprecated and might not work on all platforms. For more info, see MSDN.</deprecated>
    /// <param name="streamID">The identifier for the media stream that is being parsed.</param>
    /// <param name="streamType">The type of the media stream. This value can be either **Audio** or **Video**.</param>
    /// <param name="streamSample">The array of stream samples.</param>
    /// <param name="pts">The presentation timestamp that indicates when to play the sample.</param>
    /// <param name="ccFormat">The closed caption format. This value can be **ATSC**, **SCTE20**, or **Unknown**.</param>
    /// <param name="ccDataBytes">An array that contains the closed caption data.</param>
    [Deprecated("INDStreamParserNotifier is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 196608, "Windows.Foundation.UniversalApiContract")]
    void OnSampleParsed(
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
    /// <param name="proBytes">The byte array of a PlayReadyObject for creating the decryptor. For MPEG2 TS, the PlayReadyObject is in the entitlement control messages (ECM) packet.</param>
    [Deprecated("INDStreamParserNotifier is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 196608, "Windows.Foundation.UniversalApiContract")]
    void OnBeginSetupDecryptor(IMediaStreamDescriptor descriptor, Guid keyID, byte[] proBytes);
  }
}
