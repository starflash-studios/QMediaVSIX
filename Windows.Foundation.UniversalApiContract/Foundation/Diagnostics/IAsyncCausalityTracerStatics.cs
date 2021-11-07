// Decompiled with JetBrains decompiler
// Type: Windows.Foundation.Diagnostics.IAsyncCausalityTracerStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System;
using Windows.Foundation.Metadata;

namespace Windows.Foundation.Diagnostics
{
  [Guid(1350896422, 9854, 17691, 168, 144, 171, 106, 55, 2, 69, 238)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (AsyncCausalityTracer))]
  internal interface IAsyncCausalityTracerStatics
  {
    void TraceOperationCreation(
      CausalityTraceLevel traceLevel,
      CausalitySource source,
      Guid platformId,
      ulong operationId,
      string operationName,
      ulong relatedContext);

    void TraceOperationCompletion(
      CausalityTraceLevel traceLevel,
      CausalitySource source,
      Guid platformId,
      ulong operationId,
      AsyncStatus status);

    void TraceOperationRelation(
      CausalityTraceLevel traceLevel,
      CausalitySource source,
      Guid platformId,
      ulong operationId,
      CausalityRelation relation);

    void TraceSynchronousWorkStart(
      CausalityTraceLevel traceLevel,
      CausalitySource source,
      Guid platformId,
      ulong operationId,
      CausalitySynchronousWork work);

    void TraceSynchronousWorkCompletion(
      CausalityTraceLevel traceLevel,
      CausalitySource source,
      CausalitySynchronousWork work);

    event EventHandler<TracingStatusChangedEventArgs> TracingStatusChanged;
  }
}
