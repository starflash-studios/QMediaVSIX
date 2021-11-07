// Decompiled with JetBrains decompiler
// Type: Windows.Networking.BackgroundTransfer.DownloadOperation
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System;
using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Storage;
using Windows.Storage.Streams;
using Windows.Web;

namespace Windows.Networking.BackgroundTransfer
{
  /// <summary>Performs an asynchronous download operation. The Background Transfer sample demonstrates this functionality. For an overview of Background Transfer capabilities, see [Transferring data in the background](https://docs.microsoft.com/previous-versions/windows/apps/hh452979(v=win.10)). Download the Background Transfer sample for examples in JavaScript, C#, and C++/CX.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class DownloadOperation : 
    IDownloadOperation,
    IBackgroundTransferOperation,
    IBackgroundTransferOperationPriority,
    IDownloadOperation2,
    IDownloadOperation3,
    IDownloadOperation4,
    IDownloadOperation5
  {
    /// <summary>Returns the IStorageFile object provided by the caller when creating the DownloadOperation object using CreateDownload.</summary>
    /// <returns>The returned file object.</returns>
    public extern IStorageFile ResultFile { [MethodImpl] get; }

    /// <summary>Gets the current progress of the operation.</summary>
    /// <returns>An instance of a BackgroundDownloadProgress struct describing the current download operation's progress.</returns>
    public extern BackgroundDownloadProgress Progress { [MethodImpl] get; }

    /// <summary>Starts an asynchronous download operation.</summary>
    /// <returns>An asynchronous download operation that includes progress updates.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperationWithProgress<DownloadOperation, DownloadOperation> StartAsync();

    /// <summary>Returns an asynchronous operation that can be used to monitor progress and completion of the attached download. Calling this method allows an app to attach download operations that were started in a previous app instance.</summary>
    /// <returns>Download operation with callback.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperationWithProgress<DownloadOperation, DownloadOperation> AttachAsync();

    /// <summary>Pauses a download operation.</summary>
    [MethodImpl]
    public extern void Pause();

    /// <summary>Resumes a paused download operation.</summary>
    [MethodImpl]
    public extern void Resume();

    /// <summary>This is a unique identifier for a specific download operation. A GUID associated to a download operation will not change for the duration of the download.</summary>
    /// <returns>The unique ID for this download operation.</returns>
    public extern Guid Guid { [MethodImpl] get; }

    /// <summary>Gets the URI from which to download the file.</summary>
    /// <returns>The URI to download from.</returns>
    public extern global::Windows.Foundation.Uri RequestedUri { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets the method to use for the download.</summary>
    /// <returns>The method to use for the download. This value can be **GET**, **PUT**, **RETR**, or **STOR**.</returns>
    public extern string Method { [MethodImpl] get; }

    /// <summary>Gets a string value indicating the group the transfer belongs to.</summary>
    /// <returns>The group name.</returns>
    public extern string Group { [Deprecated("Group may be altered or unavailable for releases after Windows 8.1. Instead, use TransferGroup.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract"), MethodImpl] get; }

    /// <summary>Gets and sets the cost policy for the download.</summary>
    /// <returns>Specifies whether the transfer can happen over costed networks.</returns>
    public extern BackgroundTransferCostPolicy CostPolicy { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets the partially downloaded response at the specified position.</summary>
    /// <param name="position">The position at which to start reading.</param>
    /// <returns>The result stream.</returns>
    [MethodImpl]
    public extern IInputStream GetResultStreamAt(ulong position);

    /// <summary>Gets the response information.</summary>
    /// <returns>Contains the data returned by a server response.</returns>
    [MethodImpl]
    public extern ResponseInformation GetResponseInformation();

    /// <summary>Gets or sets the transfer priority of this download operation when within a BackgroundTransferGroup. Possible values are defined by BackgroundTransferPriority.</summary>
    /// <returns>The operation priority.</returns>
    public extern BackgroundTransferPriority Priority { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets the group that this download operation belongs to.</summary>
    /// <returns>The transfer group.</returns>
    public extern BackgroundTransferGroup TransferGroup { [MethodImpl] get; }

    /// <summary>A boolean property to enable random access. The property must be set to TRUE before calling StartAsync() on a DownloadOperation object to use the random access feature. After calling StartAsync(), call GetResultRandomAccessStreamReference to get a reference to the random access stream and read from it.</summary>
    /// <returns>TRUE to use the random access feature. The default value is FALSE.</returns>
    public extern bool IsRandomAccessRequired { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets a reference to the random access stream and reads from it. It's necessary to set IsRandomAccessRequired to TRUE before calling GetResultRandomAccessStreamReference.</summary>
    /// <returns>A reference to the random access stream.</returns>
    [MethodImpl]
    public extern IRandomAccessStreamReference GetResultRandomAccessStreamReference();

    /// <summary>Returns the full list of file ranges that have been downloaded so far.</summary>
    /// <returns>Returns an IVector&lt;BackgroundTransferFileRange&gt;.</returns>
    [MethodImpl]
    public extern IVector<BackgroundTransferFileRange> GetDownloadedRanges();

    /// <summary>Provides access to incremental download progress.</summary>
    public extern event TypedEventHandler<DownloadOperation, BackgroundTransferRangesDownloadedEventArgs> RangesDownloaded;

    /// <summary>A set of WebErrorStatus values that applications anticipate the download will hit, and that the applications know how to handle.</summary>
    /// <returns>A set of WebErrorStatus values.</returns>
    public extern IVector<WebErrorStatus> RecoverableWebErrorStatuses { [MethodImpl] get; }

    /// <summary>A transfer's WebErrorStatus, which can be monitored during the lifetime of the DownloadOperation.</summary>
    /// <returns>A WebErrorStatus error.</returns>
    public extern IReference<WebErrorStatus> CurrentWebErrorStatus { [MethodImpl] get; }

    /// <summary>Prioritizes the download transfer operation (and any transfers that follow it in the same transfer group). Calling this method on a transfer that doesn't belong to a transfer group has no effect.</summary>
    [MethodImpl]
    public extern void MakeCurrentInTransferGroup();

    /// <summary>Used to set an HTTP request header.</summary>
    /// <param name="headerName">The header name.</param>
    /// <param name="headerValue">The header value.</param>
    [MethodImpl]
    public extern void SetRequestHeader(string headerName, string headerValue);

    /// <summary>Used to remove an HTTP request header.</summary>
    /// <param name="headerName">The header name.</param>
    [MethodImpl]
    public extern void RemoveRequestHeader(string headerName);
  }
}
