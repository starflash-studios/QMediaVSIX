// Decompiled with JetBrains decompiler
// Type: Windows.Media.MediaTimelineControllerFailedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media
{
  /// <summary>Provides data for the Failed event, which occurs when the timeline controller encounters an error and can't continue playback.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [DualApiPartition(version = 167772160)]
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  public sealed class MediaTimelineControllerFailedEventArgs : 
    IMediaTimelineControllerFailedEventArgs
  {
    /// <summary>Gets the extended error code associated with the event.</summary>
    /// <returns>The extended error code associated with the event.</returns>
    public extern HResult ExtendedError { [MethodImpl] get; }
  }
}
