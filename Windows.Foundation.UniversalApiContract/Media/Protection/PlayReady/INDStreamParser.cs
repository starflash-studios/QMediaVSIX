// Decompiled with JetBrains decompiler
// Type: Windows.Media.Protection.PlayReady.INDStreamParser
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Media.Core;

namespace Windows.Media.Protection.PlayReady
{
  /// <summary>Parses data from a PlayReady-ND media stream.</summary>
  /// <deprecated type="deprecate">INDStreamParser is deprecated and might not work on all platforms. For more info, see MSDN.</deprecated>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Deprecated("INDStreamParser is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 196608, "Windows.Foundation.UniversalApiContract")]
  [Guid(3770327448, 38806, 16841, 134, 149, 89, 67, 126, 103, 230, 106)]
  public interface INDStreamParser
  {
    /// <summary>Parses samples from a PlayReady-ND media stream.</summary>
    /// <deprecated type="deprecate">INDStreamParser is deprecated and might not work on all platforms. For more info, see MSDN.</deprecated>
    /// <param name="dataBytes">The data to be parsed.</param>
    [Deprecated("INDStreamParser is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 196608, "Windows.Foundation.UniversalApiContract")]
    void ParseData(byte[] dataBytes);

    /// <summary>Retrieves the stream type (audio or video) and stream identifier of the media stream descriptor.</summary>
    /// <deprecated type="deprecate">INDStreamParser is deprecated and might not work on all platforms. For more info, see MSDN.</deprecated>
    /// <param name="descriptor">The media stream from which this method gets information.</param>
    /// <param name="streamType">The type of the media stream. This type can be either **Audio** or **Video**.</param>
    /// <returns>The stream identifier for the media stream.</returns>
    [Deprecated("INDStreamParser is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 196608, "Windows.Foundation.UniversalApiContract")]
    uint GetStreamInformation(IMediaStreamDescriptor descriptor, out NDMediaStreamType streamType);

    /// <summary>Notifies a PlayReady-ND stream parser to be ready for the beginning of a new media stream.</summary>
    /// <deprecated type="deprecate">INDStreamParser is deprecated and might not work on all platforms. For more info, see MSDN.</deprecated>
    [Deprecated("INDStreamParser is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 196608, "Windows.Foundation.UniversalApiContract")]
    void BeginOfStream();

    /// <summary>Notifies a PlayReady-ND stream parser that the end of a media stream has been reached.</summary>
    /// <deprecated type="deprecate">INDStreamParser is deprecated and might not work on all platforms. For more info, see MSDN.</deprecated>
    [Deprecated("INDStreamParser is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 196608, "Windows.Foundation.UniversalApiContract")]
    void EndOfStream();

    /// <summary>Gets the stream parser notifier that will provide notification of stream parser events from the transmitter.</summary>
    /// <returns>An instance of an NDStreamParserNotifier object.</returns>
    NDStreamParserNotifier Notifier { [Deprecated("INDStreamParser is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 196608, "Windows.Foundation.UniversalApiContract")] get; }
  }
}
