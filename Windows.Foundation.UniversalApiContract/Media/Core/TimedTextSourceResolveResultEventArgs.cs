// Decompiled with JetBrains decompiler
// Type: Windows.Media.Core.TimedTextSourceResolveResultEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Media.Core
{
  /// <summary>Provides data for the TimedTextSource.Resolved event.</summary>
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [DualApiPartition(version = 167772160)]
  public sealed class TimedTextSourceResolveResultEventArgs : ITimedTextSourceResolveResultEventArgs
  {
    /// <summary>Gets an object representing the asynchronous error that occurred when the TimedTextSource was resolved.</summary>
    /// <returns>An object representing the asynchronous error that occurred when the TimedTextSource was resolved.</returns>
    public extern TimedMetadataTrackError Error { [MethodImpl] get; }

    /// <summary>Gets the list of TimedMetadataTrack objects resulting from resolving the TimedTextSource.</summary>
    /// <returns>The list of TimedMetadataTrack objects.</returns>
    public extern IVectorView<TimedMetadataTrack> Tracks { [MethodImpl] get; }
  }
}
