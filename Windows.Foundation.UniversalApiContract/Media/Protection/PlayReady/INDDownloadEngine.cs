// Decompiled with JetBrains decompiler
// Type: Windows.Media.Protection.PlayReady.INDDownloadEngine
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Protection.PlayReady
{
  /// <summary>Provides the PlayReady-ND download engine used to stream protected media content from a transmitter.</summary>
  /// <deprecated type="deprecate">INDDownloadEngine is deprecated and might not work on all platforms. For more info, see MSDN.</deprecated>
  [Guid(757218661, 50358, 17464, 141, 70, 185, 110, 109, 15, 178, 31)]
  [Deprecated("INDDownloadEngine is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 196608, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public interface INDDownloadEngine
  {
    [Deprecated("INDDownloadEngine is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 196608, "Windows.Foundation.UniversalApiContract")]
    void Open(Uri uri, byte[] sessionIDBytes);

    /// <summary>Notifies the download engine to pause downloading.</summary>
    /// <deprecated type="deprecate">INDDownloadEngine is deprecated and might not work on all platforms. For more info, see MSDN.</deprecated>
    [Deprecated("INDDownloadEngine is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 196608, "Windows.Foundation.UniversalApiContract")]
    void Pause();

    /// <summary>Notifies the download engine to resume a paused download.</summary>
    /// <deprecated type="deprecate">INDDownloadEngine is deprecated and might not work on all platforms. For more info, see MSDN.</deprecated>
    [Deprecated("INDDownloadEngine is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 196608, "Windows.Foundation.UniversalApiContract")]
    void Resume();

    /// <summary>Notifies the download engine to stop downloading and disconnect from the remote server.</summary>
    /// <deprecated type="deprecate">INDDownloadEngine is deprecated and might not work on all platforms. For more info, see MSDN.</deprecated>
    [Deprecated("INDDownloadEngine is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 196608, "Windows.Foundation.UniversalApiContract")]
    void Close();

    [Deprecated("INDDownloadEngine is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 196608, "Windows.Foundation.UniversalApiContract")]
    void Seek(TimeSpan startPosition);

    /// <summary>Gets whether the download engine supports seeking.</summary>
    /// <returns>**true** if the download engine supports seeking or **false** if it does not.</returns>
    bool CanSeek { [Deprecated("INDDownloadEngine is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 196608, "Windows.Foundation.UniversalApiContract")] get; }

    /// <summary>Gets the minimum number of samples a sample buffer can hold before a download engine resumes downloading.</summary>
    /// <returns>The minimum number of samples that the download engine uses to determine whether to resume downloading.</returns>
    uint BufferFullMinThresholdInSamples { [Deprecated("INDDownloadEngine is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 196608, "Windows.Foundation.UniversalApiContract")] get; }

    /// <summary>Gets the maximum threshold of the sample buffer.</summary>
    /// <returns>The maximum number of samples that the download engine uses to determine whether the sample buffer is full.</returns>
    uint BufferFullMaxThresholdInSamples { [Deprecated("INDDownloadEngine is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 196608, "Windows.Foundation.UniversalApiContract")] get; }

    /// <summary>Gets the download engine notifier that will provide notification of download stream events from the transmitter.</summary>
    /// <returns>A download engine notifier created from the INDDownloadEngineNotifier interface.</returns>
    NDDownloadEngineNotifier Notifier { [Deprecated("INDDownloadEngine is deprecated and might not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 196608, "Windows.Foundation.UniversalApiContract")] get; }
  }
}
