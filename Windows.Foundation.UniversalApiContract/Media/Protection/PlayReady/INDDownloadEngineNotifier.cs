// Decompiled with JetBrains decompiler
// Type: Windows.Media.Protection.PlayReady.INDDownloadEngineNotifier
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Protection.PlayReady
{
  /// <summary>Contains methods that a download engine plug-in uses to send notifications to a PlayReady-ND client.</summary>
  /// <deprecated type="deprecate">INDDownloadEngineNotifier is deprecated and might not work on all platforms. For more info, see MSDN.</deprecated>
  [Guid(3609244884, 62648, 17712, 168, 9, 145, 147, 165, 113, 231, 252)]
  [Deprecated("INDDownloadEngineNotifier is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 196608, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public interface INDDownloadEngineNotifier
  {
    /// <summary>Called by the download engine when a stream is opened.</summary>
    /// <deprecated type="deprecate">INDDownloadEngineNotifier is deprecated and might not work on all platforms. For more info, see MSDN.</deprecated>
    [Deprecated("INDDownloadEngineNotifier is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 196608, "Windows.Foundation.UniversalApiContract")]
    void OnStreamOpened();

    /// <summary>Called by the download engine once a PlayReady object is received.</summary>
    /// <deprecated type="deprecate">INDDownloadEngineNotifier is deprecated and might not work on all platforms. For more info, see MSDN.</deprecated>
    /// <param name="dataBytes">The byte array that holds the PlayReady object.</param>
    [Deprecated("INDDownloadEngineNotifier is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 196608, "Windows.Foundation.UniversalApiContract")]
    void OnPlayReadyObjectReceived(byte[] dataBytes);

    /// <summary>Called by the download engine when a content identifier is received.</summary>
    /// <deprecated type="deprecate">INDDownloadEngineNotifier is deprecated and might not work on all platforms. For more info, see MSDN.</deprecated>
    /// <param name="licenseFetchDescriptor">The license from which the download engine receives the content identifier.</param>
    [Deprecated("INDDownloadEngineNotifier is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 196608, "Windows.Foundation.UniversalApiContract")]
    void OnContentIDReceived(INDLicenseFetchDescriptor licenseFetchDescriptor);

    /// <summary>Called by the download engine when it receives data.</summary>
    /// <deprecated type="deprecate">INDDownloadEngineNotifier is deprecated and might not work on all platforms. For more info, see MSDN.</deprecated>
    /// <param name="dataBytes">The byte array that holds the data.</param>
    /// <param name="bytesReceived">The number of bytes received from the data stream.</param>
    [Deprecated("INDDownloadEngineNotifier is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 196608, "Windows.Foundation.UniversalApiContract")]
    void OnDataReceived(byte[] dataBytes, uint bytesReceived);

    /// <summary>Called by the download engine when it reaches the end of a PlayReady-ND media stream.</summary>
    /// <deprecated type="deprecate">INDDownloadEngineNotifier is deprecated and might not work on all platforms. For more info, see MSDN.</deprecated>
    [Deprecated("INDDownloadEngineNotifier is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 196608, "Windows.Foundation.UniversalApiContract")]
    void OnEndOfStream();

    /// <summary>Called by the download engine if an error occurs during downloading.</summary>
    /// <deprecated type="deprecate">INDDownloadEngineNotifier is deprecated and might not work on all platforms. For more info, see MSDN.</deprecated>
    [Deprecated("INDDownloadEngineNotifier is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 196608, "Windows.Foundation.UniversalApiContract")]
    void OnNetworkError();
  }
}
