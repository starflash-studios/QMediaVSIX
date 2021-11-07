﻿// Decompiled with JetBrains decompiler
// Type: Windows.Storage.Streams.DataWriterStoreOperation
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Storage.Streams
{
  /// <summary>Commits data in a buffer to a backing store.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class DataWriterStoreOperation : IAsyncOperation<uint>, IAsyncInfo
  {
    /// <summary>Gets or sets the handler to call when the data store operation is complete.</summary>
    /// <returns>The handler to call when the operation is complete.</returns>
    public extern AsyncOperationCompletedHandler<uint> Completed { [MethodImpl] set; [MethodImpl] get; }

    /// <summary>Returns the result of the data store operation.</summary>
    /// <returns>The number of bytes returned by the StoreAsync method of the DataWriter.</returns>
    [MethodImpl]
    public extern uint GetResults();

    /// <summary>Gets a unique identifier that represents the data store operation.</summary>
    /// <returns>The identifier.</returns>
    public extern uint Id { [MethodImpl] get; }

    /// <summary>Gets the current status of the data store operation.</summary>
    /// <returns>One of the enumeration values.</returns>
    public extern AsyncStatus Status { [MethodImpl] get; }

    /// <summary>Gets the error code for the data store operation if it fails.</summary>
    /// <returns>The status of the operation.</returns>
    public extern HResult ErrorCode { [MethodImpl] get; }

    /// <summary>Requests the cancellation of the data store operation.</summary>
    [MethodImpl]
    public extern void Cancel();

    /// <summary>Requests that work associated with the data store operation should stop.</summary>
    [MethodImpl]
    public extern void Close();
  }
}