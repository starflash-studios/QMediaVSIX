// Decompiled with JetBrains decompiler
// Type: Windows.Foundation.Diagnostics.AsyncCausalityTracer
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System;
using System.Runtime.CompilerServices;
using Windows.Foundation.Metadata;

namespace Windows.Foundation.Diagnostics
{
  /// <summary>Enables tracing control flow across asynchronous operations.</summary>
  [Muse(Version = 100859904)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Static(typeof (IAsyncCausalityTracerStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [DualApiPartition(version = 167772166)]
  public static class AsyncCausalityTracer
  {
    /// <summary>Logs the creation of an asynchronous operation.</summary>
    /// <param name="traceLevel">The trace level.</param>
    /// <param name="source">The trace source.</param>
    /// <param name="platformId">Identifier for the operation type.</param>
    /// <param name="operationId">An identifier for the asynchronous operation that's unique within the platform for the operation's lifetime.</param>
    /// <param name="operationName">A human-readable description of the asynchronous work.</param>
    /// <param name="relatedContext">Additional information related to this operation.</param>
    [MethodImpl]
    public static extern void TraceOperationCreation(
      CausalityTraceLevel traceLevel,
      CausalitySource source,
      Guid platformId,
      ulong operationId,
      string operationName,
      ulong relatedContext);

    /// <summary>Indicates that a previously created asynchronous operation has completed all of its asynchronous work.</summary>
    /// <param name="traceLevel">The trace level.</param>
    /// <param name="source">The trace source.</param>
    /// <param name="platformId">Identifier for the operation type.</param>
    /// <param name="operationId">The identifier for the asynchronous operation that's unique within the platform for the operation's lifetime.</param>
    /// <param name="status">The completion status of the asynchronous operation.</param>
    [MethodImpl]
    public static extern void TraceOperationCompletion(
      CausalityTraceLevel traceLevel,
      CausalitySource source,
      Guid platformId,
      ulong operationId,
      AsyncStatus status);

    /// <summary>Logs the relation between the currently running synchronous work item and a specific asynchronous operation that it's related to.</summary>
    /// <param name="traceLevel">The trace level.</param>
    /// <param name="source">The trace source.</param>
    /// <param name="platformId">Identifier for the operation type.</param>
    /// <param name="operationId">The identifier for the asynchronous operation that's unique within the platform for the operation's lifetime.</param>
    /// <param name="relation">The relationship between the synchronous work item and asynchronous operation identified by *operationId*.</param>
    [MethodImpl]
    public static extern void TraceOperationRelation(
      CausalityTraceLevel traceLevel,
      CausalitySource source,
      Guid platformId,
      ulong operationId,
      CausalityRelation relation);

    /// <summary>Indicates that the specified asynchronous operation is scheduling synchronous work on the thread that the TraceSynchronousWorkStart method is called on.</summary>
    /// <param name="traceLevel">The trace level.</param>
    /// <param name="source">The trace source.</param>
    /// <param name="platformId">Identifier for the operation type.</param>
    /// <param name="operationId">The identifier for the asynchronous operation that's unique within the platform for the operation's lifetime.</param>
    /// <param name="work">The relationship between the work item and the asynchronous operation.</param>
    [MethodImpl]
    public static extern void TraceSynchronousWorkStart(
      CausalityTraceLevel traceLevel,
      CausalitySource source,
      Guid platformId,
      ulong operationId,
      CausalitySynchronousWork work);

    /// <summary>Indicates that the most recently created synchronous work item running on the thread that the TraceSynchronousWorkCompletion method is called on has completed.</summary>
    /// <param name="traceLevel">The trace level.</param>
    /// <param name="source">The trace source.</param>
    /// <param name="work">Indicates the type of completion.</param>
    [MethodImpl]
    public static extern void TraceSynchronousWorkCompletion(
      CausalityTraceLevel traceLevel,
      CausalitySource source,
      CausalitySynchronousWork work);

    /// <summary>Raised when a client starts listening to the causality trace.</summary>
    public static extern event EventHandler<TracingStatusChangedEventArgs> TracingStatusChanged;
  }
}
