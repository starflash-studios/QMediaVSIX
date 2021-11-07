// Decompiled with JetBrains decompiler
// Type: Windows.Networking.BackgroundTransfer.BackgroundDownloader
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Security.Credentials;
using Windows.Storage;
using Windows.Storage.Streams;
using Windows.UI.Notifications;

namespace Windows.Networking.BackgroundTransfer
{
  /// <summary>Used to configure downloads prior to the actual creation of the download operation using CreateDownload. For an overview of Background Transfer capabilities, see [Transferring data in the background](https://docs.microsoft.com/previous-versions/windows/apps/hh452979(v=win.10)). Download the Background Transfer sample for examples in JavaScript, C#, and C++.</summary>
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [Static(typeof (IBackgroundDownloaderStaticMethods), 65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Static(typeof (IBackgroundDownloaderStaticMethods2), 65536, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  [Static(typeof (IBackgroundDownloaderUserConsent), 65536, "Windows.Foundation.UniversalApiContract")]
  [Activatable(typeof (IBackgroundDownloaderFactory), 65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class BackgroundDownloader : 
    IBackgroundDownloader,
    IBackgroundTransferBase,
    IBackgroundDownloader2,
    IBackgroundDownloader3
  {
    /// <summary>Creates a new BackgroundDownloader object with a BackgroundTransferCompletionGroup.</summary>
    /// <param name="completionGroup">The completion group to associate with this BackgroundDownloader object.</param>
    [MethodImpl]
    public extern BackgroundDownloader(BackgroundTransferCompletionGroup completionGroup);

    /// <summary>Creates a new BackgroundDownloader object.</summary>
    [MethodImpl]
    public extern BackgroundDownloader();

    [Overload("CreateDownload")]
    [MethodImpl]
    public extern DownloadOperation CreateDownload(
      Uri uri,
      IStorageFile resultFile);

    [Overload("CreateDownloadFromFile")]
    [MethodImpl]
    public extern DownloadOperation CreateDownload(
      Uri uri,
      IStorageFile resultFile,
      IStorageFile requestBodyFile);

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<DownloadOperation> CreateDownloadAsync(
      Uri uri,
      IStorageFile resultFile,
      IInputStream requestBodyStream);

    /// <summary>Used to set an HTTP request header.</summary>
    /// <param name="headerName">The header name.</param>
    /// <param name="headerValue">The header value.</param>
    [MethodImpl]
    public extern void SetRequestHeader(string headerName, string headerValue);

    /// <summary>Gets or sets the credentials to use to authenticate with the origin server.</summary>
    /// <returns>The credential to use for authentication.</returns>
    public extern PasswordCredential ServerCredential { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the proxy credentials for the background transfer.</summary>
    /// <returns>The credentials used to authenticate with an HTTP proxy.</returns>
    public extern PasswordCredential ProxyCredential { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the HTTP method used for the background download. The default method used for download operations is GET.</summary>
    /// <returns>The method to use for the background download. Setting this property will override the default method used for the operation.</returns>
    public extern string Method { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a string value (for example, a GUID ) indicating the group the transfer will belong to. A download operation with a group ID will only appear in operation enumerations using GetCurrentDownloadsAsync(String) with the specific group string value.</summary>
    /// <returns>The group name.</returns>
    public extern string Group { [Deprecated("Group may be altered or unavailable for releases after Windows 8.1. Instead, use TransferGroup.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract"), MethodImpl] get; [Deprecated("Group may be altered or unavailable for releases after Windows 8.1. Instead, use TransferGroup.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract"), MethodImpl] set; }

    /// <summary>Gets or sets the cost policy for the background download operation.</summary>
    /// <returns>Indicates whether transfers can occur on costed networks.</returns>
    public extern BackgroundTransferCostPolicy CostPolicy { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the group that a download operation will belong to.</summary>
    /// <returns>The group to associate with the download.</returns>
    public extern BackgroundTransferGroup TransferGroup { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the ToastNotification that defines the content, associated metadata, and events used in a toast notification to indicate success of a download to the user.</summary>
    /// <returns>The ToastNotification used to indicate download success.</returns>
    public extern ToastNotification SuccessToastNotification { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the ToastNotification that defines the content, associated metadata, and events used in a toast notification to indicate failure of a download to the user.</summary>
    /// <returns>The ToastNotification used to indicate download failure.</returns>
    public extern ToastNotification FailureToastNotification { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the TileNotification used to define the visuals, identification tag, and expiration time of a tile notification used to update the app tile when indicating success of a download to the user.</summary>
    /// <returns>The TileNotification used to indicate download success.</returns>
    public extern TileNotification SuccessTileNotification { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the TileNotification used to define the visuals, identification tag, and expiration time of a tile notification used to update the app tile when indicating failure of a download to the user.</summary>
    /// <returns>The TileNotification used to indicate download failure.</returns>
    public extern TileNotification FailureTileNotification { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets the BackgroundTransferCompletionGroup associated with the BackgroundDownloader.</summary>
    /// <returns>The BackgroundTransferCompletionGroup associated with the BackgroundDownloader . This property can be null.</returns>
    public extern BackgroundTransferCompletionGroup CompletionGroup { [MethodImpl] get; }

    /// <summary>Gets all downloads associated with the provided BackgroundTransferGroup.</summary>
    /// <param name="group">Contains information used to identify a group of downloads.</param>
    /// <returns>A list of downloads currently associated with the specified group.</returns>
    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<IVectorView<DownloadOperation>> GetCurrentDownloadsForTransferGroupAsync(
      BackgroundTransferGroup group);

    [RemoteAsync]
    [Deprecated("RequestUnconstrainedDownloadsAsync is deprecated and may not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 196608, "Windows.Foundation.UniversalApiContract")]
    [MethodImpl]
    public static extern IAsyncOperation<UnconstrainedTransferRequestResult> RequestUnconstrainedDownloadsAsync(
      IIterable<DownloadOperation> operations);

    /// <summary>Returns a collection of pending downloads that are not associated with a BackgroundTransferGroup.</summary>
    /// <returns>A collection of pending downloads for the current application instance.</returns>
    [Overload("GetCurrentDownloadsAsync")]
    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<IVectorView<DownloadOperation>> GetCurrentDownloadsAsync();

    /// <summary>Returns a collection of pending downloads for a specific Group.</summary>
    /// <deprecated type="deprecate">GetCurrentDownloadsAsync(group) may be altered or unavailable for releases after Windows 8.1. Instead, use GetCurrentDownloadsForTransferGroupAsync.</deprecated>
    /// <param name="group">A string indicating a specific group of transfers.</param>
    /// <returns>A collection of pending downloads for the specific group.</returns>
    [Overload("GetCurrentDownloadsForGroupAsync")]
    [RemoteAsync]
    [Deprecated("GetCurrentDownloadsAsync(group) may be altered or unavailable for releases after Windows 8.1. Instead, use GetCurrentDownloadsForTransferGroupAsync.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract")]
    [MethodImpl]
    public static extern IAsyncOperation<IVectorView<DownloadOperation>> GetCurrentDownloadsAsync(
      string group);
  }
}
