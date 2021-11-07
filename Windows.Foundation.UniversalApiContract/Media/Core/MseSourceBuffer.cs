// Decompiled with JetBrains decompiler
// Type: Windows.Media.Core.MseSourceBuffer
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Media.Core
{
  /// <summary>Represents a media source extensions (MSE) source buffer.</summary>
  [DualApiPartition(version = 167772160)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Threading(ThreadingModel.Both)]
  public sealed class MseSourceBuffer : IMseSourceBuffer
  {
    /// <summary>Occurs when the MseSourceBuffer update is starting.</summary>
    public extern event TypedEventHandler<MseSourceBuffer, object> UpdateStarting;

    /// <summary>Occurs when the MseSourceBuffer is updated.</summary>
    public extern event TypedEventHandler<MseSourceBuffer, object> Updated;

    /// <summary>Occurs when the MseSourceBuffer update has ended.</summary>
    public extern event TypedEventHandler<MseSourceBuffer, object> UpdateEnded;

    /// <summary>Occurs when the MseSourceBuffer has an error.</summary>
    public extern event TypedEventHandler<MseSourceBuffer, object> ErrorOccurred;

    /// <summary>Occurs when the MseSourceBuffer is aborted.</summary>
    public extern event TypedEventHandler<MseSourceBuffer, object> Aborted;

    /// <summary>Gets and sets how the MseSourceBuffer object appends a buffer.</summary>
    /// <returns>A MseAppendMode -typed value that specifies how MseSourceBuffer appends a buffer.</returns>
    public extern MseAppendMode Mode { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets a value indicating whether the buffer is updating.</summary>
    /// <returns>True if the buffer is updating; otherwise, false.</returns>
    public extern bool IsUpdating { [MethodImpl] get; }

    /// <summary>Gets how the MseSourceBuffer object is buffered.</summary>
    /// <returns>The buffered value in terms of a MseTimeRange.</returns>
    public extern IVectorView<MseTimeRange> Buffered { [MethodImpl] get; }

    /// <summary>Gets and sets the timestamp offset into the MseSourceBuffer object.</summary>
    /// <returns>The timestamp offset value.</returns>
    public extern TimeSpan TimestampOffset { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets and sets the append-window-start interval.</summary>
    /// <returns>The interval value.</returns>
    public extern TimeSpan AppendWindowStart { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets and sets the append-window-end interval.</summary>
    /// <returns>The interval value.</returns>
    public extern IReference<TimeSpan> AppendWindowEnd { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Appends a buffer to the MseSourceBuffer object.</summary>
    /// <param name="buffer">The buffer to append.</param>
    [MethodImpl]
    public extern void AppendBuffer(IBuffer buffer);

    /// <summary>Appends a stream to the MseSourceBuffer object.</summary>
    /// <param name="stream">The stream to append.</param>
    [Overload("AppendStream")]
    [MethodImpl]
    public extern void AppendStream(IInputStream stream);

    /// <summary>Appends a stream to the MseSourceBuffer object.</summary>
    /// <param name="stream">The stream to append.</param>
    /// <param name="maxSize">The maximum size of the stream.</param>
    [Overload("AppendStreamMaxSize")]
    [MethodImpl]
    public extern void AppendStream(IInputStream stream, ulong maxSize);

    /// <summary>Aborts media source extensions (MSE) source buffer.</summary>
    [MethodImpl]
    public extern void Abort();

    [MethodImpl]
    public extern void Remove(TimeSpan start, IReference<TimeSpan> end);
  }
}
