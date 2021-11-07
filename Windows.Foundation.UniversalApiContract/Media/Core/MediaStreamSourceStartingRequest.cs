// Decompiled with JetBrains decompiler
// Type: Windows.Media.Core.MediaStreamSourceStartingRequest
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Core
{
  /// <summary>Represents a request from the MediaStreamSource.Starting event for the application to start accumulating MediaStreamSample objects from a specific position in the media.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [DualApiPartition(version = 100859904)]
  public sealed class MediaStreamSourceStartingRequest : IMediaStreamSourceStartingRequest
  {
    /// <summary>Specifies a reference to a TimeSpan object which represents a time position in the media time-line from which the application should return MediaStreamSample objects.</summary>
    /// <returns>A reference that points to a TimeSpan which specifies the position in the media time-line to start sending MediaStreamSample objects. If the reference is **null**, the application should continue to return MediaStreamSample objects from the current position.</returns>
    public extern IReference<TimeSpan> StartPosition { [MethodImpl] get; }

    /// <summary>Defers completing the MediaStreamSource.Starting event.</summary>
    /// <returns>The deferral.</returns>
    [MethodImpl]
    public extern MediaStreamSourceStartingRequestDeferral GetDeferral();

    [MethodImpl]
    public extern void SetActualStartPosition(TimeSpan position);
  }
}
