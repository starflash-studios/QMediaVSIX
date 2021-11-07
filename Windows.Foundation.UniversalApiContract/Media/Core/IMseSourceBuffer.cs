// Decompiled with JetBrains decompiler
// Type: Windows.Media.Core.IMseSourceBuffer
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Media.Core
{
  [WebHostHidden]
  [Guid(203072483, 57229, 16505, 163, 254, 104, 73, 24, 75, 78, 47)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (MseSourceBuffer))]
  internal interface IMseSourceBuffer
  {
    event TypedEventHandler<MseSourceBuffer, object> UpdateStarting;

    event TypedEventHandler<MseSourceBuffer, object> Updated;

    event TypedEventHandler<MseSourceBuffer, object> UpdateEnded;

    event TypedEventHandler<MseSourceBuffer, object> ErrorOccurred;

    event TypedEventHandler<MseSourceBuffer, object> Aborted;

    MseAppendMode Mode { get; set; }

    bool IsUpdating { get; }

    IVectorView<MseTimeRange> Buffered { get; }

    TimeSpan TimestampOffset { get; set; }

    TimeSpan AppendWindowStart { get; set; }

    IReference<TimeSpan> AppendWindowEnd { get; set; }

    void AppendBuffer(IBuffer buffer);

    [Overload("AppendStream")]
    void AppendStream(IInputStream stream);

    [Overload("AppendStreamMaxSize")]
    void AppendStream(IInputStream stream, ulong maxSize);

    void Abort();

    void Remove(TimeSpan start, IReference<TimeSpan> end);
  }
}
