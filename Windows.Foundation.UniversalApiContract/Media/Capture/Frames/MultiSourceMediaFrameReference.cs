// Decompiled with JetBrains decompiler
// Type: Windows.Media.Capture.Frames.MultiSourceMediaFrameReference
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Capture.Frames
{
  /// <summary>A wrapper class that provides access to time-correlated frames obtained from one or more MediaFrameSource objects. Call  TryGetFrameReferenceBySourceId to get the MediaFrameReference representing a frame from a particular media frame source.</summary>
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [DualApiPartition(version = 167772163)]
  public sealed class MultiSourceMediaFrameReference : IMultiSourceMediaFrameReference, IClosable
  {
    /// <summary>Attempts to get a time-correlated MediaFrameReference for the specified media frame source.</summary>
    /// <param name="sourceId">The Id property of the MediaFrameSourceInfo object representing the media frame source from which a frame reference should be retreived.</param>
    /// <returns>A MediaFrameReference representing a time-correlated media frame.</returns>
    [MethodImpl]
    public extern MediaFrameReference TryGetFrameReferenceBySourceId(
      string sourceId);

    [MethodImpl]
    public extern void Close();
  }
}
