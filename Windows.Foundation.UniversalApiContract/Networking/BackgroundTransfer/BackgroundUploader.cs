// Decompiled with JetBrains decompiler
// Type: Windows.Networking.BackgroundTransfer.BackgroundUploader
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
  /// <summary>Used to configure upload prior to the actual creation of the upload operation using CreateUpload. For an overview of Background Transfer capabilities, see [Transferring data in the background](https://docs.microsoft.com/previous-versions/windows/apps/hh452979(v=win.10)). Download the Background Transfer sample for examples in JavaScript, C#, and C++.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [Static(typeof (IBackgroundUploaderStaticMethods), 65536, "Windows.Foundation.UniversalApiContract")]
  [Activatable(typeof (IBackgroundUploaderFactory), 65536, "Windows.Foundation.UniversalApiContract")]
  [Static(typeof (IBackgroundUploaderUserConsent), 65536, "Windows.Foundation.UniversalApiContract")]
  [Static(typeof (IBackgroundUploaderStaticMethods2), 65536, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  public sealed class BackgroundUploader : 
    IBackgroundUploader,
    IBackgroundTransferBase,
    IBackgroundUploader2,
    IBackgroundUploader3
  {
    /// <summary>Instantiates a new BackgroundUploader object as a member of a completion group.</summary>
    /// <param name="completionGroup">The completion group that the created BackgroundUploader instance is to be a member of.</param>
    [MethodImpl]
    public extern BackgroundUploader(BackgroundTransferCompletionGroup completionGroup);

    /// <summary>Instantiates a new BackgroundUploader object.</summary>
    [MethodImpl]
    public extern BackgroundUploader();

    [MethodImpl]
    public extern UploadOperation CreateUpload(Uri uri, IStorageFile sourceFile);

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<UploadOperation> CreateUploadFromStreamAsync(
      Uri uri,
      IInputStream sourceStream);

    [RemoteAsync]
    [Overload("CreateUploadWithFormDataAndAutoBoundaryAsync")]
    [MethodImpl]
    public extern IAsyncOperation<UploadOperation> CreateUploadAsync(
      Uri uri,
      IIterable<BackgroundTransferContentPart> parts);

    [Overload("CreateUploadWithSubTypeAsync")]
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<UploadOperation> CreateUploadAsync(
      Uri uri,
      IIterable<BackgroundTransferContentPart> parts,
      string subType);

    [Overload("CreateUploadWithSubTypeAndBoundaryAsync")]
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<UploadOperation> CreateUploadAsync(
      Uri uri,
      IIterable<BackgroundTransferContentPart> parts,
      string subType,
      string boundary);

    /// <summary>Used to set an HTTP request header.</summary>
    /// <param name="headerName">The header name.</param>
    /// <param name="headerValue">The header value.</param>
    [MethodImpl]
    public extern void SetRequestHeader(string headerName, string headerValue);

    /// <summary>Gets or sets the credentials to use to authenticate with the origin server.</summary>
    /// <returns>The credential to use for authentication.</returns>
    public extern PasswordCredential ServerCredential { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the proxy credentials for the upload.</summary>
    /// <returns>The credentials used to authenticate with an HTTP proxy.</returns>
    public extern PasswordCredential ProxyCredential { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the HTTP method used for the upload. The default method used for upload operations is POST.</summary>
    /// <returns>The method to use for the background upload. Setting this property will override the default method used for the operation.</returns>
    public extern string Method { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a string value (for example, a GUID ) indicating the group the upload will belong to. An upload operation with a group ID will only appear in operation enumerations using GetCurrentDownloadsAsync(String) with the specific group string value.</summary>
    /// <returns>The group name.</returns>
    public extern string Group { [Deprecated("Group may be altered or unavailable for releases after Windows 8.1. Instead, use TransferGroup.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract"), MethodImpl] get; [Deprecated("Group may be altered or unavailable for releases after Windows 8.1. Instead, use TransferGroup.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract"), MethodImpl] set; }

    /// <summary>Gets or sets the cost policy for the background upload operation.</summary>
    /// <returns>Indicates whether transfers can occur on costed networks.</returns>
    public extern BackgroundTransferCostPolicy CostPolicy { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the group that an upload operation will belong to.</summary>
    /// <returns>The group to associate with the upload.</returns>
    public extern BackgroundTransferGroup TransferGroup { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the ToastNotification that defines the content, associated metadata, and events used in a toast notification to indicate success of an upload to the user.</summary>
    /// <returns>The ToastNotification used to indicate upload success.</returns>
    public extern ToastNotification SuccessToastNotification { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the ToastNotification that defines the content, associated metadata, and events used in a toast notification to indicate failure of an upload to the user.</summary>
    /// <returns>The ToastNotification used to indicate upload failure.</returns>
    public extern ToastNotification FailureToastNotification { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets and sets the TileNotification used to define the visuals, identification tag, and expiration time of a tile notification used to update the app tile when indicating success of an upload to the user.</summary>
    /// <returns>The TileNotification used to indicate upload success.</returns>
    public extern TileNotification SuccessTileNotification { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets and sets the TileNotification used to define the visuals, identification tag, and expiration time of a tile notification used to update the app tile when indicating failure of an upload to the user.</summary>
    /// <returns>The TileNotification used to indicate upload failure.</returns>
    public extern TileNotification FailureTileNotification { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets the BackgroundTransferCompletionGroup associated with the BackgroundUploader.</summary>
    /// <returns>The BackgroundTransferCompletionGroup associated with the BackgroundUploader. This property can be null.</returns>
    public extern BackgroundTransferCompletionGroup CompletionGroup { [MethodImpl] get; }

    /// <summary>Gets all uploads associated with the provided BackgroundTransferGroup.</summary>
    /// <param name="group">Contains information used to identify a group of uploads.</param>
    /// <returns>A list of uploads currently associated with the specified group.</returns>
    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<IVectorView<UploadOperation>> GetCurrentUploadsForTransferGroupAsync(
      BackgroundTransferGroup group);

    [RemoteAsync]
    [Deprecated("RequestUnconstrainedUploadsAsync is deprecated and may not work on all platforms. For more info, see MSDN.", DeprecationType.Deprecate, 196608, "Windows.Foundation.UniversalApiContract")]
    [MethodImpl]
    public static extern IAsyncOperation<UnconstrainedTransferRequestResult> RequestUnconstrainedUploadsAsync(
      IIterable<UploadOperation> operations);

    /// <summary>Returns a collection of pending uploads that are not associated with a group.</summary>
    /// <returns>A collection of pending uploads for the current application instance.</returns>
    [RemoteAsync]
    [Overload("GetCurrentUploadsAsync")]
    [MethodImpl]
    public static extern IAsyncOperation<IVectorView<UploadOperation>> GetCurrentUploadsAsync();

    /// <summary>Returns a collection of pending uploads for a specific Group.</summary>
    /// <deprecated type="deprecate">GetCurrentUploadsAsync(group) may be altered or unavailable for releases after Windows 8.1. Instead, use GetCurrentUploadsForTransferGroupAsync.</deprecated>
    /// <param name="group">A string indicating a specific group of uploads.</param>
    /// <returns>A collection of pending uploads for the specific group.</returns>
    [RemoteAsync]
    [Deprecated("GetCurrentUploadsAsync(group) may be altered or unavailable for releases after Windows 8.1. Instead, use GetCurrentUploadsForTransferGroupAsync.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract")]
    [Overload("GetCurrentUploadsForGroupAsync")]
    [MethodImpl]
    public static extern IAsyncOperation<IVectorView<UploadOperation>> GetCurrentUploadsAsync(
      string group);
  }
}
