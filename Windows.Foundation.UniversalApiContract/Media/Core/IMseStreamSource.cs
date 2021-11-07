// Decompiled with JetBrains decompiler
// Type: Windows.Media.Core.IMseStreamSource
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Core
{
  [Guid(2964593037, 756, 18723, 136, 221, 129, 188, 63, 54, 15, 250)]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (MseStreamSource))]
  internal interface IMseStreamSource : IMediaSource
  {
    event TypedEventHandler<MseStreamSource, object> Opened;

    event TypedEventHandler<MseStreamSource, object> Ended;

    event TypedEventHandler<MseStreamSource, object> Closed;

    MseSourceBufferList SourceBuffers { get; }

    MseSourceBufferList ActiveSourceBuffers { get; }

    MseReadyState ReadyState { get; }

    IReference<TimeSpan> Duration { get; set; }

    MseSourceBuffer AddSourceBuffer(string mimeType);

    void RemoveSourceBuffer(MseSourceBuffer buffer);

    void EndOfStream(MseEndOfStreamStatus status);
  }
}
