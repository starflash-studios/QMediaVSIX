// Decompiled with JetBrains decompiler
// Type: Windows.Networking.BackgroundTransfer.UploadOperation
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System;
using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage;
using Windows.Storage.Streams;

namespace Windows.Networking.BackgroundTransfer
{
  /// <summary>Performs an asynchronous upload operation. For an overview of Background Transfer capabilities, see [Transferring data in the background](https://docs.microsoft.com/previous-versions/windows/apps/hh452979(v=win.10)). Download the Background Transfer sample for examples in JavaScript, C#, and C++.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class UploadOperation : 
    IUploadOperation,
    IBackgroundTransferOperation,
    IBackgroundTransferOperationPriority,
    IUploadOperation2,
    IUploadOperation3,
    IUploadOperation4
  {
    /// <summary>Specifies the IStorageFile to upload.</summary>
    /// <returns>The file item to upload.</returns>
    public extern IStorageFile SourceFile { [MethodImpl] get; }

    /// <summary>Gets the current progress of the upload operation.</summary>
    /// <returns>The delegate to invoke when progress is available for a transfer operation.</returns>
    public extern BackgroundUploadProgress Progress { [MethodImpl] get; }

    /// <summary>Starts an asynchronous upload operation.</summary>
    /// <returns>An asynchronous upload operation that includes progress updates.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperationWithProgress<UploadOperation, UploadOperation> StartAsync();

    /// <summary>Returns an asynchronous operation that can be used to monitor progress and completion of the attached upload. Calling this method allows an app to attach upload operations that were started in a previous app instance.</summary>
    /// <returns>Upload operation with callback.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperationWithProgress<UploadOperation, UploadOperation> AttachAsync();

    /// <summary>This is a unique identifier for a specific upload operation. A GUID associated to a upload operation will not change for the duration of the upload.</summary>
    /// <returns>The unique ID for this upload operation.</returns>
    public extern Guid Guid { [MethodImpl] get; }

    /// <summary>Gets the URI to upload from.</summary>
    /// <returns>The URI to upload from.</returns>
    public extern global::Windows.Foundation.Uri RequestedUri { [MethodImpl] get; }

    /// <summary>Gets the method to use for the upload.</summary>
    /// <returns>The method to use for the upload. This value can be **GET**, **PUT**, **POST**, **RETR**, **STOR**, or any custom value supported by the server.</returns>
    public extern string Method { [MethodImpl] get; }

    /// <summary>Gets a string value indicating the group the upload belongs to.</summary>
    /// <returns>The group name.</returns>
    public extern string Group { [Deprecated("Group may be altered or unavailable for releases after Windows 8.1. Instead, use TransferGroup.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract"), MethodImpl] get; }

    /// <summary>Gets and sets the cost policy for the upload.</summary>
    /// <returns>Specifies whether the transfer can happen over costed networks.</returns>
    public extern BackgroundTransferCostPolicy CostPolicy { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets the partially uploaded response at the specified location.</summary>
    /// <param name="position">The position at which to start reading.</param>
    /// <returns>The result stream.</returns>
    [MethodImpl]
    public extern IInputStream GetResultStreamAt(ulong position);

    /// <summary>Gets the response information.</summary>
    /// <returns>Contains the data returned by a server response.</returns>
    [MethodImpl]
    public extern ResponseInformation GetResponseInformation();

    /// <summary>Gets or sets the transfer priority of this upload operation when within a BackgroundTransferGroup. Possible values are defined by BackgroundTransferPriority.</summary>
    /// <returns>The operation priority.</returns>
    public extern BackgroundTransferPriority Priority { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets the group that this upload operation belongs to.</summary>
    /// <returns>The transfer group.</returns>
    public extern BackgroundTransferGroup TransferGroup { [MethodImpl] get; }

    /// <summary>Prioritizes the upload transfer operation (and any transfers that follow it in the same transfer group). Calling this method on a transfer that doesn't belong to a transfer group has no effect.</summary>
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
